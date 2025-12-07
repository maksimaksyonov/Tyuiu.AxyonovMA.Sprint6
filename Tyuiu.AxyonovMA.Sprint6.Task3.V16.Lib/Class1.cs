// Author: Аксёнов Максим
// Project: Tyuiu.AxyonovMA.Sprint6.Task3.V16.Lib
// Description: Замена чётных элементов 3-й строки матрицы на 0 (Вариант 16)

using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AxyonovMA.Sprint6.Task3.V16.Lib
{
    public class DataService : ISprint6Task3V16
    {
        // Предположим, что в интерфейсе так:
        // int[,] GetMatrix(int[,] matrix);

        public int[,] Calculate(int[,] matrix)
        {
            // Работаем с копией, чтобы не портить исходный массив, если это важно
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] result = new int[rows, cols];
            Array.Copy(matrix, result, matrix.Length);

            int targetRow = 2; // третья строка (индексация с 0)

            for (int j = 0; j < cols; j++)
            {
                if (result[targetRow, j] % 2 == 0)   // чётное число
                {
                    result[targetRow, j] = 0;
                }
            }

            return result;
        }
    }
}
