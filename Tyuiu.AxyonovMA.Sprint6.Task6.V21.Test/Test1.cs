// Author: Аксёнов Максим
// Project: Tyuiu.AxyonovMA.Sprint6.Task6.V21.Test
// Description: Тест метода CollectTextFromFile (Вариант 21)

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AxyonovMA.Sprint6.Task6.V21.Lib;

namespace Tyuiu.AxyonovMA.Sprint6.Task6.V21.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void CheckCollectTextFromFile()
        {
            // arrange: создаём временный файл
            string dir = Path.GetTempPath();
            string path = Path.Combine(dir, "InPutFileTask6V21_Test.txt");
            File.WriteAllText(path, "good day great GAME test");

            DataService ds = new DataService();

            // act
            string actual = ds.CollectTextFromFile(path);

            // ожидаем, что будут только слова с буквой g/G
            string expected = "good great GAME";

            // assert: сравниваем строки, а не коллекции
            Assert.AreEqual(expected, actual);
        }
    }
}
