using System;
using System.Collections.Generic;
using System.Text;

namespace dropbox02
{
    class Classic : Movie
    {
        private int yearReleased;
        private int todayTemperature;

        public int YearReleased
        {
            get { return yearReleased; }
            set { yearReleased = value; }
        }

        public int TodayTemperature
        {
            get { return todayTemperature; }
            set { todayTemperature = value; }
        }

        public Classic(string title, string directors, int yearReleased, int todayTemperature)
            :base(title, directors)
        {
            if (yearReleased < 1888)
                throw new ArgumentOutOfRangeException("No movie before that year.");
            this.yearReleased = yearReleased;
            this.todayTemperature = todayTemperature;
        }

        public override decimal DisplayPrice()
        {
            decimal price;
            if (todayTemperature > 95)
                price = 2.0m - 2.0m * (todayTemperature - 95) * 0.01m;
            else
                price = 2.0m;
            return price;
        }

        public override string ToString()
        {
            string str;
            str = string.Format($"Classic Movie:\n") + base.ToString() + string.Format($"Year Released: {YearReleased}\nPrice: {DisplayPrice():C}"); 
            return str;
        }
    }
}
