// Author: Аксёнов Максим
// Project: Tyuiu.AxyonovMA.Sprint6.Task3.V16
// Description: Работа с матрицей и вывод в DataGridView (Вариант 16)

using System;
using System.Windows.Forms;
using Tyuiu.AxyonovMA.Sprint6.Task3.V16.Lib;

namespace Tyuiu.AxyonovMA.Sprint6.Task3.V16
{
    public partial class FormMain : Form
    {
        private readonly DataService ds = new DataService();

        // исходная матрица 5x5
        private int[,] matrix =
        {
            { 14,   1,  -3,   1,  10 },
            {  7,  -3,   5,  -4,   0 },
            { -10, -19, -18,  -9,  19 },
            { -2,  -2, -16,   2, -17 },
            { -16,  9,   5, -10,  16 }
        };

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Настройка DataGridView
            dataGridViewMatrix.ColumnCount = 5;
            dataGridViewMatrix.RowCount = 5;
            dataGridViewMatrix.AllowUserToAddRows = false;
            dataGridViewMatrix.RowHeadersVisible = false;

            ShowMatrix(matrix);
        }

        private void ShowMatrix(int[,] m)
        {
            int rows = m.GetLength(0);
            int cols = m.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewMatrix[j, i].Value = m[i, j];
                }
            }
        }

        private void buttonDo_Click(object sender, EventArgs e)
        {
            int[,] result = ds.Calculate(matrix);
            ShowMatrix(result);
        }
    }
}
