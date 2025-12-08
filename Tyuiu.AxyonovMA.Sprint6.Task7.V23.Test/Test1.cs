// Author: Аксёнов Максим
// Project: Tyuiu.AxyonovMA.Sprint6.Task7.V23.Test
// Description: Тесты для DataService (Вариант 23)

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AxyonovMA.Sprint6.Task7.V23.Lib;

namespace Tyuiu.AxyonovMA.Sprint6.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChangeLastColumn_ShouldReplaceValuesLessThanTwo()
        {
            // arrange
            DataService ds = new DataService();

            int[,] input =
            {
                { 1, 0 },
                { 5, 1 },
                { 7, 3 }
            };

            // act
            int[,] res = ds.ChangeLastColumn(input);

            // assert
            // первый и второй элементы последнего столбца были < 2 -> стали 2
            Assert.AreEqual(2, res[0, 1]);
            Assert.AreEqual(2, res[1, 1]);
            // третий элемент был 3 -> должен остаться 3
            Assert.AreEqual(3, res[2, 1]);

            // проверим, что остальные столбцы не изменились
            Assert.AreEqual(1, res[0, 0]);
            Assert.AreEqual(5, res[1, 0]);
            Assert.AreEqual(7, res[2, 0]);
        }

        [TestMethod]
        public void LoadAndSaveMatrix_ShouldBeConsistent()
        {
            // arrange
            DataService ds = new DataService();

            int[,] matrix =
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            string dir = Path.GetTempPath();
            string path = Path.Combine(dir, "Task7V23_Test.csv");

            // act: сохраняем и читаем обратно
            ds.SaveToDataFile(path, matrix);
            int[,] loaded = ds.GetMatrix(path);

            // assert: размеры те же
            Assert.AreEqual(matrix.GetLength(0), loaded.GetLength(0));
            Assert.AreEqual(matrix.GetLength(1), loaded.GetLength(1));

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Assert.AreEqual(matrix[i, j], loaded[i, j],
                        $"Элемент [{i},{j}] отличается");
                }
            }
        }
    }
}
