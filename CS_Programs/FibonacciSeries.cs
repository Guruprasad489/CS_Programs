using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programs
{
    public class FibonacciSeries
    {
        public static void FindFibonacciSeries()
        {
            int n1 = 0, n2 = 1, result;
            Console.WriteLine("Enter How many Fibonacci numbers to display:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci series is:");
            Console.Write(n1 + " " + n2 + " ");
            for (int i = 2; i < num; i++)
            {
                result = n1 + n2;
                Console.Write(result + " ");
                n1 = n2;
                n2 = result;
            }
            Console.ReadLine();
        }
        
    }
}
