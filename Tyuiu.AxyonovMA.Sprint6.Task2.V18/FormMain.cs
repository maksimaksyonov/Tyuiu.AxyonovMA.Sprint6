// Author: Аксёнов Максим
// Project: Tyuiu.AxyonovMA.Sprint6.Task2.V18
// Description: Табулирование функции и вывод в DataGridView (Вариант 18)

using System;
using System.Globalization;
using System.Windows.Forms;
using Tyuiu.AxyonovMA.Sprint6.Task2.V18.Lib;

namespace Tyuiu.AxyonovMA.Sprint6.Task2.V18
{
    public partial class FormMain : Form
    {
        private readonly DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            textBoxStart.Text = "-5";
            textBoxStop.Text = "5";

            // Подготовка DataGridView
            dataGridViewFunc.ColumnCount = 2;
            dataGridViewFunc.Columns[0].HeaderText = "x";
            dataGridViewFunc.Columns[1].HeaderText = "F(x)";
            dataGridViewFunc.AllowUserToAddRows = false;
            dataGridViewFunc.RowHeadersVisible = false;
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart.Text);
                int stop = Convert.ToInt32(textBoxStop.Text);

                double[] y = ds.GetMassFunction(start, stop);

                dataGridViewFunc.Rows.Clear();

                int index = 0;
                for (int x = start; x <= stop; x++)
                {
                    dataGridViewFunc.Rows.Add(
                        x.ToString(),
                        y[index].ToString("F2", new CultureInfo("ru-RU")));
                    index++;
                }
            }
            catch
            {
                MessageBox.Show("Введите корректные целые значения начала и конца диапазона.",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
