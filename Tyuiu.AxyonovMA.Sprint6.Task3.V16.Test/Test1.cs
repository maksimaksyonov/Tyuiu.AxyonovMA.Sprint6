// Author: Аксёнов Максим
// Project: Tyuiu.AxyonovMA.Sprint6.Task3.V16.Test
// Description: Тест замены чётных значений в 3-й строке (Вариант 16)

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint6.Task3.V16.Lib;

namespace Tyuiu.AxyonovMA.Sprint6.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckReplaceEvenInThirdRow()
        {
            DataService ds = new DataService();

            int[,] m =
            {
                { 14,   1,  -3,   1,  10 },
                {  7,  -3,   5,  -4,   0 },
                { -10, -19, -18,  -9,  19 },
                { -2,  -2, -16,   2, -17 },
                { -16,  9,   5, -10,  16 }
            };

            int[,] res = ds.Calculate(m);

            // третья строка после замены: 0, -19, 0, -9, 19
            Assert.AreEqual(0, res[2, 0]);
            Assert.AreEqual(-19, res[2, 1]);
            Assert.AreEqual(0, res[2, 2]);
            Assert.AreEqual(-9, res[2, 3]);
            Assert.AreEqual(19, res[2, 4]);
        }
    }
}
