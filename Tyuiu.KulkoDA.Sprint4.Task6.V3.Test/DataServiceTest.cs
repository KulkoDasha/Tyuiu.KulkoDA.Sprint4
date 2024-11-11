using Tyuiu.KulkoDA.Sprint4.Task6.V3.Lib;
namespace Tyuiu.KulkoDA.Sprint4.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var mas = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь" };
            var res = ds.Calculate(mas);
            Assert.AreEqual(3, res);
        }
    }
};