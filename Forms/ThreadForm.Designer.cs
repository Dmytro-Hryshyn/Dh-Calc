namespace Engineer_Calculator.Forms
{
    partial class ThreadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThreadForm));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Thread_SideMenu_Panel = new System.Windows.Forms.Panel();
            this.Drill_Size_Btn = new System.Windows.Forms.Button();
            this.DrillSize_SubMenu_Panel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ChildForm_Panel = new System.Windows.Forms.Panel();
            this.Thread_SideMenu_Panel.SuspendLayout();
            this.DrillSize_SubMenu_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Thread_SideMenu_Panel
            // 
            this.Thread_SideMenu_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Thread_SideMenu_Panel.Controls.Add(this.DrillSize_SubMenu_Panel);
            this.Thread_SideMenu_Panel.Controls.Add(this.Drill_Size_Btn);
            this.Thread_SideMenu_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Thread_SideMenu_Panel.Location = new System.Drawing.Point(0, 0);
            this.Thread_SideMenu_Panel.Name = "Thread_SideMenu_Panel";
            this.Thread_SideMenu_Panel.Size = new System.Drawing.Size(250, 561);
            this.Thread_SideMenu_Panel.TabIndex = 0;
            // 
            // Drill_Size_Btn
            // 
            this.Drill_Size_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Drill_Size_Btn.FlatAppearance.BorderSize = 0;
            this.Drill_Size_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Drill_Size_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drill_Size_Btn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Drill_Size_Btn.Location = new System.Drawing.Point(0, 83);
            this.Drill_Size_Btn.Name = "Drill_Size_Btn";
            this.Drill_Size_Btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Drill_Size_Btn.Size = new System.Drawing.Size(247, 58);
            this.Drill_Size_Btn.TabIndex = 1;
            this.Drill_Size_Btn.Text = "Drill size";
            this.Drill_Size_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Drill_Size_Btn.UseVisualStyleBackColor = false;
            // 
            // DrillSize_SubMenu_Panel
            // 
            this.DrillSize_SubMenu_Panel.Controls.Add(this.button4);
            this.DrillSize_SubMenu_Panel.Controls.Add(this.button3);
            this.DrillSize_SubMenu_Panel.Controls.Add(this.button2);
            this.DrillSize_SubMenu_Panel.Location = new System.Drawing.Point(0, 147);
            this.DrillSize_SubMenu_Panel.Name = "DrillSize_SubMenu_Panel";
            this.DrillSize_SubMenu_Panel.Size = new System.Drawing.Size(247, 174);
            this.DrillSize_SubMenu_Panel.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(247, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "Normal Tap";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(0, 58);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(247, 58);
            this.button3.TabIndex = 3;
            this.button3.Text = "Flutless Tap";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(0, 116);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(247, 58);
            this.button4.TabIndex = 4;
            this.button4.Text = "Helicoils Tap";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // ChildForm_Panel
            // 
            this.ChildForm_Panel.Location = new System.Drawing.Point(253, 0);
            this.ChildForm_Panel.Name = "ChildForm_Panel";
            this.ChildForm_Panel.Size = new System.Drawing.Size(528, 561);
            this.ChildForm_Panel.TabIndex = 1;
            // 
            // ThreadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ChildForm_Panel);
            this.Controls.Add(this.Thread_SideMenu_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThreadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thread";
            this.Load += new System.EventHandler(this.ThreadForm_Load);
            this.Thread_SideMenu_Panel.ResumeLayout(false);
            this.DrillSize_SubMenu_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel Thread_SideMenu_Panel;
        private System.Windows.Forms.Panel DrillSize_SubMenu_Panel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Drill_Size_Btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel ChildForm_Panel;
    }
}