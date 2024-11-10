using Tyuiu.KulkoDA.Sprint4.Task5.V15.Lib;
namespace Tyuiu.KulkoDA.Sprint4.Task5.V15.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mass = { { 1, 2, -3 }, { 1, -4, -4 } };
            var res = ds.Calculate(mass);
            Assert.AreEqual(4, res);
        }
    }
}