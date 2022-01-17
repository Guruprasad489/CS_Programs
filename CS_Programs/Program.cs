using System;
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
            Console.WriteLine("\n 1. Fibonacci Series \n 2. Reverse Number \n 3. Reverse String \n 4. Swap Numbers" +
                "\n 5. Arithmetic Operations \n 6. Array Multiplication \n 7. Multiple of 3 and 7 \n 8. DayProperties");
            int programNum = Convert.ToInt32(Console.ReadLine());
            switch (programNum)
            {
                case 1: 
                    FibonacciSeries.FindFibonacciSeries();
                    break;
                case 2:
                    ReverseNumber.FindReverseNumber();
                    break;
                case 3:
                    ReverseString.GetReverseString();
                    break;
                case 4:
                    SwapNumbers.SwapingNumbers();
                    break;
                case 5:
                    ArithmeticOperations.PerformArithmeticOperations();
                    break;
                case 6:
                    ArrayMultiplication.GetArrayMultiplication();
                    break;
                case 7:
                    MultipleOf_3and7.CheckMultipleof_3and7();
                    break;
                case 8:
                    DayProperties.Day_Properties();
                    break;
                default:
                    Console.WriteLine("Please choose the correct ProgramNum");
                    break;
            }
        }
    }
}