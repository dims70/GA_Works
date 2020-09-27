using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleAccounts
{
    public partial class GACC : Form
    {
        string pathdata = Application.StartupPath + @"\data\acc.dat"; // путь до файла с акками
        string pathdataIP = Application.StartupPath + @"\data\IP.dat";//путь до файла с логинами айпи
        public GACC()
        {
            InitializeComponent();
            LoadIP();//загрузка айпи адреса. асинхронная.
        }

        private async void LoadIP()//метод загрузки в текстбок ip адреса через api
        {
            btnRefresh.Enabled = false;
            try // обработчик ошибок, потому что лень писать проверку соединения с интернетом...костыль
            {
                WebRequest request = WebRequest.Create(@"https://api.ipify.org/"); //создается запрос с параметром в виде ссылки
                WebResponse response = await request.GetResponseAsync(); //получаем переменную ответа в асинхронном режиме
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    ipBox.Text = await reader.ReadToEndAsync(); // асинхронное считывание в бокс
                }
                btnRefresh.Enabled = true;
            }
            catch //в случае ошибки, а у нас - ошибка в ответе от сервера, значит нет инета.
            {
                ipBox.Text = "Проверьте подключение...";
                btnRefresh.Enabled = true;//
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var directory = Application.StartupPath + @"\data"; //Директория для данных
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);//проверка на существование папки, если нет, создаем

            if (!checkExternal.Checked && btnRefresh.Enabled == true) // если галочка не стоит и кнопка обновления не активна, значит не игнорируем айпи и ждем его загрузки. если стоит игнорируем.
            {
                if (ipBox.Text != "ожидание...")//если в поле айпи ожидание, выводим сообщение в else 
                {
                    if (!string.IsNullOrEmpty(loginBox.Text) && !string.IsNullOrEmpty(passBox.Text) && !string.IsNullOrEmpty(numBox.Text)) // проверка на пустоту полей ввода 
                    {
                        if (IPAddress.TryParse(ipBox.Text, out IPAddress address))// если поля не пустые соответственно парсим айпи адрес что бы узнать если ли у нас интернет.
                        {// если есть выводим в переменную address и записываем с файл попытку создания через айпи. и записываем сам аккаунт
                            var ipLogin = $"Login attempt : {address} : Date {DateTime.Now} \r\n";
                            File.AppendAllText(pathdataIP, ipLogin);
                            CreateRecordAcc();
                            MessageBox.Show("Запись сохранена.");
                        }
                        else
                        {
                            CreateRecordWithoutIP();//если не хотим ждать или нет инета создаем запись без айпи
                        }
                    }
                    else
                        MessageBox.Show("Поля не могут быть пустыми");
                }
                else MessageBox.Show("Подождите загрузки IP адреса.");
            }
            else
            {   //иначе для чекнутой просто проверяем строки на пустоту и игнорируем айпи и кнопки.
                if (!string.IsNullOrEmpty(loginBox.Text) && !string.IsNullOrEmpty(passBox.Text) && !string.IsNullOrEmpty(numBox.Text)) // проверка на пустоту полей ввода 
                {
                    CreateRecordWithoutIP();
                }
                else
                {
                    MessageBox.Show("Поля не могут быть пустыми.");
                }
            }


        }
        /// <summary>
        /// Создание записи без IP
        /// </summary>
        private void CreateRecordWithoutIP()
        {
            //если айпи не спарсился, значит в боксе текст ошибки подключения, возможна простая запись. 
            File.AppendAllText(pathdataIP, "Create records from external device. \r\n");
            CreateRecordAcc();
            //в айпи заносится что произвелась запись с внешнего устройства. и сама запись
            MessageBox.Show("Запись сохранена без учета IP адреса.");
        }

        /// <summary>
        /// Событие очищения текстового файла с акками на кнопке btnClear.
        /// </summary>
        /// <param name="sender">Обьект события, то есть можешь сделать (Button)sender и обращаться к свойствам кнопки.Но это не нужно:)</param>
        /// <param name="e">Аргументы события</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Подтверждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (File.Exists(pathdata))
                    File.Delete(pathdata);// просто спрашиваем у юзера точно ли он хочет, а не случайно. да - удаляет файл с акком. если файла уже не существует - месс.бокс
                else
                    MessageBox.Show("Файла не существует или уже удален");
            }


        }
        /// <summary>
        ///  Событие очищения текстового файла с акками.
        /// </summary>
        private void btnSeeAcc_Click(object sender, EventArgs e) => new AccForm(pathdata).Show();//тут и сам поймешь:) передаем путь к аккаунтам в форму.


        /// <summary>
        /// Создание записи аккаунта в текстовый файл
        /// </summary>
        private void CreateRecordAcc()
        {
            var account = $"{loginBox.Text} : {passBox.Text} : {numBox.Text} \r\n";
            File.AppendAllText(pathdata, account);
        }

        /// <summary>
        /// Событие проверки айпи в списке существующих через кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnCheckIP_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                if (File.Exists(pathdataIP))
                {
                    var getAccsFromFile = File.ReadAllText(pathdataIP); //читаем все из файла по пути.
                    if (IPAddress.TryParse(ipBox.Text, out var address))
                        if (getAccsFromFile.Contains(address + ""))// проверяем есть ли ip  в списке. если да ищем последнюю дату записи.
                        {
                            var listLogger = getAccsFromFile.Split(new char[] { '\n' }).Where(x => x.Contains(address + "")).ToList();// опять же бьем на элементы каждую запись, которая содержит IP
                            DateTime lastlogin = default; // создаем дефолтное значения даты для сравнения. для каждого типа свой дефолт. для даты 01.01.0001
                            bool errors = false;// создаем переменную для отображения ошибки в случае повреждения файла.
                            foreach (var item in listLogger)// проходим по списку записей 
                            {
                                if (item.IndexOf("Date ") > 0)// проверка строки на повреждение, дата должна быть обязательно, если -1 значит есть повреждение, уведомляем юзера
                                {
                                    var letdate = item.Substring(item.IndexOf("Date ") + 5); // вырезаем дату с индекса Date , тк date с пробелом это 5 символов, прибавляем , нам нужна чистая дата

                                    if (lastlogin < DateTime.Parse(letdate))// проверяем если дата больше , вносим , нам нужна ближайшая дата регистрации
                                    {
                                        lastlogin = DateTime.Parse(letdate);
                                    }
                                }
                                else errors = true;

                            }
                            if (errors)
                                MessageBox.Show("Некоторые данные были некорректны. Во избежание ошибок, не изменяйте файлы в папке data.");

                            MessageBox.Show($"IP адрес существует. Последняя регистрация: {lastlogin}");
                        }
                        else
                        {
                            MessageBox.Show("IP адрес отсутствует.");
                        }
                    else MessageBox.Show("Подождите загрузки IP адреса или проверьте подключение к интернету.");
                }
                else
                {
                    MessageBox.Show("Регистраций не обнаружено.");
                }
                
            });
        }

        /// <summary>
        /// Событие обновления айпи адреса через кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ipBox.Text = "ожидание...";// пишем что происходит ожидание
            LoadIP();// кнопка обновления просто перезагружает IP
        }
    }
}
