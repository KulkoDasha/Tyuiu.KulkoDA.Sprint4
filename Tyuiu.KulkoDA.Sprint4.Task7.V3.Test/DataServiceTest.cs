using Tyuiu.KulkoDA.Sprint4.Task7.V3.Lib;
namespace Tyuiu.KulkoDA.Sprint4.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "27182818";
            var res = ds.Calculate(4,2,str);
            Assert.AreEqual(3,res);
        }
    }
}