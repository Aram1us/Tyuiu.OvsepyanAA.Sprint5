using Tyuiu.OvsepyanAA.Sprint5.Task5.V10.Lib;

namespace Tyuiu.OvsepyanAA.Sprint5.Task5.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\DataSprint5\InPutDataFileTask5V10.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}