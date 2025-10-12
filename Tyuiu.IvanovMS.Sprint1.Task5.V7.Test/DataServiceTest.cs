using Tyuiu.IvanovMS.Sprint1.Task5.V7.Lib;
namespace Tyuiu.IvanovMS.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double f = 360;
            DataService ds = new DataService();
            double h = ds.AngleToHoursMinutes(f);

            int result = Convert.ToInt32(h);

            int wait = 12;
            Assert.AreEqual(wait, result);
        }
    }
}
