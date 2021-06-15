using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Costs
    {
        private string date;
        private static bool isValidDate(string d)
        {
            int year = Convert.ToInt32((d.Substring(0, 4)));
            int month = Convert.ToInt32((d.Substring(4, 2)));
            int day = Convert.ToInt32((d.Substring(6, 2)));
            if (year >= 1000 && year <= 3000 && month >= 1 && month <= 12 && day >= 01 && day <= 31)
                return true;
            return false;
        }
        public string Date
        {
            get { return date; }
            set
            {
                if (isValidDate(date))
                    date = value;
                else
                {
                    date = "0";
                    Console.WriteLine("Wrong Input Date");
                }
            }
        }
        public string ExpOrRev { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }

        public Costs()
        {

        }
        public Costs(string date, string expOrRev, string category, decimal amount)
        {
            Date = date;
            ExpOrRev = expOrRev;
            Category = category;
            Amount = amount;
        }
    }
}
