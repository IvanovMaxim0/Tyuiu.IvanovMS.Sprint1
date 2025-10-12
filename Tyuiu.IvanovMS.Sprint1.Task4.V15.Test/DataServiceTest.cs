using Tyuiu.IvanovMS.Sprint1.Task4.V15.Lib;
namespace Tyuiu.IvanovMS.Sprint1.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double wait = 0.885;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
