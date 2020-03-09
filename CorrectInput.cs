using System.Windows.Forms;


namespace Engineer_Calculator
{
    public static class CorrectInput
    {
        //allows to print in textbox only numbers and one decimal point
        public static void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }


        }
       
    }
}
