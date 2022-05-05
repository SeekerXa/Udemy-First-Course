using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRelations
{
    internal class Date
    {
        private int day;
        private int month;
        public int Year { get; private set; }















        public int Day
        {
            get { return day; }
            private set
            {
                int[] daysPerMonth = { 0, 31, 29, 30, 31, 30, 31, 31, 30, 31, 31, 30, 31 };

                if (value <= 0 || value > daysPerMonth[Month])
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value),value,$"{nameof(Day)} out of range current month/year");
                }
                if (Month == 2 && value == 29 && !(Year % 400 == 0 || (Year % 4 == 0 && Year % 100 != 0)))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"Current month(02) need to have max 28 days");
                }

                day = value;



            }
        }

        public int Month
        {
            get { return month; }
            private set
            {
                if (value < 0 || value > 12)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"{nameof(Month)} must be 1-12 " ;
                }
                month = value;

            }
        }
    }
}
