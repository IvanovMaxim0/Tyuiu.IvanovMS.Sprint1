﻿using Tyuiu.IvanovMS.Sprint1.Task4.V15.Lib;
class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выолнил: Иванов М. C. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Class Math                                                              *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #15                                                             *");
        Console.WriteLine("* Выполнил: Иванов Максим Сергеевич         | ПКТБ-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* вычисляет результат по формуле ((x + (y ^ 2))) / e ^ (2 - 4 * y)        *");
        Console.WriteLine("* и печатает его на экране.                                               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        double x;
        double y;
        Console.WriteLine("Введите значение X: ");
        x = Convert.ToDouble(Console.ReadLine());   
        Console.WriteLine("Введите значение Y: ");
        y = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        
        Console.WriteLine("((x + (y ^ 2))) / e ^ (2 - 4 * y) = " + ds.Calculate(x, y));
        
        Console.ReadKey();
    }
}