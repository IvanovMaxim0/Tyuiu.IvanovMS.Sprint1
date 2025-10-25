using Tyuiu.IvanovMS.Sprint1.Task6.V7.Lib;
namespace Tyuiu.IvanovMS.Sprint1.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Hello World";
            DataService ds = new DataService();
            string res = ds.DeleteLastLetter(strTest);
            Assert.AreEqual("Hell Worl", res); 
        }
    }
}
