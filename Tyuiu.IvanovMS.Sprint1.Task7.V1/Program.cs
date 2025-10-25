using Tyuiu.IvanovMS.Sprint1.Task7.V1.Lib;
class programm
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выолнил: Иванов М. С. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Добавление к решению итоговых проектов по спринту                       *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнила: Иванов Максим Сергеевич | ПКТБ-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
        Console.WriteLine("* исходным значениям данных, вводимых пользователем. Ответ округлите до 3 *");
        Console.WriteLine("*            2      1/2                                                   *");
        Console.WriteLine("*      b + (b + 4ac)        3     -2                                      *");
        Console.WriteLine("*  z = ----------------- - a c + b                                        *");
        Console.WriteLine("*             2a                                                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите значение a:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение b:");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение c:");
        double c = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(a, b, c));
    }
}