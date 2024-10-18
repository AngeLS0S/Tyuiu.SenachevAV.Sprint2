using Tyuiu.SenachevAV.Sprint2.Task1.V6;
using Tyuiu.SenachevAV.Sprint2.Task1.V6.Lib;

namespace Tyuiu.SenachevAV.Sprint2.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 915, b = 169, c = 174, d = 133;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { false, false, true, false, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}