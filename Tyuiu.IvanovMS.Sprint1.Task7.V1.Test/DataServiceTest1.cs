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
            double a = 2;
            double b = 4;
            double c = 5;
            double wait = -37.067;
            var res = ds.Calculate(a, b, c);
            Assert.AreEqual(wait, res);
        }
    }
}
