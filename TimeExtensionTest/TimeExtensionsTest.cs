using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeExtensionTest
{
    internal class TimeExtensionsTest
    {
        static void Main(string[] args)
        {
            var myTime = new Time2(11, 34, 15);
            Console.WriteLine("Use the DisplayTime extention method: ");
            myTime.DisplayTime();
            Console.WriteLine("adding 5hour to time: ");
            var timeAdded = myTime.AddHours(5);
            timeAdded.DisplayTime();

            Console.WriteLine("adding 15 hours: ");
            myTime.AddHours(15).DisplayTime();

            TimeExtensions.DisplayTime (myTime);




        }
    }

    static class TimeExtensions
    {
        public static void DisplayTime(this Time2 aTime)
        {
            Console.WriteLine(aTime.ToString());
        }

        public static Time2 AddHours(this Time2 aTime, int hours)
        {
            var newTime = new Time2 { Minute = aTime.Minute, Second = aTime.Second };
            newTime.Hour=(aTime.Hour+hours)% 24;
            return newTime;

        }
    }
}





