using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GoogleAccounts
{
    public partial class AccForm : Form
    {
        public AccForm(string pathdata)// ожидаем что сюда передадут строку с путем
        {
            InitializeComponent();
            LoadList(pathdata);// передаем полученный путь дальше в метод. лучше все выносить в отдельные методы.
        }
        void LoadList(string pathdata)
        {
            if (File.Exists(pathdata))
            {
                var getAccsFromFile = File.ReadAllText(pathdata); //читаем все из файла по переданному пути.
                var arrayAccs = getAccsFromFile.Split(new char[] { '\n' }).ToList();//разбиваем текст из файла на массив строк и делим их по спец символам переноса строки \n потому что последний 
                //и приводим к списку, потому что в массиве удалить элемент нельзя.
                arrayAccs.Remove(arrayAccs[arrayAccs.Count() - 1]);// удаляем последний элемент из списка. потому что он пусtтой.
                listAcc.DataSource = arrayAccs;//заполняем контрол списком. дата сорсе может принимать списки листы и тд.
            }
            else
            {
                MessageBox.Show("Файл отсутствует, список пуст.");
            }

        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e) => Clipboard
            .SetText(listAcc.SelectedItem == null ? @"¯\_(ツ)_/¯" : listAcc.SelectedItem.ToString()); // кнопка в контекстном меню акков 
        // для копирования выделенной записи в буфер обмена.
    }
}
