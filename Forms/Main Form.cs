using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engineer_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void triangleSolvingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Triangle_solving triangle_Solving = new Triangle_solving();
            triangle_Solving.ShowDialog();
        } //tringle solver open form

        private void ezTrackManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo(@"D:\Engineer Calculator\Resources\Ez Treck Manual.pdf");
            Process.Start(processStartInfo);
        } //Open Ez Track Manual

        private void programmingManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo process = new ProcessStartInfo(@"D:\Engineer Calculator\Resources\Programming Manual.pdf");
            Process.Start(process);
        }// Siemens Programming manual

        private void operatorManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo process = new ProcessStartInfo(@"D:\Engineer Calculator\Resources\Operate User Guide.pdf");
            Process.Start(process);
        }// Siemens Operator manual

        private void basicFunctionsToolStripMenuItem_Click(object sender, EventArgs e)// Siemens Basic Functions
        {
            ProcessStartInfo process = new ProcessStartInfo(@"D:\Engineer Calculator\Resources\Basic Functions.pdf");
            Process.Start(process);
        }

        private void cNCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var process = new ProcessStartInfo(@"D:\Engineer Calculator\Resources\Fundamentals_of_CNC_Machining.pdf");
            Process.Start(process);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Converter converter = new Converter();
            converter.ShowDialog();
        }
    }
}
