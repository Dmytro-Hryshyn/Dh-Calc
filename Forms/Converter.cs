using System;
using System.Windows.Forms;
using UnitConverter;

namespace Engineer_Calculator
{
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
            //set default value for both combobox 
            //combobox1 default value is **Miles per hour**
            //combobox2 default value is **Feets per second**
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
            this.ActiveControl = textBox1;
            // Clear button set value of text boxes to 0 (lambda using)
            btnClear.Click += (sender, e) => { textBox1.Text = "0"; textBox2.Text = "0"; textBox1.Focus(); textBox1.SelectAll(); };

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CorrectInput.OnlyNumbers(sender, e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            CorrectInput.OnlyNumbers(sender, e);
            textBox2.Text = "0";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SpeedConvertor speed = new SpeedConvertor(double.Parse(textBox1.Text));
            #region Same conditions restriction

            if (comboBox1.SelectedItem.ToString() == "Miles per hour" && comboBox2.SelectedItem.ToString() == "Miles per hour")
                comboBox2.SelectedIndex += 1;
            if (comboBox1.SelectedItem.ToString() == "Feets per second" && comboBox2.SelectedItem.ToString() == "Feets per second")
                comboBox2.SelectedIndex += 1;
            if (comboBox1.SelectedItem.ToString() == "Meters per second" && comboBox2.SelectedItem.ToString() == "Meters per second")
                comboBox2.SelectedIndex += 1;
            if (comboBox1.SelectedItem.ToString() == "Kilometers per hour" && comboBox2.SelectedItem.ToString() == "Kilometers per hour")
                comboBox2.SelectedIndex += 1;
            if (comboBox1.SelectedItem.ToString() == "Knots" && comboBox2.SelectedItem.ToString() == "Knots")
                 comboBox2.SelectedIndex = 0;
                
               
                   
            
            
            #endregion
            #region Miles to Value


            if (comboBox1.SelectedItem.ToString() == "Miles per hour" && comboBox2.SelectedItem.ToString() == "Feets per second")
            {
                textBox2.Text = speed.MilesPerHour_FeetsPerSecond.ToString(".####");
            }





            else if (comboBox1.SelectedItem.ToString() == "Miles per hour" && comboBox2.SelectedItem.ToString() == "Meters per second")
            {
                textBox2.Text = speed.MilesPerHour_MetersPerSecond.ToString(".####");
            }
            else if (comboBox1.SelectedItem.ToString() == "Miles per hour" && comboBox2.SelectedItem.ToString() == "Kilometers per hour")
            {
                textBox2.Text = speed.MilesPerHour_KilometersPerHour.ToString(".####");
            }
            else if (comboBox1.SelectedItem.ToString() == "Miles per hour" && comboBox2.SelectedItem.ToString() == "Knots")
            {
                textBox2.Text = speed.MilesPerHour_Knots.ToString(".####");
            }

            #endregion
            #region Feets per second to Value
            else if (comboBox1.SelectedItem.ToString() == "Feets per second" && comboBox2.SelectedItem.ToString() == "Miles per hour")
            {
                textBox2.Text = speed.FeetsPerSecond_MilesPerHour.ToString(".####");
            }
            else if (comboBox1.SelectedItem.ToString() == "Feets per second" && comboBox2.SelectedItem.ToString() == "Meters per second")
            {
                textBox2.Text = speed.FeetsPerSecond_MetersPerSecond.ToString(".####");
            }
            else if (comboBox1.SelectedItem.ToString() == "Feets per second" && comboBox2.SelectedItem.ToString() == "Kilometers per hour")
            {
                textBox2.Text = speed.FeetsPerSecond_KilometersPerHour.ToString(".####");
            }
            else if (comboBox1.SelectedItem.ToString() == "Feets per second" && comboBox2.SelectedItem.ToString() == "Knots")
            {
                textBox2.Text = speed.FeetsPerSecond_Knots.ToString(".####");
            }
            #endregion
            #region Meters per second to Value
            else if (comboBox1.SelectedItem.ToString() == "Meters per second" && comboBox2.SelectedItem.ToString() == "Miles per hour")
            {
                textBox2.Text = speed.MetersPerSecond_MilesPerHour.ToString(".####");
            }
            else if (comboBox1.SelectedItem.ToString() == "Meters per second" && comboBox2.SelectedItem.ToString() == "Feets per second")
            {
                textBox2.Text = speed.MetersPerSecond_FeetsPerSecond.ToString(".####");
            }
            else if (comboBox1.SelectedItem.ToString() == "Meters per second" && comboBox2.SelectedItem.ToString() == "Kilometers per hour")
            {
                textBox2.Text = speed.MetersPerSecond_KilometersPerHour.ToString(".####");
            }
            else if (comboBox1.SelectedItem.ToString() == "Meters per second" && comboBox2.SelectedItem.ToString() == "Knots")
            {
                textBox2.Text = speed.MetersPerSecond_Knots.ToString(".####");
            }
            #endregion
            #region Kilometers per hour to Value
            else if (comboBox1.SelectedItem.ToString() == "Kilometers per hour" && comboBox2.SelectedItem.ToString() == "Miles per hour")
            {
                textBox2.Text = speed.KilometersPerHour_MilesPerHour.ToString(".####");
            }
            else if (comboBox1.SelectedItem.ToString() == "Kilometers per hour" && comboBox2.SelectedItem.ToString() == "Feets per second")
            {
                textBox2.Text = speed.KilometersPerHour_FeetsPerSecond.ToString(".####");
            }
            else if (comboBox1.SelectedItem.ToString() == "Kilometers per hour" && comboBox2.SelectedItem.ToString() == "Meters per second")
            {
                textBox2.Text = speed.KilometersPerHour_MetersPerSecond.ToString(".####");
            }
            else if (comboBox1.SelectedItem.ToString() == "Kilometers per hour" && comboBox2.SelectedItem.ToString() == "Knots")
            {
                textBox2.Text = speed.KilometersPerHour_Knots.ToString(".####");
            }
            #endregion
            #region Knots to Value
            else if (comboBox1.SelectedItem.ToString() == "Knots" && comboBox2.SelectedItem.ToString() == "Miles per hour")
            {
                textBox2.Text = speed.Knots_MilesPerHour.ToString(".####");
            }
            else if (comboBox1.SelectedItem.ToString() == "Knots" && comboBox2.SelectedItem.ToString() == "Feets per second")
            {
                textBox2.Text = speed.Knots_FeetsPerSecond.ToString(".####");
            }
            else if (comboBox1.SelectedItem.ToString() == "Knots" && comboBox2.SelectedItem.ToString() == "Meters per second")
            {
                textBox2.Text = speed.Knots_MetersPerSecond.ToString(".####");
            }
            else if (comboBox1.SelectedItem.ToString() == "Knots" && comboBox2.SelectedItem.ToString() == "Kilometers per hour")
            {
                textBox2.Text = speed.Knots_KilometersPerHour.ToString(".####");
            }

            #endregion
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
            if (e.KeyCode == Keys.Delete)
                btnClear.PerformClick();
        }

    }
}
