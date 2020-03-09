using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engineer_Calculator
{
     public class LenthHash
    {
        public decimal FromValue { get; set; }
        public string FromName { get; set; }
        public string ToName { get; set; }
        public string ResultString { get; private set; }
        private string Answer;
        public LenthHash(decimal fromValue, string fromName, string toName)
        {
            FromValue = fromValue;
            FromName = fromName;
            ToName = toName;
            ResultString = FromName + "_" + ToName;
        }
       
  
            Hashtable lenth = new Hashtable();
        
        public string GetAnswer()
        {
            lenth.Add("Kilometre_Metre", FromValue * 1000);

            if (lenth.ContainsKey(ResultString))
            return Answer = lenth[ResultString].ToString();
            return Answer = "Error Try Another Value";
        }
        
    }
}
