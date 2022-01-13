using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programs
{
    public class SwapNumbers
    {
        //Each word 1st letter has to start with Uppercase //Pascal case
        //Pascal will follow for classname and method name
        public static void SwapingNumbers()
        {
            //camel case for local variables and method parameters
            int firstNum, secondNum, temp = 0;
            Console.WriteLine("Enter First Number");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swaping: First Number is {0}, Second Number is {1}", firstNum, secondNum);
            temp = firstNum;
            firstNum=secondNum;
            secondNum=temp;
            Console.WriteLine("Before swaping: First Number is {0}, Second Number is {1}", firstNum, secondNum);
        }
    }
}
