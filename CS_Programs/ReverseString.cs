using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programs
{
    public class ReverseString
    {
        public static void GetReverseString()
        {
            Console.WriteLine("Please Enter string to reverse");
            string input = Console.ReadLine();
            string tempstr = string.Empty;
            char[] charNum = input.ToCharArray();
            for (int i = (charNum.Length-1) ; i >= 0; i--)
            {
                tempstr = tempstr + charNum[i];
            }
            Console.WriteLine(tempstr);
        }

    }
}
