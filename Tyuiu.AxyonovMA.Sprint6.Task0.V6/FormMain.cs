using System;
using System.Globalization;
using System.Windows.Forms;
using Tyuiu.AxyonovMA.Sprint6.Task0.V6.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.AxyonovMA.Sprint6.Task0.V6
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
            // по условию x = 3
            textBoxX.Text = "3";
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBoxX.Text);

                double y = ds.Calculate(x);

                textBoxResult.Text = y.ToString("F3", new CultureInfo("ru-RU"));
            }
            catch
            {
                MessageBox.Show("Введите корректное целое число X.",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
