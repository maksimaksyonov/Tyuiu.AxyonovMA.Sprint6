using System;
using System.Globalization;
using System.Windows.Forms;
using Tyuiu.AxyonovMA.Sprint6.Task4.V11.Lib;

namespace Tyuiu.AxyonovMA.Sprint6.Task4.V11
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
            // ничего особенного не нужно
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int start = -5;
            int stop = 5;

            double[] y = ds.GetMassFunction(start, stop);

            textBoxResult.Clear();
            textBoxResult.AppendText("   x\t   F(x)\r\n");

            int index = 0;
            for (int x = start; x <= stop; x++)
            {
                double fx = y[index];
                textBoxResult.AppendText(
                    $"{x}\t{fx.ToString("F2", new CultureInfo("ru-RU"))}\r\n");
                index++;
            }

            string path = ds.SaveToFileTextData(start, stop);
            MessageBox.Show($"Данные сохранены в файл:\n{path}",
                "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
