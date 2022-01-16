using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programs
{
    public class ArrayMultiplication
    {
        public static void GetArrayMultiplication()
        {
            Console.WriteLine("Please Enter the length of the arrays");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[l] , array2 = new int[l], multipication = new int[l];

            Console.WriteLine("Pease Enter inetger elements of First Array");
            for (int i = 0; i < l; i++)
            {
               array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Pease Enter integer elements of second array");
            for (int i = 0; i < l; i++)
            {
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Multiplication of the two arrays: ");
            for (int i = 0; i < l; i++)
            {
                multipication[i] = array1[i] * array2[i];
                Console.Write("{0}", multipication[i] +" ");
            }
            Console.ReadLine();
        }
    }
}
