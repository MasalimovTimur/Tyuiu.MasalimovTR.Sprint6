using Tyuiu.MasalimovTR.Sprint6.Task0.V6.Lib;
namespace TestProject1

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 3;
            DataService ds = new DataService();
            double res = ds.Calculate(x);
            Assert.AreEqual(0.866, res);
        }
    }
}
