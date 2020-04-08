namespace Engineer_Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleSolvingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.formulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ezTrackManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siemensManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmingManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operatorManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicFunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cNCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.formulasToolStripMenuItem,
            this.manualToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.triangleSolvingToolStripMenuItem,
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(41, 29);
            this.toolStripMenuItem1.Text = "☰";
            // 
            // triangleSolvingToolStripMenuItem
            // 
            this.triangleSolvingToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.triangleSolvingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("triangleSolvingToolStripMenuItem.Image")));
            this.triangleSolvingToolStripMenuItem.Name = "triangleSolvingToolStripMenuItem";
            this.triangleSolvingToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.triangleSolvingToolStripMenuItem.Text = "Triangle solving";
            this.triangleSolvingToolStripMenuItem.Click += new System.EventHandler(this.triangleSolvingToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(179, 22);
            this.toolStripMenuItem2.Text = "Unit Converter";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // formulasToolStripMenuItem
            // 
            this.formulasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.threadsToolStripMenuItem});
            this.formulasToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formulasToolStripMenuItem.Name = "formulasToolStripMenuItem";
            this.formulasToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.formulasToolStripMenuItem.Text = "Reference";
            // 
            // threadsToolStripMenuItem
            // 
            this.threadsToolStripMenuItem.Name = "threadsToolStripMenuItem";
            this.threadsToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.threadsToolStripMenuItem.Text = "Thread";
            this.threadsToolStripMenuItem.Click += new System.EventHandler(this.threadsToolStripMenuItem_Click);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ezTrackManualToolStripMenuItem,
            this.siemensManualToolStripMenuItem,
            this.cNCToolStripMenuItem});
            this.manualToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.manualToolStripMenuItem.Text = "Manual";
            // 
            // ezTrackManualToolStripMenuItem
            // 
            this.ezTrackManualToolStripMenuItem.Name = "ezTrackManualToolStripMenuItem";
            this.ezTrackManualToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.ezTrackManualToolStripMenuItem.Text = "Ez Track manual";
            this.ezTrackManualToolStripMenuItem.Click += new System.EventHandler(this.ezTrackManualToolStripMenuItem_Click);
            // 
            // siemensManualToolStripMenuItem
            // 
            this.siemensManualToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmingManualToolStripMenuItem,
            this.operatorManualToolStripMenuItem,
            this.basicFunctionsToolStripMenuItem});
            this.siemensManualToolStripMenuItem.Image = global::Engineer_Calculator.Properties.Resources.siemens_logo;
            this.siemensManualToolStripMenuItem.Name = "siemensManualToolStripMenuItem";
            this.siemensManualToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.siemensManualToolStripMenuItem.Text = "Siemens Manual";
            // 
            // programmingManualToolStripMenuItem
            // 
            this.programmingManualToolStripMenuItem.Name = "programmingManualToolStripMenuItem";
            this.programmingManualToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.programmingManualToolStripMenuItem.Text = "Programming Manual";
            this.programmingManualToolStripMenuItem.Click += new System.EventHandler(this.programmingManualToolStripMenuItem_Click);
            // 
            // operatorManualToolStripMenuItem
            // 
            this.operatorManualToolStripMenuItem.Name = "operatorManualToolStripMenuItem";
            this.operatorManualToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.operatorManualToolStripMenuItem.Text = "Operator Manual";
            this.operatorManualToolStripMenuItem.Click += new System.EventHandler(this.operatorManualToolStripMenuItem_Click);
            // 
            // basicFunctionsToolStripMenuItem
            // 
            this.basicFunctionsToolStripMenuItem.Name = "basicFunctionsToolStripMenuItem";
            this.basicFunctionsToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.basicFunctionsToolStripMenuItem.Text = "Basic Functions";
            this.basicFunctionsToolStripMenuItem.Click += new System.EventHandler(this.basicFunctionsToolStripMenuItem_Click);
            // 
            // cNCToolStripMenuItem
            // 
            this.cNCToolStripMenuItem.Name = "cNCToolStripMenuItem";
            this.cNCToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.cNCToolStripMenuItem.Text = "CNC Fundamentals";
            this.cNCToolStripMenuItem.Click += new System.EventHandler(this.cNCToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Engineer Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem triangleSolvingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ezTrackManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siemensManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmingManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operatorManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicFunctionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cNCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem threadsToolStripMenuItem;
    }
}

