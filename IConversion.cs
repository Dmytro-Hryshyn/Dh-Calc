

namespace Engineer_Calculator
{
    interface IConversion
    {
        decimal FromValue { get; }
        string FromNameUnit { get; }
        string ToNameUnit { get; }
        string ResultString { get; }

        string GetUnswer();
       
    }
}
