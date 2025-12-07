// Author: Аксёнов Максим
// Project: Tyuiu.AxyonovMA.Sprint6.Task5.V15.Test
// Description: Тест метода LoadFromDataFile (Вариант 15)

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AxyonovMA.Sprint6.Task5.V15.Lib;

namespace Tyuiu.AxyonovMA.Sprint6.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_FilterAndRound()
        {
            // arrange: создаём временный файл с данными
            string dir = Path.GetTempPath();
            string path = Path.Combine(dir, "InPutFileTask5V15_Test.txt");

            // числа: 1.234, 2.345, 7.0, 8.9, 3.333 -> берём те, что в [2;7]
            File.WriteAllText(path, "1.234 2.345 7 8.9 3.333");

            DataService ds = new DataService();

            // act
            double[] res = ds.LoadFromDataFile(path);

            // assert
            double[] expected = { 2.345, 7.0, 3.333 };

            Assert.AreEqual(expected.Length, res.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], res[i], 1e-3,
                    $"Элемент {i} отличается от ожидаемого.");
            }
        }
    }
}
