using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.IvanovMS.Sprint1.Task6.V7.Lib
{
    public class DataService : ISprint1Task6V7
    {
        public string DeleteLastLetter(string value)
        {
            string[] words = value.Split(' ');
            string res = "";
            foreach (string word in words)
            {
                if (word.Length > 0)
                {
                    res += (word.Remove(word.Length - 1) + " ");
                }
            }
            return res.Remove(res.Length - 1);

        }
    }
}
