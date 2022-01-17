using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programs
{
    public class DayProperties
    {
        public static void Day_Properties()
        {
            System.DateTime moment = new System.DateTime(2016, 8, 16, 3, 57, 32, 11);

            Console.WriteLine("year = " + moment.Year);

            Console.WriteLine("month = " + moment.Month);

            Console.WriteLine("day = " + moment.Day);

            Console.WriteLine("hour = " + moment.Hour);

            Console.WriteLine("minute = " + moment.Minute);

            Console.WriteLine("second = " + moment.Second);

            Console.WriteLine("millisecond = " + moment.Millisecond);
        }
    }
}
