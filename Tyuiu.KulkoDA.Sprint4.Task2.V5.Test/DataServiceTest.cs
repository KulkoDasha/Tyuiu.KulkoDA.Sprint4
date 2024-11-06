using Tyuiu.KulkoDA.Sprint4.Task2.V5.Lib;
namespace Tyuiu.KulkoDA.Sprint4.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] m = new int[] { 5, 3, 3, 4, 4 };
            var res = ds.Calculate(m);
            Assert.AreEqual(16, res);
        }
    }
}