using System.IO;

using Tyuiu.OvsepyanAA.Sprint5.Task4.V8.Lib;

namespace Tyuiu.OvsepyanAA.Sprint5.Task4.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @":D\DataSprint5\InPutDataFileTask4V8.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false;

            Assert.AreEqual(wait, fileExists);

        }
    }
}