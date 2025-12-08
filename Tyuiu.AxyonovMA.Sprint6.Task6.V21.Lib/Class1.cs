// Author: Аксёнов Максим
// Project: Tyuiu.AxyonovMA.Sprint6.Task6.V21.Lib
// Description: Поиск слов, содержащих букву 'g', в файле (Вариант 21)

using System;
using System.Collections.Generic;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AxyonovMA.Sprint6.Task6.V21.Lib
{
    public class DataService : ISprint6Task6V21
    {
        public string CollectTextFromFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Файл не найден", path);
            }

            string text = File.ReadAllText(path);

            // Разделители слов
            char[] separators =
            {
                ' ', '\t', '\r', '\n',
                ',', '.', ';', ':', '!', '?',
                '-', '—', '(', ')', '[', ']', '\"', '\'', '/'
            };

            string[] parts = text.Split(
                separators,
                StringSplitOptions.RemoveEmptyEntries);

            List<string> resultWords = new List<string>();

            foreach (string word in parts)
            {
                // слово содержит 'g' или 'G'
                if (word.IndexOf('g', StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    resultWords.Add(word);
                }
            }

            // результирующая строка для вывода в textBoxOut
            return string.Join(" ", resultWords);
        }
    }
}
