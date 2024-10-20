using Tyuiu.SenachevAV.Sprint2.Task2.V7;
using Tyuiu.SenachevAV.Sprint2.Task2.V7.Lib;

namespace Tyuiu.SenachevAV.Sprint2.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 6;
            int y = 7;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}