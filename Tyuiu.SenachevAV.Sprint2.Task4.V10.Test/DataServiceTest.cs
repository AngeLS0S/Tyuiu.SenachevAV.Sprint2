using Tyuiu.SenachevAV.Sprint2.Task4.V10;
using Tyuiu.SenachevAV.Sprint2.Task4.V10.Lib;

namespace Tyuiu.SenachevAV.Sprint2.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {

            DataService ds = new DataService();

            double x = 7;
            double y = 5;

            double res = ds.Calculate(x, y);
            double wait = 74.286;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalculate2()
        {

            DataService ds = new DataService();

            double x = 7;
            double y = 10;

            double res = ds.Calculate(x, y);
            double wait = 79.286;
            Assert.AreEqual(wait, res);
        }
    }
}