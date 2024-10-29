using Tyuiu.SenachevAV.Sprint2.Task5.V6.Lib;

namespace Tyuiu.SenachevAV.Sprint2.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardNameAndValue()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Шестёрка пик", ds.FindCardNameAndValue(6, 1));
            Assert.AreEqual("Шестёрка треф", ds.FindCardNameAndValue(6, 2));
            Assert.AreEqual("Шестёрка бубен", ds.FindCardNameAndValue(6, 3));
            Assert.AreEqual("Шестёрка червей", ds.FindCardNameAndValue(6, 4));

            Assert.AreEqual("Семёрка пик", ds.FindCardNameAndValue(7, 1));
            Assert.AreEqual("Семёрка треф", ds.FindCardNameAndValue(7, 2));
            Assert.AreEqual("Семёрка бубен", ds.FindCardNameAndValue(7, 3));
            Assert.AreEqual("Семёрка червей", ds.FindCardNameAndValue(7, 4));

            Assert.AreEqual("Восьмёрка пик", ds.FindCardNameAndValue(8, 1));
            Assert.AreEqual("Восьмёрка треф", ds.FindCardNameAndValue(8, 2));
            Assert.AreEqual("Восьмёрка бубен", ds.FindCardNameAndValue(8, 3));
            Assert.AreEqual("Восьмёрка червей", ds.FindCardNameAndValue(8, 4));

            Assert.AreEqual("Девятка пик", ds.FindCardNameAndValue(9, 1));
            Assert.AreEqual("Девятка треф", ds.FindCardNameAndValue(9, 2));
            Assert.AreEqual("Девятка бубен", ds.FindCardNameAndValue(9, 3));
            Assert.AreEqual("Девятка червей", ds.FindCardNameAndValue(9, 4));

            Assert.AreEqual("Десятка пик", ds.FindCardNameAndValue(10, 1));
            Assert.AreEqual("Десятка треф", ds.FindCardNameAndValue(10, 2));
            Assert.AreEqual("Десятка бубен", ds.FindCardNameAndValue(10, 3));
            Assert.AreEqual("Десятка червей", ds.FindCardNameAndValue(10, 4));

            Assert.AreEqual("Валет пик", ds.FindCardNameAndValue(11, 1));
            Assert.AreEqual("Валет треф", ds.FindCardNameAndValue(11, 2));
            Assert.AreEqual("Валет бубен", ds.FindCardNameAndValue(11, 3));
            Assert.AreEqual("Валет червей", ds.FindCardNameAndValue(11, 4));

            Assert.AreEqual("Дама пик", ds.FindCardNameAndValue(12, 1));
            Assert.AreEqual("Дама треф", ds.FindCardNameAndValue(12, 2));
            Assert.AreEqual("Дама бубен", ds.FindCardNameAndValue(12, 3));
            Assert.AreEqual("Дама червей", ds.FindCardNameAndValue(12, 4));

            Assert.AreEqual("Король пик", ds.FindCardNameAndValue(13, 1));
            Assert.AreEqual("Король треф", ds.FindCardNameAndValue(13, 2));
            Assert.AreEqual("Король бубен", ds.FindCardNameAndValue(13, 3));
            Assert.AreEqual("Король червей", ds.FindCardNameAndValue(13, 4));

            Assert.AreEqual("Туз пик", ds.FindCardNameAndValue(14, 1));
            Assert.AreEqual("Туз треф", ds.FindCardNameAndValue(14, 2));
            Assert.AreEqual("Туз бубен", ds.FindCardNameAndValue(14, 3));
            Assert.AreEqual("Туз червей", ds.FindCardNameAndValue(14, 4));


            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(5, 1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(15, 1);
            });
        }
    }
}