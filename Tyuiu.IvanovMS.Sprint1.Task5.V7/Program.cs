using Tyuiu.IvanovMS.Sprint1.Task5.V7.Lib;
class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выолнил: Иванов М. C. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Преобразование типов и класс Convert                                    *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("* Выполнил: Иванов Максим Сергеевич         | ПКТБ-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая решает следующую задачу: Определить h -     *");
        Console.WriteLine("* полное количество часов прошедших от начала суток до того момента       *");
        Console.WriteLine("* (в первой половине дня), когда часовая стрелка повернулась на f         *");
        Console.WriteLine("* градусов (0<f<360, f – вещественное число).                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите значение f: ");
        double f = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int h = Convert.ToInt32(ds.AngleToHoursMinutes(f));
        Console.WriteLine(h); 

        Console.ReadKey();
    }
}