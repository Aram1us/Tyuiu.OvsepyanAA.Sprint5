using System.IO;
using Tyuiu.OvsepyanAA.Sprint5.Task1.V17.Lib;
namespace Tyuiu.OvsepyanAA.Sprint5.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\source\repos\Tyuiu.OvsepyanAA.Sprint5\Tyuiu.OvsepyanAA.Sprint5.Task1.V17\bin\Debug\net8.0\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}