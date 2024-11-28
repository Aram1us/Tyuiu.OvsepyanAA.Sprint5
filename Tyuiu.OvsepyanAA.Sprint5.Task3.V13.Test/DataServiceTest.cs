using System.IO;

using Tyuiu.OvsepyanAA.Sprint5.Task3.V13.Lib;

namespace Tyuiu.OvsepyanAA.Sprint5.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\source\repos\Tyuiu.OvsepyanAA.Sprint5\Tyuiu.OvsepyanAA.Sprint5.Task3.V13\bin\Debug\net8.0\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}