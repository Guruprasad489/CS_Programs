using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programs
{
    public class MultipleOf3and7
    {
        public static void CheckMultipleof3and7()
        {
            Console.WriteLine("Enter an integer to check wheather it is \"multiple of 3 and 7\" or not:");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {
                if (x % 3 == 0 && x % 7 == 0)
                {
                    Console.WriteLine(x + " is Multiple of 3 and 7");
                }
                else
                    Console.WriteLine(x + " is not Multiple of 3 and 7");
            }
            Console.ReadLine();
        }
    }
}
