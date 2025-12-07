// Author: Аксёнов Максим
// Project: Tyuiu.AxyonovMA.Sprint6.Task1.V13
// Description: Табулирование функции и вывод в TextBox (Вариант 13)

using System;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Tyuiu.AxyonovMA.Sprint6.Task1.V13.Lib;

namespace Tyuiu.AxyonovMA.Sprint6.Task1.V13
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
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart.Text);
                int stop = Convert.ToInt32(textBoxStop.Text);

                double[] y = ds.GetMassFunction(start, stop);

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("   x\t   F(x)");

                int index = 0;
                for (int x = start; x <= stop; x++)
                {
                    sb.AppendLine($"{x}\t{y[index].ToString("F2", new CultureInfo("ru-RU"))}");
                    index++;
                }

                textBoxResult.Text = sb.ToString();
            }
            catch
            {
                MessageBox.Show("Введите корректные целые значения начала и конца диапазона.",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
