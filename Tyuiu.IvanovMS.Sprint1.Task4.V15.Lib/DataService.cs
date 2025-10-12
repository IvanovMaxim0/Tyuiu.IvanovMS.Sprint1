using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.IvanovMS.Sprint1.Task4.V15.Lib
{
    public class DataService : ISprint1Task4V15
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(((x + (Math.Pow(y,2)))) / (Math.Pow(Math.E,2) - 4 * y), 3);
        }
    }
}
