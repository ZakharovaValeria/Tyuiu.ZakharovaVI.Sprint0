﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Tyuiu.ZakharovaVI.Sprint0.Task5.V0.Lib;
namespace Tyuiu.ZakharovaVI.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("А + Б = " + DataService.Addition(1, 5));
            Console.WriteLine("А - Б = " + DataService.Subtraction(15, 5));
            Console.WriteLine("А * Б = " + DataService.Multiplication(10, 10));
            Console.WriteLine("А / Б = " + DataService.Division(9, 3));
            Console.ReadKey();
        }
    }
}
