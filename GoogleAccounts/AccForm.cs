using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var getAccsFromFile = File.ReadAllText(pathdata); //читаем все из файла по переданному пути.
            var arrayAccs = getAccsFromFile.Split(new char[] {'\n' }).ToList();//разбиваем текст из файла на массив строк и делим их по спец символам переноса строки \n потому что последний 
            //и приводим к списку, потому что в массиве удалить элемент нельзя.
            arrayAccs.Remove(arrayAccs[arrayAccs.Count()-1]);// удаляем последний элемент из списка. потому что он пустой.
            listAcc.DataSource = arrayAccs;//заполняем контрол списком. дата сорсе может принимать списки листы и тд.
        }
    }
}
