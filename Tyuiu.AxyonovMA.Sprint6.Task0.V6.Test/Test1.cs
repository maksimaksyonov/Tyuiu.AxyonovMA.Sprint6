// Author: Аксёнов Максим
// Project: Tyuiu.AxyonovMA.Sprint6.Task0.V6.Test
// Description: Тест метода Calculate (Вариант 6)

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint6.Task0.V6.Lib;

namespace Tyuiu.AxyonovMA.Sprint6.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_X3_ReturnsExpected()
        {
            DataService ds = new DataService();

            double actual = ds.Calculate(3);

            // y = 3 / sqrt(9 + 3) = 3 / sqrt(12) ≈ 0.866
            double expected = 0.866;

            Assert.AreEqual(expected, actual, 1e-3);
        }
    }
}
