using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemyCsharpPractice
{
    public class ControlFlow
    {
        public static void Example()
        {

            ifElse.Practice();

            Console.ReadLine();
        }
    }

    public class ifElse
    {
        public static void Practice()
        {
            int hour = 10;
            CheckTime(hour);
            hour = 14;
            CheckTime(hour);
            hour = 20;
            CheckTime(hour);
        }

        public static void CheckTime(int hour)
        {
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon");
            }
            else
            {
                Console.WriteLine("It's evening");
            }
        }
    }

}
