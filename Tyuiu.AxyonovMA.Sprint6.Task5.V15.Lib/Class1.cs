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
        public double[] LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Файл не найден", path);
            }

            string text = File.ReadAllText(path);

            // ВАЖНО: запятую из разделителей убрали!
            char[] separators = { ' ', '\t', '\r', '\n', ';' };

            string[] parts = text.Split(separators,
                StringSplitOptions.RemoveEmptyEntries);

            List<double> result = new List<double>();

            foreach (string raw in parts)
            {
                // поддерживаем формат с запятой и с точкой
                string s = raw.Replace(',', '.');

                if (double.TryParse(s, NumberStyles.Any,
                        CultureInfo.InvariantCulture, out double value))
                {
                    if (value >= 2.0 && value <= 7.0)
                    {
                        // по факту ожидают округление до 2 знаков
                        result.Add(Math.Round(value, 2));
                    }
                }
            }

            return result.ToArray();
        }
    }
}
