using System;
using System.Collections;


namespace Engineer_Calculator
{
    class AngleConverter : IConversion
    {
        public decimal FromValue   { get; private set; }

        public string FromNameUnit { get; private set; } 

        public string ToNameUnit   { get; private set; }

        public string ResultString { get; private set; }

        public AngleConverter(decimal fromValue, string fromNameUnit, string toNameUnit)
        {
            FromValue = fromValue;
            FromNameUnit = fromNameUnit;
            ToNameUnit = toNameUnit;
            ResultString = FromNameUnit + "_" + ToNameUnit;
        }

        public string GetUnswer()
        {
            Hashtable angleHash = new Hashtable();
            
            //Degrees to another units
            angleHash.Add("Degrees_Radians", FromValue * ((decimal)Math.PI / 180));
            angleHash.Add("Degrees_Gradians", FromValue * 1.11111111m);

            //Radians to antoher value
            angleHash.Add("Radians_Degrees", FromValue * 180 / (decimal)Math.PI);
            angleHash.Add("Radians_Gradians", FromValue * 63.6619772m);

            //Gradians to another value
            angleHash.Add("Gradians_Degrees", FromValue / 1.11111111m);
            angleHash.Add("Gradians_Radians", FromValue / 63.6619772m);

            if (angleHash.ContainsKey(ResultString))
                return angleHash[ResultString].ToString().Remove(6);
            else return "Error! Try another value";
        }
    }
}
