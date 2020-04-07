using System;
using System.Collections;

namespace Engineer_Calculator
{
    public class TemperatureConverter : IConversion
    {
        public TemperatureConverter(decimal fromValue, string fromNameUnit, string toNameUnit )
        {
            FromValue = fromValue;
            FromNameUnit = fromNameUnit;
            ToNameUnit = toNameUnit;
            ResultString = FromNameUnit +"_"+ ToNameUnit; ;
        }

        public decimal FromValue { get; private set; } 

        public string FromNameUnit { get; private set; }

        public string ToNameUnit { get; private set; }

        public string ResultString { get; private set; }

        public string GetUnswer()
        {
           
            Hashtable temperatureCoversion = new Hashtable();
         
            temperatureCoversion.Add("Celsius_Kelvin", FromValue+273.15m);
            temperatureCoversion.Add("Celsius_Fahrenheit", FromValue*1.8m+32);
            temperatureCoversion.Add("Kelvin_Celsius", FromValue - 273.15m);
            temperatureCoversion.Add("Kelvin_Fahrenheit", (FromValue-273.15m)*1.8m+32);
            temperatureCoversion.Add("Fahrenheit_Celsius", (FromValue - 32) * 5/9);
            temperatureCoversion.Add("Fahrenheit_Kelvin", (FromValue - 32) * 5/9 + 273.15m);

            if (temperatureCoversion.ContainsKey(ResultString))
            {
            return temperatureCoversion[ResultString].ToString();
            }
            else
            {
                Action<string> ErrorText = Converter.ErrorHendler;
                ErrorText("Try another unit");
                return "0";
            }
        }
    }
}
