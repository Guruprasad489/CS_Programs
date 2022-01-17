using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programs
{
    public class ReverseNumber
    {
        public static void FindReverseNumber()
        {
            int reminder, reverse=0;
            Console.WriteLine("Please Enter Number to reverse:");
            int number = Convert.ToInt32(Console.ReadLine());
            
            while (number > 0)
            {
                reminder = number % 10;
                reverse = (reverse * 10) + reminder;
                number = number / 10;
            }
            Console.WriteLine(reverse);
            Console.ReadLine();
        }

    }
}
