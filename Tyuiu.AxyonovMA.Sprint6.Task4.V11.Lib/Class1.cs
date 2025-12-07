// Author: Аксёнов Максим
// Project: Tyuiu.AxyonovMA.Sprint6.Task4.V11.Lib
// Description: Табулирование функции (Вариант 11)

using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AxyonovMA.Sprint6.Task4.V11.Lib
{
    public class DataService : ISprint6Task4V11
    {
        // Табулирование функции на отрезке [startValue; stopValue] с шагом 1
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] y = new double[len];

            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denom = 2 - 2 * x;
                double value;

                if (denom == 0)
                {
                    // деление на ноль — по условию вернуть 0
                    value = 0;
                }
                else
                {
                    value = Math.Cos(x) + Math.Sin(x) / denom - 4 * x;
                }

                y[index] = Math.Round(value, 2);
                index++;
            }

            return y;
        }

        // Сохранить таблицу значений в текстовый файл, вернуть путь к файлу
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            double[] y = GetMassFunction(startValue, stopValue);

            string dir = Path.GetTempPath();
            string path = Path.Combine(dir, "OutPutFileTask4V11.txt");

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < y.Length; i++)
            {
                sb.AppendLine(y[i].ToString());
            }

            File.WriteAllText(path, sb.ToString(), Encoding.UTF8);

            return path;
        }
    }
}
