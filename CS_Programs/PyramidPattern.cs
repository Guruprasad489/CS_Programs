using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programs
{
    internal class PyramidPattern
    {
        public static void PrintPyramidPattern()
        {
            Console.WriteLine("Enter the number of rows");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows-i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= (2*i-1); j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
