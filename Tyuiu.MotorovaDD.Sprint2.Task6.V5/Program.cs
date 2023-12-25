﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MotorovaDD.Sprint2.Task6.V5.Lib;

namespace Tyuiu.MotorovaDD.Sprint2.Task6.V5
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();



            Console.Title = "Спринт #2| Выполнил: Моторова Д. Д. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Сокращённый оператор switch                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил Моторова Дана Дмитриевна | СМАРТб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая, используя оператор switch, по номеру       *");
            Console.WriteLine("* карты определяет её достоинство.                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер карты: ");
            int x = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((x < 6) || (x > 14))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Достоинство данной карты: " + ds.FindCardValue(x);
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();


        }
    }
}
