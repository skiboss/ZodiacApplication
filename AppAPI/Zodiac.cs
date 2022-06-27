using System;

namespace AppAPI
{
    public class Zodiac
    {
        public int Day { get; set; }
        public string Month { get; set; }

        public string GetSign()
        {
            string sign = "";
            if(Month=="JAN" && Day < 20)
            {
                sign = "Carpricon";
            }
            if (Month == "JAN" && Day >= 20)
            {
                sign = "Acquarius";
            }
            if (Month == "FEB" && Day < 19)
            {
                sign = "Acquarius";
            }
            if (Month == "FEB" && Day >= 19)
            {
                sign = "Pices";
            }
            return sign;
        }
    }
}
