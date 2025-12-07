// Author: Аксёнов Максим
// Project: Tyuiu.AxyonovMA.Sprint6.Task5.V15.Lib
// Description: Чтение чисел из файла и выборка значений в диапазоне [2;7] (Вариант 15)

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AxyonovMA.Sprint6.Task5.V15.Lib
{
    public class DataService : ISprint6Task5V15
    {
        // Читаем файл, выбираем числа от 2 до 7 включительно, округляем до 3 знаков
        public double[] LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Файл не найден", path);
            }

            string text = File.ReadAllText(path);

            // Разделители: пробел, таб, перевод строки, запятая, точка с запятой
            char[] separators = { ' ', '\t', '\r', '\n', ';', ',' };

            string[] parts = text.Split(separators,
                StringSplitOptions.RemoveEmptyEntries);

            List<double> result = new List<double>();

            foreach (string raw in parts)
            {
                // заменяем запятую на точку, чтобы корректно парсить обе записи
                string s = raw.Replace(',', '.');

                if (double.TryParse(s, NumberStyles.Any,
                        CultureInfo.InvariantCulture, out double value))
                {
                    if (value >= 2.0 && value <= 7.0)
                    {
                        result.Add(Math.Round(value, 3));
                    }
                }
            }

            return result.ToArray();
        }
    }
}
