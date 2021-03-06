﻿using System;
using System.Windows.Forms;
using UnitConverterLib;

namespace Engineer_Calculator
{
    public partial class Converter : Form
    {
        
        public Converter()
        {
            InitializeComponent();
            #region Speed
            //set default value for both combobox 
            //combobox1 default value is **Miles per hour**
            //combobox2 default value is **Feets per second**
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
            this.ActiveControl = textBox1;
            // Clear button set value of text boxes to 0 (lambda using)
            btnClear.Click += (sender, e) => { textBox1.Text = "0"; textBox2.Text = "0"; textBox1.Focus(); textBox1.SelectAll(); };
            #endregion
            #region Lenth tab contol
            //Clear text bot for Lenth Tab
            Lenth_Clear_Btn.Click += (sender, e) =>{
            Lenth_FromValue_TBox.Text = "0"; Lenth_ToValue_TBox.Text = "0"; Lenth_FromValue_TBox.Focus();
            Lenth_FromValue_TBox.SelectAll();
            };
            Lenth_FromValue_CBox.SelectedIndex = 0;
            Lenth_ToValue_CBox.SelectedIndex = 1;
            Lenth_FromValue_TBox.KeyPress += (sender, e) => { CorrectInput.OnlyNumbers(sender,e); };
            Lenth_ToValue_CBox.TextChanged += (s, e) => { this.LenthConvert(); };
            Lenth_FromValue_CBox.TextChanged += (s, e) => { this.LenthConvert(); };
            Lenth_Convert_Btn.Click += (s, e) => { this.LenthConvert(); };


            #endregion
            #region Temperature tab control
            Temperature_FromValue_CBox.SelectedIndex = 0;
            Temperature_ToValue_Cbox.SelectedIndex = 1;
            Temperature_FromValue_TBox.KeyPress += (sender, e) => { CorrectInput.OnlyNumbers(sender, e); };
            Temperature_Clear_Btn.Click += (sender, e) => { Temperature_FromValue_TBox.Text ="0"; Temperature_ToValue_TBox.Text = "0";Temperature_FromValue_TBox.Focus(); Temperature_FromValue_TBox.SelectAll(); };
            Temperature_ToValue_Cbox.TextChanged += (sender, e) => TemperatureConvert();
            Temperature_Convert_Btn.Click += (sender, e) => TemperatureConvert();
            Temperature_FromValue_CBox.TextChanged += (sender, e) => TemperatureConvert();

            #endregion
            #region Angle tab control
            Angle_FromValue_CBox.SelectedIndex = 0;
            Angle_ToValue_CBox.SelectedIndex = 1;
            Angle_FromValue_TBox.KeyPress += (sender, e) => { CorrectInput.OnlyNumbers(sender, e); };
            Angle_Clear_Btn.Click += (sender, e) => { Angle_FromValue_TBox.Text = "0"; Angle_ToValue_TBox.Text = "0";Angle_FromValue_TBox.Focus(); Angle_FromValue_TBox.SelectAll(); };
            Angle_Convert_Btn.Click += (sender, e) => { AngleConvert(); };
            Angle_FromValue_CBox.TextChanged += (s, a) => { if (Angle_FromValue_TBox.Text != 0.ToString()) AngleConvert(); };
            #endregion
            #region Time 
            Time_FromValue_Cbox.SelectedIndex = 0;
            Time_ToValue_Cbox.SelectedIndex = 1;
            Time_FromValue_Tbox.KeyPress += (sender, e) => { CorrectInput.OnlyNumbers(sender, e); };
            Time_Clear_Btn.Click += (s, a) =>
            { Time_FromValue_Tbox.Text = "0"; Time_ToValue_Tbox.Text = "0"; Time_FromValue_Tbox.Focus(); Time_FromValue_Tbox.SelectAll(); };
            Time_Convert_Btn.Click += (s, a) => { TimeConvert(); };
            Time_FromValue_Cbox.TextChanged += (s, a) => { TimeConvert(); };
            #endregion
        }

        public static void ErrorHendler(string errorText)
        {
            MessageBox.Show(errorText, "An Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        #region Speed business logic

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
            
            SpeedConverter speed = new SpeedConverter(double.Parse(textBox1.Text));
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
                textBox2.Text = speed.MilesPerHour_MetresPerSecond.ToString(".####");
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
                textBox2.Text = speed.FeetsPerSecond_MetresPerSecond.ToString(".####");
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
                textBox2.Text = speed.MetresPerSecond_MilesPerHour.ToString(".####");
            }
            else if (comboBox1.SelectedItem.ToString() == "Meters per second" && comboBox2.SelectedItem.ToString() == "Feets per second")
            {
                textBox2.Text = speed.MetresPerSecond_FeetsPerSecond.ToString(".####");
            }
            else if (comboBox1.SelectedItem.ToString() == "Meters per second" && comboBox2.SelectedItem.ToString() == "Kilometers per hour")
            {
                textBox2.Text = speed.MetresPerSecond_KilometersPerHour.ToString(".####");
            }
            else if (comboBox1.SelectedItem.ToString() == "Meters per second" && comboBox2.SelectedItem.ToString() == "Knots")
            {
                textBox2.Text = speed.MetresPerSecond_Knots.ToString(".####");
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
                textBox2.Text = speed.KilometersPerHour_MetresPerSecond.ToString(".####");
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
                textBox2.Text = speed.Knots_MetresPerSecond.ToString(".####");
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
        #endregion
        #region Lenth business logic
        private void LenthConvert()
        {
            LenthConverter lenth = new LenthConverter(decimal.Parse(Lenth_FromValue_TBox.Text), Lenth_FromValue_CBox.SelectedItem.ToString(), Lenth_ToValue_CBox.SelectedItem.ToString());
            Lenth_ToValue_TBox.Text = lenth.GetUnswer();
            Lenth_Answer_Lable.Text = $"{Lenth_FromValue_TBox.Text} { Lenth_FromValue_CBox.SelectedItem.ToString()} = {Lenth_ToValue_TBox.Text} {Lenth_ToValue_CBox.SelectedItem.ToString()}";
        }


        #endregion
        #region Temperature bussines logic
       private void TemperatureConvert()
        {
            TemperatureConverter temp = new TemperatureConverter(decimal.Parse(Temperature_FromValue_TBox.Text), Temperature_FromValue_CBox.SelectedItem.ToString(), Temperature_ToValue_Cbox.SelectedItem.ToString());
            Temperature_ToValue_TBox.Text = temp.GetUnswer();
            Temperature_Answer_label.Text = $"{Temperature_FromValue_TBox.Text} { Temperature_FromValue_CBox.SelectedItem.ToString()} = {Temperature_ToValue_TBox.Text} {Temperature_ToValue_Cbox.SelectedItem.ToString()}";
        }
        #endregion
        #region Angle bussines logic
        private void AngleConvert()
        {
            AngleConverter angle = new AngleConverter(decimal.Parse(Angle_FromValue_TBox.Text), Angle_FromValue_CBox.SelectedItem.ToString(), Angle_ToValue_CBox.SelectedItem.ToString());
            Angle_ToValue_TBox.Text=angle.GetUnswer();
            Angle_answer_Lable.Text = $"{Angle_FromValue_TBox.Text} { Angle_FromValue_CBox.SelectedItem.ToString()} = {Angle_ToValue_TBox.Text} {Angle_ToValue_CBox.SelectedItem.ToString()}";
        }
        #endregion
        #region Time bussines logic
        private void TimeConvert()
        {
            
         
            Time time = new Time(decimal.Parse(Time_FromValue_Tbox.Text), Time_FromValue_Cbox.Text, Time_ToValue_Cbox.Text);
            Time_ToValue_Tbox.Text = time.GetUnswer();
            Time_answer_label.Text = ($"{Time_FromValue_Tbox.Text} {Time_FromValue_Cbox.Text} = {Time_ToValue_Tbox.Text} {Time_ToValue_Cbox.Text}");
            }
        }
        #endregion

    }


