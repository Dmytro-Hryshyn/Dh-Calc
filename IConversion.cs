

namespace Engineer_Calculator
{
    interface IConversion
    {
        decimal FromValue { get; set; }
        string FromNameUnit { get; set; }
        string ToNameUnit { get;  set; }
        string ResultString { get;   set; }

        string GetUnswer();
            
    }
}
