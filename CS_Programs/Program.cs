﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programs
{
    public class Program
    {
        static void Main(string[] args)
        {
            //FibonacciSeries f = new FibonacciSeries();  //To create object
            Console.WriteLine("Choose the program");
            Console.WriteLine("\n 1. Fibonacci Series \n 2. Reverse Number \n 3. Reverse String \n 4. Swap Numbers ");
            //int programNum = Convert.ToInt32(Console.ReadLine()); //To read integer value
            string programNum = Console.ReadLine();
            switch (programNum)
            {
                case "1": 
                    FibonacciSeries.FindFibonacciSeries();
                    break;
                case "2":
                    ReverseNumber.FindReverseNumber();
                    break;
                case "3":
                    ReverseString.GetReverseString();
                    break;
                case "4":
                    SwapNumbers.SwapingNumbers();
                    break;
                default:
                    Console.WriteLine("Please choose the correct Program");
                    break;
            }
        }
    }
}