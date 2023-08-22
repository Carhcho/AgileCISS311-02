using System;
using System.Collections.Generic;
using System.Text;

namespace dropbox02
{
    class NewRelease : Movie
    {
        private int daysInTheatre;

        public int DaysInTheatre
        {
            get { return daysInTheatre; }
            set { daysInTheatre = value; }
        }

        public NewRelease(string title, string directors, int daysInTheatre)
            :base(title, directors)
        {
            if (daysInTheatre < 0)
                throw new ArgumentOutOfRangeException("Days in theatre cannot be negative");
            this.daysInTheatre = daysInTheatre;
        }

        public override decimal DisplayPrice()
        {
            decimal price;
            if (daysInTheatre <= 36)
                price = 20m - 0.5m * (daysInTheatre);
            else
                price = 2.0m;
            return price;
        }

        public override string ToString()
        {
            string str;
            str = string.Format($"Days In Theatre: {DaysInTheatre}\nPrice: {DisplayPrice():C}");
            return str;
        }
    }
}
