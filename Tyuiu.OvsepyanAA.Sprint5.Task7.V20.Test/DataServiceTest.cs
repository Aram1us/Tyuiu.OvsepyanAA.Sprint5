using Tyuiu.OvsepyanAA.Sprint5.Task7.V20.Lib;

namespace Tyuiu.OvsepyanAA.Sprint5.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new ();
            Assert.AreEqual("Словарные слова с удвоенной согласной нн", ds.LoadDataAndSave(Path.Combine("D:", "DataSprint5", "InPutDataFileTask7V20.txt")));
        }
    }
}