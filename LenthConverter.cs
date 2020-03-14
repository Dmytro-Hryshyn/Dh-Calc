using System.Collections;

namespace Engineer_Calculator
{
    /// <summary>
    /// Provides a general conversion from different leth units to another lenth unit
    /// </summary>
     public class LenthConverter:IConversion
    {
        public decimal FromValue { get; private set; }
        public string FromNameUnit { get;  private set; }
        public string ToNameUnit { get;  private set; }
        public string ResultString { get; private set ;}

        public LenthConverter(decimal fromValue, string fromNameUnit, string toNameUnit)
        {
            FromValue = fromValue;
            FromNameUnit = fromNameUnit;
            ToNameUnit = toNameUnit;
            ResultString = FromNameUnit + "_" + ToNameUnit;
        }

        /// <summary>
        /// Return a value from hash table according to a key passed to it.
        /// </summary>
        /// <returns>Answer</returns>
      

        public string GetUnswer()
        {
            Hashtable lenth = new Hashtable();
            string Answer;
            //Kilometre conversion
            lenth.Add("Kilometre_Metre", FromValue * 1000);
            lenth.Add("Kilometre_Centimetre", FromValue * 100000);
            lenth.Add("Kilometre_Millimetre", FromValue * 1000000);
            lenth.Add("Kilometre_Micrometre", FromValue * 1000000000);
            lenth.Add("Kilometre_Nanometre", FromValue * 1000000000000);
            lenth.Add("Kilometre_Mile", FromValue / 1.609m);
            lenth.Add("Kilometre_Yard", FromValue * 1094);
            lenth.Add("Kilometre_Feet", FromValue * 3281);
            lenth.Add("Kilometre_Inch", FromValue * 39370);
            lenth.Add("Kilometre_Nautical Mile", FromValue / 1.852m);

            //Metre Conversion
            lenth.Add("Metre_Kilometre", FromValue / 1000m);
            lenth.Add("Metre_Centimetre", FromValue * 100);
            lenth.Add("Metre_Millimetre", FromValue * 1000);
            lenth.Add("Metre_Micrometre", FromValue * 1000000);
            lenth.Add("Metre_Nanometre", FromValue * 1000000000);
            lenth.Add("Metre_Mile", FromValue / 1609m);
            lenth.Add("Metre_Yard", FromValue * 1.094m);
            lenth.Add("Metre_Feet", FromValue * 3.281m);
            lenth.Add("Metre_Inch", FromValue * 39.37m);
            lenth.Add("Metre_Nautical Mile", FromValue / 1852);

            //Centimetre Conversion
            lenth.Add("Centimetre_Kilometre", FromValue / 100000);
            lenth.Add("Centimetre_Metre", FromValue / 100);
            lenth.Add("Centimetre_Millimetre", FromValue * 10);
            lenth.Add("Centimetre_Micrometre", FromValue * 10000);
            lenth.Add("Centimetre_Nanometre", FromValue * 10000000);
            lenth.Add("Centimetre_Mile", FromValue / 160934);
            lenth.Add("Centimetre_Yard", FromValue / 91.44m);
            lenth.Add("Centimetre_Feet", FromValue / 30.48m);
            lenth.Add("Centimetre_Inch", FromValue / 2.54m);
            lenth.Add("Centimetre_Nautical Mile", FromValue / 185200);

            //Millimetre Conversion
            lenth.Add("Millimetre_Kilometre", FromValue / 1000000);
            lenth.Add("Millimetre_Metre", FromValue / 1000);
            lenth.Add("Millimetre_Centimetre", FromValue / 10);
            lenth.Add("Millimetre_Micrometre", FromValue * 1000);
            lenth.Add("Millimetre_Nanometre", FromValue * 1000000);
            lenth.Add("Millimetre_Mile", FromValue / 1609000);
            lenth.Add("Millimetre_Yard", FromValue / 914);
            lenth.Add("Millimetre_Feet", FromValue / 305);
            lenth.Add("Millimetre_Inch", FromValue / 25.4m);
            lenth.Add("Millimetre_Nautical Mile", FromValue / 1852000);

            //Micrometre Conversion
            lenth.Add("Micrometre_Kilometre", FromValue / 1000000000);
            lenth.Add("Micrometre_Metre", FromValue / 1000000);
            lenth.Add("Micrometre_Centimetre", FromValue / 10000);
            lenth.Add("Micrometre_Millimetre", FromValue / 1000);
            lenth.Add("Micrometre_Nanometre", FromValue * 1000);
            lenth.Add("Micrometre_Mile", FromValue / 1609000000);
            lenth.Add("Micrometre_Yard", FromValue / 914400);
            lenth.Add("Micrometre_Feet", FromValue / 304800);
            lenth.Add("Micrometre_Inch", FromValue / 25400);
            lenth.Add("Micrometre_Nautical Mile", FromValue / 1852000000);

            //Nanometre Conversion
            lenth.Add("Nanometre_Kilometre", FromValue / 1000000000000);
            lenth.Add("Nanometre_Metre", FromValue / 1000000000);
            lenth.Add("Nanometre_Centimetre", FromValue / 10000000);
            lenth.Add("Nanometre_Millimetre", FromValue / 1000000);
            lenth.Add("Nanometre_Micrometre", FromValue / 1000);
            lenth.Add("Nanometre_Mile", FromValue / 1609000000000);
            lenth.Add("Nanometre_Yard", FromValue / 914400000);
            lenth.Add("Nanometre_Feet", FromValue / 304800000);
            lenth.Add("Nanometre_Inch", FromValue / 25400000);
            lenth.Add("Nanometre_Nautical Mile", FromValue / 1852000000000);

            //Mile Conversion
            lenth.Add("Mile_Kilometre", FromValue * 1.609m);
            lenth.Add("Mile_Metre", FromValue * 1609);
            lenth.Add("Mile_Centimetre", FromValue * 160934);
            lenth.Add("Mile_Millemetre", FromValue * 1609000);
            lenth.Add("Mile_Micrometre", FromValue * 1609000000);
            lenth.Add("Mile_Nanometre", FromValue * 1609000000000);
            lenth.Add("Mile_Yard", FromValue * 1760);
            lenth.Add("Mile_Feet", FromValue * 5280);
            lenth.Add("Mile_Inch", FromValue * 63360);
            lenth.Add("Mile_Nautical Mile", FromValue / 1.151m);

            //Yard Conversion
            lenth.Add("Yard_Kilometre", FromValue / 1094);
            lenth.Add("Yard_Metre", FromValue / 1.094m);
            lenth.Add("Yard_Centimetre", FromValue * 91.44m);
            lenth.Add("Yard_Milimetre", FromValue * 914);
            lenth.Add("Yard_Micrometre", FromValue * 914400);
            lenth.Add("Yard_Nanometre", FromValue * 914400000);
            lenth.Add("Yard_Mile", FromValue / 1760);
            lenth.Add("Yard_Feet", FromValue * 3);
            lenth.Add("Yard_Inch", FromValue * 36);
            lenth.Add("Yard_Nautical Mile", FromValue / 2025);

            //Feet Conversion
            lenth.Add("Feet_Kilometre", FromValue / 3281);
            lenth.Add("Feet_Metre", FromValue / 3.281m);
            lenth.Add("Feet_Centimetre", FromValue * 30.48m);
            lenth.Add("Feet_Millimetre", FromValue * 304.8m);
            lenth.Add("Feet_Micrometre", FromValue * 304800);
            lenth.Add("Feet_Nanometre", FromValue * 304800000);
            lenth.Add("Feet_Mile", FromValue / 5280);
            lenth.Add("Feet_Yard", FromValue / 3);
            lenth.Add("Feet_Inch", FromValue / 12);
            lenth.Add("Feet_Nautical Mile", FromValue / 6076);

            //Inch Conversion
            lenth.Add("Inch_Kilometre", FromValue / 39370);
            lenth.Add("Inch_Metre", FromValue / 39.37m);
            lenth.Add("Inch_Centimetre", FromValue * 2.54m);
            lenth.Add("Inch_Millimetre", FromValue * 25.4m);
            lenth.Add("Inch_Micrometre", FromValue * 25400);
            lenth.Add("Inch_Nanometre", FromValue * 25400000);
            lenth.Add("Inch_Mile", FromValue / 63360);
            lenth.Add("Inch_Yard", FromValue / 36);
            lenth.Add("Inch_Feet", FromValue / 12);
            lenth.Add("Inch_Nautical Mile", FromValue / 72913);

            //Nautical Mile Conversion
            lenth.Add("Nautical Mile_Kilometre", FromValue * 1.852m);
            lenth.Add("Nautical Mile_Metre", FromValue * 1852);
            lenth.Add("Nautical Mile_Centimetre", FromValue * 185200);
            lenth.Add("Nautical Mile_Millimetre", FromValue * 1852000);
            lenth.Add("Nautical Mile_Micrometre", FromValue * 1852000000);
            lenth.Add("Nautical Mile_Nanometre", FromValue * 1852000000000);
            lenth.Add("Nautical Mile_Mile", FromValue * 1.151m);
            lenth.Add("Nautical Mile_Yard", FromValue * 2025);
            lenth.Add("Nautical Mile_Feet", FromValue * 6076);
            lenth.Add("Nautical Mile_Inch", FromValue * 72193);

            //Chek is hash table contains a key
            if (lenth.ContainsKey(ResultString))
                return Answer = lenth[ResultString].ToString();
            return Answer = "Error Try Another Value";
        }
    }
}
