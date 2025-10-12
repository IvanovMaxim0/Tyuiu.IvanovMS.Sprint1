using Tyuiu.IvanovMS.Sprint1.Task3.V6.Lib;
namespace Tyuiu.IvanovMS.Sprint1.Task3.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 100;
            double y = 6;
            double z = 8;
            var res = ds.TravelCost(x, y, z);
            Assert.AreEqual(96, res);

        }
    }
}
