using System.IO;

using Tyuiu.OvsepyanAA.Sprint5.Task0.V26.Lib;

namespace Tyuiu.OvsepyanAA.Sprint5.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\source\repos\Tyuiu.OvsepyanAA.Sprint5\Tyuiu.OvsepyanAA.Sprint5.Task0.V26\bin\Debug\net8.0\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
