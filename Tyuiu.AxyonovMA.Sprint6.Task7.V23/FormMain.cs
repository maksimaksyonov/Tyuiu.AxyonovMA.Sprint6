// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint6.Task7.V23
// Description: Загрузка матрицы из CSV, изменение последнего столбца и сохранение результата

using System;
using System.Windows.Forms;
using Tyuiu.AxyonovMA.Sprint6.Task7.V23.Lib;

namespace Tyuiu.AxyonovMA.Sprint6.Task7.V23
{
    public partial class FormMain : Form
    {
        private readonly DataService ds = new DataService();

        // здесь будем хранить изменённую матрицу для сохранения в файл
        private int[,] matrixResult;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Открыть файл матрицы";
                ofd.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        textBoxPathIn.Text = ofd.FileName;

                        // 1. загружаем исходную матрицу
                        int[,] matrixIn = ds.GetMatrix(ofd.FileName);

                        // 2. показываем исходную матрицу
                        FillGrid(matrixIn, dataGridViewIn);

                        // 3. считаем изменённую матрицу
                        matrixResult = ds.ChangeLastColumn(matrixIn);

                        // 4. показываем результат
                        FillGrid(matrixResult, dataGridViewOut);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при чтении файла:\n" + ex.Message,
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (matrixResult == null)
            {
                MessageBox.Show("Сначала загрузите файл и получите результат.",
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Сохранить результат";
                sfd.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
                sfd.FileName = "OutPutFileTask7V23.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ds.SaveToDataFile(sfd.FileName, matrixResult);
                        textBoxPathOut.Text = sfd.FileName;
                        MessageBox.Show("Файл успешно сохранён.", "Готово",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при сохранении файла:\n" + ex.Message,
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Заполняет DataGridView данными из целочисленной матрицы.
        /// </summary>
        private void FillGrid(int[,] matrix, DataGridView grid)
        {
            grid.Columns.Clear();
            grid.Rows.Clear();

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int j = 0; j < cols; j++)
            {
                grid.Columns.Add($"col{j}", $"[{j}]");
            }

            for (int i = 0; i < rows; i++)
            {
                object[] row = new object[cols];
                for (int j = 0; j < cols; j++)
                {
                    row[j] = matrix[i, j];
                }

                grid.Rows.Add(row);
            }

            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
