// Author: Аксёнов Максим
// Project: Tyuiu.AxyonovMA.Sprint6.Task6.V21
// Description: Загрузка текста из файла и вывод слов с буквой 'g' (Вариант 21)

using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.AxyonovMA.Sprint6.Task6.V21.Lib;

namespace Tyuiu.AxyonovMA.Sprint6.Task6.V21
{
    public partial class FormMain : Form
    {
        private readonly DataService ds = new DataService();
        private string currentFilePath = string.Empty;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Выбор файла InPutFileTask6V21.txt";
                ofd.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = ofd.FileName;

                    string text = File.ReadAllText(currentFilePath);
                    textBoxIn.Text = text;
                    textBoxOut.Clear();
                }
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(currentFilePath) ||
                !File.Exists(currentFilePath))
            {
                MessageBox.Show("Сначала выберите файл через кнопку \"Открыть файл\".",
                    "Файл не выбран", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Используем метод CollectTextFromFile вместо LoadFromDataFile
            string result = ds.CollectTextFromFile(currentFilePath);
            textBoxOut.Text = result;
        }
    }
}
