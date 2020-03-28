using System;
using System.Collections;


namespace Engineer_Calculator
{
    class Time : IConversion
    {
        public decimal FromValue    { get; private set; }

        public string FromNameUnit  { get; private set; }

        public string ToNameUnit    { get; private set; }
         
        public string ResultString  { get; private set; }

        public Time(decimal fromValue, string fromNameUnit, string toNameUnit)
        {
            FromValue = fromValue;
            FromNameUnit = fromNameUnit;
            ToNameUnit = toNameUnit;
            ResultString = FromNameUnit+"_"+ToNameUnit;
        }

        public string GetUnswer()
        {
            // Microseconds 
            // Milliseconds 
            // Seconds 
            // Minutes 
            // Hours 
            // Days
            // Weeks  
            // Months
            // Years  
            Hashtable time = new Hashtable();
            //Microseconds to another unit
            time.Add("Microseconds_Milliseconds", FromValue/1000);
            time.Add("Microseconds_Seconds", FromValue / 1000000);
            time.Add("Microseconds_Minutes", FromValue / 60000000);
            time.Add("Microseconds_Hours", FromValue / 3.6000E+9m);
            time.Add("Microseconds_Days", FromValue / 8.6400E+10m);
            time.Add("Microseconds_Weeks", FromValue / 6.0480E+11m);
            time.Add("Microseconds_Months", FromValue / 2.6280E+12m);
            time.Add("Microseconds_Years", FromValue / 3.1536E+13m);

            if (time.ContainsKey(ResultString) && time.Values!=null)
                return time[ResultString].ToString();
            else return "Error! Try another value";
        }
    }
}
