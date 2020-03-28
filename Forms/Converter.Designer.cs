namespace Engineer_Calculator
{
    partial class Converter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Converter));
            this.TemperatureTab = new System.Windows.Forms.TabPage();
            this.Temperature_ToValue_TBox = new System.Windows.Forms.TextBox();
            this.Temperature_FromValue_TBox = new System.Windows.Forms.TextBox();
            this.Temperature_ToValue_Cbox = new System.Windows.Forms.ComboBox();
            this.Temperature_FromValue_CBox = new System.Windows.Forms.ComboBox();
            this.LenthTab = new System.Windows.Forms.TabPage();
            this.Lenth_ToValue_TBox = new System.Windows.Forms.TextBox();
            this.Lenth_FromValue_TBox = new System.Windows.Forms.TextBox();
            this.Lenth_ToValue_CBox = new System.Windows.Forms.ComboBox();
            this.Lenth_FromValue_CBox = new System.Windows.Forms.ComboBox();
            this.TimeTab = new System.Windows.Forms.TabPage();
            this.SpeedTab = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.AngleTab = new System.Windows.Forms.TabPage();
            this.Angle_answer_Lable = new System.Windows.Forms.Label();
            this.Angle_ToValue_TBox = new System.Windows.Forms.TextBox();
            this.Angle_FromValue_TBox = new System.Windows.Forms.TextBox();
            this.Angle_ToValue_CBox = new System.Windows.Forms.ComboBox();
            this.Angle_FromValue_CBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Temperature_Clear_Btn = new System.Windows.Forms.Button();
            this.Temperature_Convert_Btn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Lenth_Clear_Btn = new System.Windows.Forms.Button();
            this.Lenth_Convert_Btn = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Angle_Clear_Btn = new System.Windows.Forms.Button();
            this.Angle_Convert_Btn = new System.Windows.Forms.Button();
            this.Time_answer_label = new System.Windows.Forms.Label();
            this.Time_ToValue_Tbox = new System.Windows.Forms.TextBox();
            this.Time_FromValue_Tbox = new System.Windows.Forms.TextBox();
            this.Time_ToValue_Cbox = new System.Windows.Forms.ComboBox();
            this.Time_FromValue_Cbox = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Time_Clear_Btn = new System.Windows.Forms.Button();
            this.Time_Convert_Btn = new System.Windows.Forms.Button();
            this.TemperatureTab.SuspendLayout();
            this.LenthTab.SuspendLayout();
            this.TimeTab.SuspendLayout();
            this.SpeedTab.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.AngleTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TemperatureTab
            // 
            this.TemperatureTab.BackColor = System.Drawing.SystemColors.Control;
            this.TemperatureTab.Controls.Add(this.pictureBox4);
            this.TemperatureTab.Controls.Add(this.Temperature_Clear_Btn);
            this.TemperatureTab.Controls.Add(this.Temperature_Convert_Btn);
            this.TemperatureTab.Controls.Add(this.Temperature_ToValue_TBox);
            this.TemperatureTab.Controls.Add(this.Temperature_FromValue_TBox);
            this.TemperatureTab.Controls.Add(this.Temperature_ToValue_Cbox);
            this.TemperatureTab.Controls.Add(this.Temperature_FromValue_CBox);
            resources.ApplyResources(this.TemperatureTab, "TemperatureTab");
            this.TemperatureTab.Name = "TemperatureTab";
            // 
            // Temperature_ToValue_TBox
            // 
            this.Temperature_ToValue_TBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Temperature_ToValue_TBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.Temperature_ToValue_TBox, "Temperature_ToValue_TBox");
            this.Temperature_ToValue_TBox.Name = "Temperature_ToValue_TBox";
            this.Temperature_ToValue_TBox.ReadOnly = true;
            // 
            // Temperature_FromValue_TBox
            // 
            this.Temperature_FromValue_TBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Temperature_FromValue_TBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.Temperature_FromValue_TBox, "Temperature_FromValue_TBox");
            this.Temperature_FromValue_TBox.Name = "Temperature_FromValue_TBox";
            // 
            // Temperature_ToValue_Cbox
            // 
            this.Temperature_ToValue_Cbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Temperature_ToValue_Cbox.FormattingEnabled = true;
            this.Temperature_ToValue_Cbox.Items.AddRange(new object[] {
            resources.GetString("Temperature_ToValue_Cbox.Items"),
            resources.GetString("Temperature_ToValue_Cbox.Items1"),
            resources.GetString("Temperature_ToValue_Cbox.Items2")});
            resources.ApplyResources(this.Temperature_ToValue_Cbox, "Temperature_ToValue_Cbox");
            this.Temperature_ToValue_Cbox.Name = "Temperature_ToValue_Cbox";
            // 
            // Temperature_FromValue_CBox
            // 
            this.Temperature_FromValue_CBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Temperature_FromValue_CBox.FormattingEnabled = true;
            this.Temperature_FromValue_CBox.Items.AddRange(new object[] {
            resources.GetString("Temperature_FromValue_CBox.Items"),
            resources.GetString("Temperature_FromValue_CBox.Items1"),
            resources.GetString("Temperature_FromValue_CBox.Items2")});
            resources.ApplyResources(this.Temperature_FromValue_CBox, "Temperature_FromValue_CBox");
            this.Temperature_FromValue_CBox.Name = "Temperature_FromValue_CBox";
            // 
            // LenthTab
            // 
            this.LenthTab.BackColor = System.Drawing.SystemColors.Control;
            this.LenthTab.Controls.Add(this.pictureBox3);
            this.LenthTab.Controls.Add(this.Lenth_Clear_Btn);
            this.LenthTab.Controls.Add(this.Lenth_Convert_Btn);
            this.LenthTab.Controls.Add(this.Lenth_ToValue_TBox);
            this.LenthTab.Controls.Add(this.Lenth_FromValue_TBox);
            this.LenthTab.Controls.Add(this.Lenth_ToValue_CBox);
            this.LenthTab.Controls.Add(this.Lenth_FromValue_CBox);
            resources.ApplyResources(this.LenthTab, "LenthTab");
            this.LenthTab.Name = "LenthTab";
            // 
            // Lenth_ToValue_TBox
            // 
            this.Lenth_ToValue_TBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Lenth_ToValue_TBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.Lenth_ToValue_TBox, "Lenth_ToValue_TBox");
            this.Lenth_ToValue_TBox.Name = "Lenth_ToValue_TBox";
            this.Lenth_ToValue_TBox.ReadOnly = true;
            // 
            // Lenth_FromValue_TBox
            // 
            this.Lenth_FromValue_TBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Lenth_FromValue_TBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.Lenth_FromValue_TBox, "Lenth_FromValue_TBox");
            this.Lenth_FromValue_TBox.Name = "Lenth_FromValue_TBox";
            // 
            // Lenth_ToValue_CBox
            // 
            this.Lenth_ToValue_CBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Lenth_ToValue_CBox.FormattingEnabled = true;
            this.Lenth_ToValue_CBox.Items.AddRange(new object[] {
            resources.GetString("Lenth_ToValue_CBox.Items"),
            resources.GetString("Lenth_ToValue_CBox.Items1"),
            resources.GetString("Lenth_ToValue_CBox.Items2"),
            resources.GetString("Lenth_ToValue_CBox.Items3"),
            resources.GetString("Lenth_ToValue_CBox.Items4"),
            resources.GetString("Lenth_ToValue_CBox.Items5"),
            resources.GetString("Lenth_ToValue_CBox.Items6"),
            resources.GetString("Lenth_ToValue_CBox.Items7"),
            resources.GetString("Lenth_ToValue_CBox.Items8"),
            resources.GetString("Lenth_ToValue_CBox.Items9"),
            resources.GetString("Lenth_ToValue_CBox.Items10")});
            resources.ApplyResources(this.Lenth_ToValue_CBox, "Lenth_ToValue_CBox");
            this.Lenth_ToValue_CBox.Name = "Lenth_ToValue_CBox";
            // 
            // Lenth_FromValue_CBox
            // 
            this.Lenth_FromValue_CBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Lenth_FromValue_CBox.FormattingEnabled = true;
            this.Lenth_FromValue_CBox.Items.AddRange(new object[] {
            resources.GetString("Lenth_FromValue_CBox.Items"),
            resources.GetString("Lenth_FromValue_CBox.Items1"),
            resources.GetString("Lenth_FromValue_CBox.Items2"),
            resources.GetString("Lenth_FromValue_CBox.Items3"),
            resources.GetString("Lenth_FromValue_CBox.Items4"),
            resources.GetString("Lenth_FromValue_CBox.Items5"),
            resources.GetString("Lenth_FromValue_CBox.Items6"),
            resources.GetString("Lenth_FromValue_CBox.Items7"),
            resources.GetString("Lenth_FromValue_CBox.Items8"),
            resources.GetString("Lenth_FromValue_CBox.Items9"),
            resources.GetString("Lenth_FromValue_CBox.Items10")});
            resources.ApplyResources(this.Lenth_FromValue_CBox, "Lenth_FromValue_CBox");
            this.Lenth_FromValue_CBox.Name = "Lenth_FromValue_CBox";
            // 
            // TimeTab
            // 
            this.TimeTab.BackColor = System.Drawing.SystemColors.Control;
            this.TimeTab.Controls.Add(this.Time_answer_label);
            this.TimeTab.Controls.Add(this.Time_ToValue_Tbox);
            this.TimeTab.Controls.Add(this.Time_FromValue_Tbox);
            this.TimeTab.Controls.Add(this.Time_ToValue_Cbox);
            this.TimeTab.Controls.Add(this.Time_FromValue_Cbox);
            this.TimeTab.Controls.Add(this.pictureBox2);
            this.TimeTab.Controls.Add(this.Time_Clear_Btn);
            this.TimeTab.Controls.Add(this.Time_Convert_Btn);
            resources.ApplyResources(this.TimeTab, "TimeTab");
            this.TimeTab.Name = "TimeTab";
            // 
            // SpeedTab
            // 
            this.SpeedTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpeedTab.Controls.Add(this.pictureBox1);
            this.SpeedTab.Controls.Add(this.btnClear);
            this.SpeedTab.Controls.Add(this.button1);
            this.SpeedTab.Controls.Add(this.textBox2);
            this.SpeedTab.Controls.Add(this.textBox1);
            this.SpeedTab.Controls.Add(this.comboBox2);
            this.SpeedTab.Controls.Add(this.comboBox1);
            resources.ApplyResources(this.SpeedTab, "SpeedTab");
            this.SpeedTab.Name = "SpeedTab";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            resources.GetString("comboBox2.Items"),
            resources.GetString("comboBox2.Items1"),
            resources.GetString("comboBox2.Items2"),
            resources.GetString("comboBox2.Items3"),
            resources.GetString("comboBox2.Items4")});
            this.comboBox2.Name = "comboBox2";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3"),
            resources.GetString("comboBox1.Items4")});
            this.comboBox1.Name = "comboBox1";
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.SpeedTab);
            this.Tabs.Controls.Add(this.LenthTab);
            this.Tabs.Controls.Add(this.TemperatureTab);
            this.Tabs.Controls.Add(this.TimeTab);
            this.Tabs.Controls.Add(this.AngleTab);
            resources.ApplyResources(this.Tabs, "Tabs");
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            // 
            // AngleTab
            // 
            this.AngleTab.BackColor = System.Drawing.SystemColors.Control;
            this.AngleTab.Controls.Add(this.Angle_answer_Lable);
            this.AngleTab.Controls.Add(this.Angle_ToValue_TBox);
            this.AngleTab.Controls.Add(this.Angle_FromValue_TBox);
            this.AngleTab.Controls.Add(this.Angle_ToValue_CBox);
            this.AngleTab.Controls.Add(this.Angle_FromValue_CBox);
            this.AngleTab.Controls.Add(this.pictureBox5);
            this.AngleTab.Controls.Add(this.Angle_Clear_Btn);
            this.AngleTab.Controls.Add(this.Angle_Convert_Btn);
            resources.ApplyResources(this.AngleTab, "AngleTab");
            this.AngleTab.Name = "AngleTab";
            // 
            // Angle_answer_Lable
            // 
            resources.ApplyResources(this.Angle_answer_Lable, "Angle_answer_Lable");
            this.Angle_answer_Lable.Name = "Angle_answer_Lable";
            // 
            // Angle_ToValue_TBox
            // 
            this.Angle_ToValue_TBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Angle_ToValue_TBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.Angle_ToValue_TBox, "Angle_ToValue_TBox");
            this.Angle_ToValue_TBox.Name = "Angle_ToValue_TBox";
            // 
            // Angle_FromValue_TBox
            // 
            this.Angle_FromValue_TBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Angle_FromValue_TBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.Angle_FromValue_TBox, "Angle_FromValue_TBox");
            this.Angle_FromValue_TBox.Name = "Angle_FromValue_TBox";
            // 
            // Angle_ToValue_CBox
            // 
            this.Angle_ToValue_CBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Angle_ToValue_CBox.FormattingEnabled = true;
            this.Angle_ToValue_CBox.Items.AddRange(new object[] {
            resources.GetString("Angle_ToValue_CBox.Items"),
            resources.GetString("Angle_ToValue_CBox.Items1"),
            resources.GetString("Angle_ToValue_CBox.Items2")});
            resources.ApplyResources(this.Angle_ToValue_CBox, "Angle_ToValue_CBox");
            this.Angle_ToValue_CBox.Name = "Angle_ToValue_CBox";
            // 
            // Angle_FromValue_CBox
            // 
            this.Angle_FromValue_CBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Angle_FromValue_CBox.FormattingEnabled = true;
            this.Angle_FromValue_CBox.Items.AddRange(new object[] {
            resources.GetString("Angle_FromValue_CBox.Items"),
            resources.GetString("Angle_FromValue_CBox.Items1"),
            resources.GetString("Angle_FromValue_CBox.Items2")});
            resources.ApplyResources(this.Angle_FromValue_CBox, "Angle_FromValue_CBox");
            this.Angle_FromValue_CBox.Name = "Angle_FromValue_CBox";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Engineer_Calculator.Properties.Resources.Arrow_right_icon;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Image = global::Engineer_Calculator.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_edit_clear_locationbar_ltr;
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Image = global::Engineer_Calculator.Properties.Resources.Hopstarter_Soft_Scraps_Button_Refresh;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Engineer_Calculator.Properties.Resources.Arrow_right_icon;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // Temperature_Clear_Btn
            // 
            resources.ApplyResources(this.Temperature_Clear_Btn, "Temperature_Clear_Btn");
            this.Temperature_Clear_Btn.Image = global::Engineer_Calculator.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_edit_clear_locationbar_ltr;
            this.Temperature_Clear_Btn.Name = "Temperature_Clear_Btn";
            this.Temperature_Clear_Btn.UseVisualStyleBackColor = true;
            // 
            // Temperature_Convert_Btn
            // 
            resources.ApplyResources(this.Temperature_Convert_Btn, "Temperature_Convert_Btn");
            this.Temperature_Convert_Btn.Image = global::Engineer_Calculator.Properties.Resources.Hopstarter_Soft_Scraps_Button_Refresh;
            this.Temperature_Convert_Btn.Name = "Temperature_Convert_Btn";
            this.Temperature_Convert_Btn.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Engineer_Calculator.Properties.Resources.Arrow_right_icon;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // Lenth_Clear_Btn
            // 
            resources.ApplyResources(this.Lenth_Clear_Btn, "Lenth_Clear_Btn");
            this.Lenth_Clear_Btn.Image = global::Engineer_Calculator.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_edit_clear_locationbar_ltr;
            this.Lenth_Clear_Btn.Name = "Lenth_Clear_Btn";
            this.Lenth_Clear_Btn.UseVisualStyleBackColor = true;
            // 
            // Lenth_Convert_Btn
            // 
            resources.ApplyResources(this.Lenth_Convert_Btn, "Lenth_Convert_Btn");
            this.Lenth_Convert_Btn.Image = global::Engineer_Calculator.Properties.Resources.Hopstarter_Soft_Scraps_Button_Refresh;
            this.Lenth_Convert_Btn.Name = "Lenth_Convert_Btn";
            this.Lenth_Convert_Btn.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Engineer_Calculator.Properties.Resources.Arrow_right_icon;
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // Angle_Clear_Btn
            // 
            resources.ApplyResources(this.Angle_Clear_Btn, "Angle_Clear_Btn");
            this.Angle_Clear_Btn.Image = global::Engineer_Calculator.Properties.Resources.backspace2;
            this.Angle_Clear_Btn.Name = "Angle_Clear_Btn";
            this.Angle_Clear_Btn.UseVisualStyleBackColor = true;
            // 
            // Angle_Convert_Btn
            // 
            resources.ApplyResources(this.Angle_Convert_Btn, "Angle_Convert_Btn");
            this.Angle_Convert_Btn.Image = global::Engineer_Calculator.Properties.Resources.icons8_available_updates_16;
            this.Angle_Convert_Btn.Name = "Angle_Convert_Btn";
            this.Angle_Convert_Btn.UseVisualStyleBackColor = true;
            // 
            // Time_answer_label
            // 
            resources.ApplyResources(this.Time_answer_label, "Time_answer_label");
            this.Time_answer_label.Name = "Time_answer_label";
            // 
            // Time_ToValue_Tbox
            // 
            this.Time_ToValue_Tbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Time_ToValue_Tbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.Time_ToValue_Tbox, "Time_ToValue_Tbox");
            this.Time_ToValue_Tbox.Name = "Time_ToValue_Tbox";
            // 
            // Time_FromValue_Tbox
            // 
            this.Time_FromValue_Tbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Time_FromValue_Tbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.Time_FromValue_Tbox, "Time_FromValue_Tbox");
            this.Time_FromValue_Tbox.Name = "Time_FromValue_Tbox";
            // 
            // Time_ToValue_Cbox
            // 
            this.Time_ToValue_Cbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Time_ToValue_Cbox.FormattingEnabled = true;
            this.Time_ToValue_Cbox.Items.AddRange(new object[] {
            resources.GetString("Time_ToValue_Cbox.Items"),
            resources.GetString("Time_ToValue_Cbox.Items1"),
            resources.GetString("Time_ToValue_Cbox.Items2"),
            resources.GetString("Time_ToValue_Cbox.Items3"),
            resources.GetString("Time_ToValue_Cbox.Items4"),
            resources.GetString("Time_ToValue_Cbox.Items5"),
            resources.GetString("Time_ToValue_Cbox.Items6"),
            resources.GetString("Time_ToValue_Cbox.Items7"),
            resources.GetString("Time_ToValue_Cbox.Items8")});
            resources.ApplyResources(this.Time_ToValue_Cbox, "Time_ToValue_Cbox");
            this.Time_ToValue_Cbox.Name = "Time_ToValue_Cbox";
            // 
            // Time_FromValue_Cbox
            // 
            this.Time_FromValue_Cbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Time_FromValue_Cbox.FormattingEnabled = true;
            this.Time_FromValue_Cbox.Items.AddRange(new object[] {
            resources.GetString("Time_FromValue_Cbox.Items"),
            resources.GetString("Time_FromValue_Cbox.Items1"),
            resources.GetString("Time_FromValue_Cbox.Items2"),
            resources.GetString("Time_FromValue_Cbox.Items3"),
            resources.GetString("Time_FromValue_Cbox.Items4"),
            resources.GetString("Time_FromValue_Cbox.Items5"),
            resources.GetString("Time_FromValue_Cbox.Items6"),
            resources.GetString("Time_FromValue_Cbox.Items7"),
            resources.GetString("Time_FromValue_Cbox.Items8")});
            resources.ApplyResources(this.Time_FromValue_Cbox, "Time_FromValue_Cbox");
            this.Time_FromValue_Cbox.Name = "Time_FromValue_Cbox";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Engineer_Calculator.Properties.Resources.Arrow_right_icon;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // Time_Clear_Btn
            // 
            resources.ApplyResources(this.Time_Clear_Btn, "Time_Clear_Btn");
            this.Time_Clear_Btn.Image = global::Engineer_Calculator.Properties.Resources.backspace2;
            this.Time_Clear_Btn.Name = "Time_Clear_Btn";
            this.Time_Clear_Btn.UseVisualStyleBackColor = true;
            // 
            // Time_Convert_Btn
            // 
            resources.ApplyResources(this.Time_Convert_Btn, "Time_Convert_Btn");
            this.Time_Convert_Btn.Image = global::Engineer_Calculator.Properties.Resources.icons8_available_updates_16;
            this.Time_Convert_Btn.Name = "Time_Convert_Btn";
            this.Time_Convert_Btn.UseVisualStyleBackColor = true;
            // 
            // Converter
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Converter";
            this.Opacity = 0.95D;
            this.TemperatureTab.ResumeLayout(false);
            this.TemperatureTab.PerformLayout();
            this.LenthTab.ResumeLayout(false);
            this.LenthTab.PerformLayout();
            this.TimeTab.ResumeLayout(false);
            this.TimeTab.PerformLayout();
            this.SpeedTab.ResumeLayout(false);
            this.SpeedTab.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.AngleTab.ResumeLayout(false);
            this.AngleTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage TemperatureTab;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button Temperature_Clear_Btn;
        private System.Windows.Forms.Button Temperature_Convert_Btn;
        private System.Windows.Forms.TextBox Temperature_ToValue_TBox;
        private System.Windows.Forms.TextBox Temperature_FromValue_TBox;
        private System.Windows.Forms.ComboBox Temperature_ToValue_Cbox;
        private System.Windows.Forms.ComboBox Temperature_FromValue_CBox;
        private System.Windows.Forms.TabPage LenthTab;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Lenth_Clear_Btn;
        private System.Windows.Forms.Button Lenth_Convert_Btn;
        private System.Windows.Forms.TextBox Lenth_ToValue_TBox;
        private System.Windows.Forms.TextBox Lenth_FromValue_TBox;
        private System.Windows.Forms.ComboBox Lenth_ToValue_CBox;
        private System.Windows.Forms.ComboBox Lenth_FromValue_CBox;
        private System.Windows.Forms.TabPage TimeTab;
        private System.Windows.Forms.TabPage SpeedTab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage AngleTab;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button Angle_Clear_Btn;
        private System.Windows.Forms.Button Angle_Convert_Btn;
        private System.Windows.Forms.TextBox Angle_ToValue_TBox;
        private System.Windows.Forms.TextBox Angle_FromValue_TBox;
        private System.Windows.Forms.ComboBox Angle_ToValue_CBox;
        private System.Windows.Forms.ComboBox Angle_FromValue_CBox;
        private System.Windows.Forms.Label Angle_answer_Lable;
        private System.Windows.Forms.Label Time_answer_label;
        private System.Windows.Forms.TextBox Time_ToValue_Tbox;
        private System.Windows.Forms.TextBox Time_FromValue_Tbox;
        private System.Windows.Forms.ComboBox Time_ToValue_Cbox;
        private System.Windows.Forms.ComboBox Time_FromValue_Cbox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Time_Clear_Btn;
        private System.Windows.Forms.Button Time_Convert_Btn;
    }
}