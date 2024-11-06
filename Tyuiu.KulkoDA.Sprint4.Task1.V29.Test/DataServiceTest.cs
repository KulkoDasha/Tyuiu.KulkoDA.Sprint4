using Tyuiu.KulkoDA.Sprint4.Task1.V29.Lib;
namespace Tyuiu.KulkoDA.Sprint4.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] m = new int[] { 5, 3, 3, 4, 1, 3, 3, 5, 6, 2, 7, 2, 1, 8 };
            var res = ds.Calculate(m);
            Assert.AreEqual(31, res);
        }
    }
}