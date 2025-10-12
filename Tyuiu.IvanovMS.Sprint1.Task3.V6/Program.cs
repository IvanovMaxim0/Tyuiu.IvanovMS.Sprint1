using Tyuiu.IvanovMS.Sprint1.Task3.V6.Lib;
class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выолнил: Иванов М. C. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Операторы составного присваивания                                       *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #6                                                              *");
        Console.WriteLine("* Выполнил: Иванов Максим Сергеевич         | ПКТБ-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу вычисления стоимости поездки на автомобиле           *");
        Console.WriteLine("* на дачу (туда и обратно).                                               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        double x = 67;
        double y = 8.5;
        double z = 6.5;
        Console.WriteLine("Расстояние до дачи (км) -> " + x);
        Console.WriteLine("Расход бензина (литров на 100 км пробега) -> " + y);
        Console.WriteLine("Цена литра бензина (руб.) ->" + z);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Стоимость поездки: " + ds.TravelCost(x, y, z));
        Console.ReadKey();
    }
}