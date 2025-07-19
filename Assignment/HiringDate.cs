using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class HiringDate
    {
        private int _day;
        private int _month;
        private int _year;

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value >= 1900 && value <= DateTime.Now.Year)
                    _year = value;
                else
                    _year = 1900;
            }
        }

        public int Month
        {
            get
            {
                return _month;
            }
            set
            {
                if (value >= 1 && value <= 12)
                    _month = value;
                else
                    _month = 1;
            }
        }

        public int Day
        {
            get
            {
                return _day;
            }
            set
            {
                if (value >= 1 && value <= DateTime.DaysInMonth(Year, Month))
                    _day = value;
                else
                    _day = 1;
            }
        }

        public HiringDate(int day, int month, int year)
        {
            Year = year;
            Month = month;
            Day = day;


            // if any value is invalid
            if (_day == 0 || _month == 0 || _year == 1900)
            {
                _day = 1;
                _month = 1;
                _year = 1900;
            }
        }


        public override string ToString()
        {
            return $"{_day}/{_month}/{_year}";
        }
    }
}
