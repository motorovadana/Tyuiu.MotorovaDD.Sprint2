using System;
using System.Collections.Generic;
using System.Linq;
using Tyuiu.MotorovaDD.Sprint2.Task2.V11.Lib;



namespace Tyuiu.MotorovaDD.Sprint2.Task2.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Введите значение x");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение y");
            int y = Convert.ToInt32(Console.ReadLine());
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            if(res)
            {
                Console.WriteLine("Точка находиться в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находиться в заштрихованной области");
            }
            Console.ReadKey();
        }
    }
}
