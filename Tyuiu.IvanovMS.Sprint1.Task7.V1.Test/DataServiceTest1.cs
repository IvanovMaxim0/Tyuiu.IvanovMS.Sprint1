using Tyuiu.IvanovMS.Sprint1.Task7.V1.Lib;
namespace Tyuiu.IvanovMS.Sprint1.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest1
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 3;
            double b = 2;
            double c = 1;
            double wait = -27.75;
            var res = ds.Calculate(a, b, c);
            Assert.AreEqual(wait, res);
        }
    }
}
