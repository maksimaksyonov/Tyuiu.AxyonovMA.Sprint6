// Author: Аксёнов Максим
// Project: Tyuiu.AxyonovMA.Sprint6.Task1.V13.Test
// Description: Тест метода GetMassFunction (Вариант 13)

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint6.Task1.V13.Lib;

namespace Tyuiu.AxyonovMA.Sprint6.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValueAtX1()
        {
            DataService ds = new DataService();

            int start = -5;
            int stop = 5;

            double[] y = ds.GetMassFunction(start, stop);

            // индекс для x = 1: 1 - (-5) = 6
            double actual = y[6];

            // вручную посчитанное значение:
            // F(1) ≈ -5.6954 -> -5.70 после округления до 2 знаков
            double expected = -5.70;

            Assert.AreEqual(expected, actual, 1e-2);
        }
    }
}
