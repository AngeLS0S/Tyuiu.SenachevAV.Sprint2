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

            Assert.AreEqual("������� ���", ds.FindCardNameAndValue(6, 1));
            Assert.AreEqual("������� ����", ds.FindCardNameAndValue(6, 2));
            Assert.AreEqual("������� �����", ds.FindCardNameAndValue(6, 3));
            Assert.AreEqual("������� ������", ds.FindCardNameAndValue(6, 4));

            Assert.AreEqual("������ ���", ds.FindCardNameAndValue(7, 1));
            Assert.AreEqual("������ ����", ds.FindCardNameAndValue(7, 2));
            Assert.AreEqual("������ �����", ds.FindCardNameAndValue(7, 3));
            Assert.AreEqual("������ ������", ds.FindCardNameAndValue(7, 4));

            Assert.AreEqual("�������� ���", ds.FindCardNameAndValue(8, 1));
            Assert.AreEqual("�������� ����", ds.FindCardNameAndValue(8, 2));
            Assert.AreEqual("�������� �����", ds.FindCardNameAndValue(8, 3));
            Assert.AreEqual("�������� ������", ds.FindCardNameAndValue(8, 4));

            Assert.AreEqual("������� ���", ds.FindCardNameAndValue(9, 1));
            Assert.AreEqual("������� ����", ds.FindCardNameAndValue(9, 2));
            Assert.AreEqual("������� �����", ds.FindCardNameAndValue(9, 3));
            Assert.AreEqual("������� ������", ds.FindCardNameAndValue(9, 4));

            Assert.AreEqual("������� ���", ds.FindCardNameAndValue(10, 1));
            Assert.AreEqual("������� ����", ds.FindCardNameAndValue(10, 2));
            Assert.AreEqual("������� �����", ds.FindCardNameAndValue(10, 3));
            Assert.AreEqual("������� ������", ds.FindCardNameAndValue(10, 4));

            Assert.AreEqual("����� ���", ds.FindCardNameAndValue(11, 1));
            Assert.AreEqual("����� ����", ds.FindCardNameAndValue(11, 2));
            Assert.AreEqual("����� �����", ds.FindCardNameAndValue(11, 3));
            Assert.AreEqual("����� ������", ds.FindCardNameAndValue(11, 4));

            Assert.AreEqual("���� ���", ds.FindCardNameAndValue(12, 1));
            Assert.AreEqual("���� ����", ds.FindCardNameAndValue(12, 2));
            Assert.AreEqual("���� �����", ds.FindCardNameAndValue(12, 3));
            Assert.AreEqual("���� ������", ds.FindCardNameAndValue(12, 4));

            Assert.AreEqual("������ ���", ds.FindCardNameAndValue(13, 1));
            Assert.AreEqual("������ ����", ds.FindCardNameAndValue(13, 2));
            Assert.AreEqual("������ �����", ds.FindCardNameAndValue(13, 3));
            Assert.AreEqual("������ ������", ds.FindCardNameAndValue(13, 4));

            Assert.AreEqual("��� ���", ds.FindCardNameAndValue(14, 1));
            Assert.AreEqual("��� ����", ds.FindCardNameAndValue(14, 2));
            Assert.AreEqual("��� �����", ds.FindCardNameAndValue(14, 3));
            Assert.AreEqual("��� ������", ds.FindCardNameAndValue(14, 4));


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