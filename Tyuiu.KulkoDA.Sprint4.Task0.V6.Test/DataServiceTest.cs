using Tyuiu.KulkoDA.Sprint4.Task0.V6.Lib;
namespace Tyuiu.KulkoDA.Sprint4.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] mass = { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 };
            int res = ds.GetSumOddArrEl(mass);
            Assert.AreEqual(32, res);
        }
    }
}