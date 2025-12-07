// Author: Аксёнов Максим
// Project: Tyuiu.AxyonovMA.Sprint6.Task4.V11.Test
// Description: Тест табулирования и записи в файл (Вариант 11)

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AxyonovMA.Sprint6.Task4.V11.Lib;

namespace Tyuiu.AxyonovMA.Sprint6.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValueAtX0()
        {
            DataService ds = new DataService();

            int start = -5;
            int stop = 5;
            double[] y = ds.GetMassFunction(start, stop);

            // x = 0 -> индекс 0 - (-5) = 5
            double actual = y[5];

            // F(0) = cos(0) + sin(0)/(2-0) - 0 = 1
            double expected = 1.00;

            Assert.AreEqual(expected, actual, 1e-2);
        }

        [TestMethod]
        public void CheckFileCreated()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(-5, 5);

            Assert.IsTrue(File.Exists(path), "Файл не был создан методом SaveToFileTextData.");
        }
    }
}
