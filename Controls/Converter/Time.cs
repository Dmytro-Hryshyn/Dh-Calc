using System;
using System.Collections;


namespace Engineer_Calculator
{
    class Time : IConversion
    {

        private string ErorText = "Error.Try Another Unit";
        
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
        public  string GetUnswer()
        {
            Hashtable time = new Hashtable();
          
            //Microseconds to another Unit
            time.Add("Microseconds_Milliseconds", FromValue/1000);
            time.Add("Microseconds_Seconds", FromValue / 1000000);
            time.Add("Microseconds_Minutes", FromValue / 60000000);
            time.Add("Microseconds_Hours", FromValue / 3.6000E+9m);
            time.Add("Microseconds_Days", FromValue / 8.6400E+10m);
            time.Add("Microseconds_Weeks", FromValue / 6.0480E+11m);
            time.Add("Microseconds_Months", FromValue / 2.6280E+12m);
            time.Add("Microseconds_Years", FromValue / 3.1536E+13m);

            //Milliseconds to another Unit
            time.Add("Milliseconds_Microseconds", FromValue * 1000);
            time.Add("Milliseconds_Seconds", FromValue / 1000);
            time.Add("Milliseconds_Minutes", FromValue / 60000);
            time.Add("Milliseconds_Hours", FromValue / 3.6000E+6m);
            time.Add("Milliseconds_Days", FromValue / 86400000);
            time.Add("Milliseconds_Weeks", FromValue / 604800000);
            time.Add("Milliseconds_Months", FromValue / 2.6280E+9m);
            time.Add("Milliseconds_Years", FromValue / 3.1536E+10m);

            //Second to antoher Unit
            time.Add("Seconds_Microseconds", FromValue * 1E+6m);
            time.Add("Seconds_Milliseconds", FromValue * 1000);
            time.Add("Seconds_Minutes", FromValue / 60);
            time.Add("Seconds_Hours", FromValue / 3600);
            time.Add("Seconds_Days", FromValue / 86400);
            time.Add("Seconds_Weeks", FromValue /604800 );
            time.Add("Seconds_Months", FromValue / 2628000);
            time.Add("Seconds_Years", FromValue / 31536000);

            //Minutes to another Unit
            time.Add("Minutes_Microseconds", FromValue * 1E+7m);
            time.Add("Minutes_Milliseconds", FromValue * 1E+4m);
            time.Add("Minutes_Seconds", FromValue *60 );
            time.Add("Minutes_Hours", FromValue /60);
            time.Add("Minutes_Days", FromValue / 1440);
            time.Add("Minutes_Weeks", FromValue / 10080);
            time.Add("Minutes_Month", FromValue / 43800);
            time.Add("Minutes_Years", FromValue /525600 );

            //Hours to another Unit
            time.Add("Hours_Microseconds", FromValue *3.6E+09m);
            time.Add("Hours_Milliseconds",FromValue*3600000);
            time.Add("Hours_Seconds", FromValue * 3600);
            time.Add("Hours_Minutes", FromValue * 60);
            time.Add("Hours_Days", FromValue / 24);
            time.Add("Hours_Weeks", FromValue / 168);
            time.Add("Hours_Months", FromValue / 730);
            time.Add("Hours_Years", FromValue / 8760);

            //Days to another Unit
            time.Add("Days_Microseconds", FromValue * 8.64e+10m);
            time.Add("Days_Milliseconds", FromValue * 8.64e+7m);
            time.Add("Days_Seconds", FromValue * 86400);
            time.Add("Days_Minutes", FromValue * 1440);
            time.Add("Days_Hours", FromValue * 24);
            time.Add("Days_Weeks", FromValue / 7);
            time.Add("Days_Months", FromValue /30.4166667m);
            time.Add("Days_Years", FromValue / 365);

            //Weeks to another Unit
            time.Add("Weeks_Microseconds", FromValue * 6.0480E+11m);
            time.Add("Weeks_Milliseconds", FromValue * 604800000);
            time.Add("Weeks_Seconds", FromValue * 604800);
            time.Add("Weeks_Minutes", FromValue * 10080);
            time.Add("Weeks_Hours", FromValue * 168);
            time.Add("Weeks_Days", FromValue * 7);
            time.Add("Weeks_Months", FromValue / 4.3452381m);
            time.Add("Weeks_Years", FromValue / 52.1428571m);

            //Months to another Unit
            time.Add("Months_Microseconds", FromValue * 2.6280E+12m);
            time.Add("Months_Milliseconds", FromValue * 2.6280E+9m);
            time.Add("Months_Seconds", FromValue * 2628000);
            time.Add("Months_Minutes", FromValue * 43800);
            time.Add("Months_Hours", FromValue * 730);
            time.Add("Months_Days", FromValue * 30.4166667m);
            time.Add("Months_Weeks", FromValue * 4.3452381m);
            time.Add("Months_Years", FromValue /12);

            //Years to another Unit
            time.Add("Years_Microseconds", FromValue * 3.1536E+13m);
            time.Add("Years_Milliseconds", FromValue * 3.1536E+10m);
            time.Add("Years_Seconds", FromValue * 31536000);
            time.Add("Years_Minutes", FromValue * 525600);
            time.Add("Years_Hours", FromValue * 8760);
            time.Add("Years_Days", FromValue * 365);
            time.Add("Years_Weeks", FromValue * 52.1428571m);
            time.Add("Years_Months", FromValue * 12);


            if (time.ContainsKey(ResultString))
            {
                return time[ResultString].ToString(); 
            }
            else
            {
                Action<string> errorMessage = Converter.ErrorHendler;
                errorMessage(ErorText);
                return "0";
            }
        }
    }
}
