// Author: Аксёнов Максим
// Project: Tyuiu.AxyonovMA.Sprint6.Task7.V23.Lib
// Description: Работа с матрицей целых чисел из CSV (Вариант 23)

using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AxyonovMA.Sprint6.Task7.V23.Lib
{
    public class DataService : ISprint6Task7V23
    {
        // ====== МЕТОД ИНТЕРФЕЙСА, КОТОРЫЙ ВЫЗЫВАЕТ ОНЛАЙН-ТЕСТ ======
        public int[,] GetMatrix(string path)
        {
            // 1. загружаем исходную матрицу из файла
            int[,] matrix = LoadFromDataFile(path);

            // 2. изменяем последний столбец по условию
            int[,] changed = ChangeLastColumn(matrix);

            // 3. возвращаем уже изменённую матрицу
            return changed;
        }

        // ====== ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ ======

        /// <summary>
        /// Загружает целочисленную матрицу из CSV-файла.
        /// Разделитель элементов в строке – ';'.
        /// </summary>
        public int[,] LoadFromDataFile(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException("Путь к файлу не задан", nameof(path));

            string[] lines = File.ReadAllLines(path);

            if (lines.Length == 0)
                throw new InvalidOperationException("Файл не содержит данных");

            string[] firstRow = lines[0].Split(';', StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int cols = firstRow.Length;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] parts = lines[i]
                    .Split(';', StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length != cols)
                    throw new InvalidOperationException("Строки файла имеют разное количество столбцов");

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(parts[j]);
                }
            }

            return matrix;
        }

        /// <summary>
        /// В последнем столбце матрицы все элементы &lt; 2 заменяет на 2.
        /// Возвращает новую матрицу (исходную не изменяет).
        /// </summary>
        public int[,] ChangeLastColumn(int[,] source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            int rows = source.GetLength(0);
            int cols = source.GetLength(1);

            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int value = source[i, j];

                    if (j == cols - 1 && value < 2)
                    {
                        value = 2;
                    }

                    result[i, j] = value;
                }
            }

            return result;
        }

        /// <summary>
        /// Сохраняет матрицу в CSV-файл (разделитель ';').
        /// </summary>
        public void SaveToDataFile(string path, int[,] matrix)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException("Путь к файлу не задан", nameof(path));
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            string[] lines = new string[rows];

            for (int i = 0; i < rows; i++)
            {
                string[] parts = new string[cols];
                for (int j = 0; j < cols; j++)
                {
                    parts[j] = matrix[i, j].ToString();
                }

                lines[i] = string.Join(";", parts);
            }

            File.WriteAllLines(path, lines);
        }
    }
}
