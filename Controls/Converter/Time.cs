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

            //Milliseconds to another unit
            time.Add("Milliseconds_Microseconds", FromValue * 1000);
            time.Add("Milliseconds_Seconds", FromValue / 1000);
            time.Add("Milliseconds_Minutes", FromValue / 60000);
            time.Add("Milliseconds_Hours", FromValue / 3.6000E+6m);
            time.Add("Milliseconds_Days", FromValue / 86400000);
            time.Add("Milliseconds_Weeks", FromValue / 604800000);
            time.Add("Milliseconds_Months", FromValue / 2.6280E+9m);
            time.Add("Milliseconds_Years", FromValue / 3.1536E+10m);

            //Second to antoher unit
            time.Add("Seconds_Microseconds", FromValue * 1E+6m);
            time.Add("Seconds_Milliseconds", FromValue * 1000);
            time.Add("Seconds_Minutes", FromValue / 60);
            time.Add("Seconds_Hours", FromValue / 3600);
            time.Add("Seconds_Days", FromValue / 86400);
            time.Add("Seconds_Weeks", FromValue /604800 );
            time.Add("Seconds_Months", FromValue / 2628000);
            time.Add("Seconds_Years", FromValue / 31536000);

            //Minutes to another unit
            time.Add("Minutes_Microseconds", FromValue * 1E+7m);
            time.Add("Minutes_Milliseconds", FromValue * 1E+4m);
            time.Add("Minutes_Seconds", FromValue *60 );
            time.Add("Minutes_Hours", FromValue /60);
            time.Add("Minutes_Days", FromValue / 1440);
            time.Add("Minutes_Weeks", FromValue / 10080);
            time.Add("Minutes_Month", FromValue / 43800);
            time.Add("Minutes_Years", FromValue /525600 );




            if (time.ContainsKey(ResultString))
            {
                return time[ResultString].ToString(); 
            }
            else
            { 
                return "Error! Try another value";
            }
        }
    }
}
