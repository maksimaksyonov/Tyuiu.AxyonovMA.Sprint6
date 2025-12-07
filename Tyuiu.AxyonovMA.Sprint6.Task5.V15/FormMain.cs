// Author: Аксёнов Максим
// Project: Tyuiu.AxyonovMA.Sprint6.Task5.V15
// Description: Чтение данных из файла, вывод в DataGridView и рисование диаграммы (Вариант 15)

using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.AxyonovMA.Sprint6.Task5.V15.Lib;

namespace Tyuiu.AxyonovMA.Sprint6.Task5.V15
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
            dataGridViewValues.ColumnCount = 1;
            dataGridViewValues.Columns[0].HeaderText = "Значение";
            dataGridViewValues.AllowUserToAddRows = false;
            dataGridViewValues.RowHeadersVisible = false;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(
                    Directory.GetCurrentDirectory(),
                    "InPutFileTask5V15.txt");

                double[] values = ds.LoadFromDataFile(path);

                // вывод в DataGridView
                dataGridViewValues.Rows.Clear();
                foreach (double v in values)
                {
                    dataGridViewValues.Rows.Add(v.ToString("F3"));
                }

                // построение простой столбчатой диаграммы в PictureBox
                DrawChart(values);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrawChart(double[] data)
        {
            if (pictureBoxChart.Width <= 0 || pictureBoxChart.Height <= 0)
                return;

            Bitmap bmp = new Bitmap(pictureBoxChart.Width, pictureBoxChart.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                if (data == null || data.Length == 0)
                {
                    pictureBoxChart.Image = bmp;
                    return;
                }

                double max = data.Max();
                if (max <= 0) max = 1;

                int n = data.Length;
                int margin = 10;
                int plotWidth = bmp.Width - 2 * margin;
                int plotHeight = bmp.Height - 2 * margin;
                int barWidth = Math.Max(5, plotWidth / n);

                for (int i = 0; i < n; i++)
                {
                    double v = data[i];
                    int barHeight = (int)(plotHeight * (v / max));

                    int x = margin + i * barWidth;
                    int y = margin + (plotHeight - barHeight);

                    g.FillRectangle(Brushes.LightBlue, x, y, barWidth - 2, barHeight);
                    g.DrawRectangle(Pens.Black, x, y, barWidth - 2, barHeight);
                }

                // простые оси
                g.DrawLine(Pens.Black, margin, margin, margin, margin + plotHeight);
                g.DrawLine(Pens.Black, margin, margin + plotHeight,
                    margin + plotWidth, margin + plotHeight);
            }

            pictureBoxChart.Image = bmp;
        }
    }
}
