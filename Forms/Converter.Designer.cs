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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Lenth_Clear_Btn = new System.Windows.Forms.Button();
            this.Lenth_Convert_Btn = new System.Windows.Forms.Button();
            this.Lenth_ToValue_TBox = new System.Windows.Forms.TextBox();
            this.Lenth_FromValue_TBox = new System.Windows.Forms.TextBox();
            this.Lenth_ToValue_CBox = new System.Windows.Forms.ComboBox();
            this.Lenth_FromValue_CBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.comboBox1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Controls.Add(this.comboBox4);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Engineer_Calculator.Properties.Resources.Arrow_right_icon;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Image = global::Engineer_Calculator.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_edit_clear_locationbar_ltr;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Image = global::Engineer_Calculator.Properties.Resources.Hopstarter_Soft_Scraps_Button_Refresh;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            resources.GetString("comboBox3.Items"),
            resources.GetString("comboBox3.Items1"),
            resources.GetString("comboBox3.Items2"),
            resources.GetString("comboBox3.Items3"),
            resources.GetString("comboBox3.Items4")});
            resources.ApplyResources(this.comboBox3, "comboBox3");
            this.comboBox3.Name = "comboBox3";
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            resources.GetString("comboBox4.Items"),
            resources.GetString("comboBox4.Items1"),
            resources.GetString("comboBox4.Items2"),
            resources.GetString("comboBox4.Items3"),
            resources.GetString("comboBox4.Items4")});
            resources.ApplyResources(this.comboBox4, "comboBox4");
            this.comboBox4.Name = "comboBox4";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Controls.Add(this.Lenth_Clear_Btn);
            this.tabPage3.Controls.Add(this.Lenth_Convert_Btn);
            this.tabPage3.Controls.Add(this.Lenth_ToValue_TBox);
            this.tabPage3.Controls.Add(this.Lenth_FromValue_TBox);
            this.tabPage3.Controls.Add(this.Lenth_ToValue_CBox);
            this.tabPage3.Controls.Add(this.Lenth_FromValue_CBox);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
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
            this.Lenth_Convert_Btn.Click += new System.EventHandler(this.Lenth_Convert_Btn_Click);
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
            this.Lenth_ToValue_CBox.SelectedIndexChanged += new System.EventHandler(this.Lenth_ToValue_CBox_SelectedIndexChanged);
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
            // Converter
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Converter";
            this.Opacity = 0.95D;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Lenth_Clear_Btn;
        private System.Windows.Forms.Button Lenth_Convert_Btn;
        private System.Windows.Forms.TextBox Lenth_ToValue_TBox;
        private System.Windows.Forms.TextBox Lenth_FromValue_TBox;
        private System.Windows.Forms.ComboBox Lenth_ToValue_CBox;
        private System.Windows.Forms.ComboBox Lenth_FromValue_CBox;
    }
}