using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programs
{
    public class ArithmeticOperations
    {
        public static void PerformArithmeticOperations()
        {
            double addition, subtraction, multipication, division, average;
            Console.WriteLine("Pease Enter First Number");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pease Enter Second Number");
            double num2 = Convert.ToInt32(Console.ReadLine());

            addition = num1 + num2;
            subtraction = num1 - num2;
            multipication = num1 * num2;
            division = num1 / num2;
            average = (num1 + num2) / 2;
            
            Console.WriteLine("Addition: {0}{1}{2}",num1+ " + ", num2," = " +addition);
            Console.WriteLine("Subtrcation: {0}{1}{2}", num1 + " - ", num2, " = " +subtraction);
            Console.WriteLine("Multiplication: {0}{1}{2}", num1 + " * ", num2, " = " +multipication);
            Console.WriteLine("Division: {0}{1}{2}", num1 + " / ", num2, " = " +division);
            Console.WriteLine("Average: " + average);
        }
    }
}
