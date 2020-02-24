using System;
using System.Windows.Forms;
using Geometry;

namespace Engineer_Calculator
{

    public partial class Triangle_solving : Form
    {
        delegate void Inp(object sender, KeyEventArgs e);
        

        public Triangle_solving()
        {
            InitializeComponent();
        }

        double a;      //cathet
        double b;      // cathet 
        double hypotinuse;      //Hypotenuse
        double alpha;  //Angle A
        double beta;   // angle beta
        const double PI = Math.PI;


        public void Solve()
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                hypotinuse = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                alpha = Math.Asin(a / hypotinuse) * 180 / PI;
                beta = 90 - alpha;
                textBox3.Text += hypotinuse.ToString(".###");
                textBox4.Text = alpha.ToString(".###");
                textBox5.Text = beta.ToString(".###");
            } // a and b are known (find c)

            else if (textBox1.Text == "" && textBox2.Text != "" && textBox3.Text != "")
            {
                hypotinuse = double.Parse(textBox3.Text);
                b = double.Parse(textBox2.Text);
                a = Math.Sqrt(Math.Pow(hypotinuse, 2) - Math.Pow(b, 2));
                alpha = Math.Asin(a / hypotinuse) * 180 / PI;
                beta = 90 - alpha;
                textBox1.Text += a.ToString(".###");
                textBox4.Text = alpha.ToString(".###");
                textBox5.Text = beta.ToString(".###");
            }// c and b are known (find a)


            else if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text != "")
            {
                a = double.Parse(textBox1.Text);
                hypotinuse = double.Parse(textBox3.Text);
                b = Math.Sqrt(Math.Pow(hypotinuse, 2) - Math.Pow(a, 2));
                alpha = Math.Asin(a / hypotinuse) * 180 / PI;
                beta = 90 - alpha;
                textBox2.Text += b.ToString(".###");
                textBox4.Text = alpha.ToString(".###");
                textBox5.Text = beta.ToString(".###");
            }//a and c are known (find b,alpha,beta)

            else if (textBox1.Text != "" && textBox4.Text != "")
            {
                a = double.Parse(textBox1.Text);
                alpha = double.Parse(textBox4.Text);
                alpha = Math.Sin(alpha * (PI / 180));
                hypotinuse = a / alpha;
                b = Math.Sqrt(Math.Pow(hypotinuse, 2) - Math.Pow(a, 2));
                beta = 90 - double.Parse(textBox4.Text);
                textBox2.Text += b.ToString(".###");
                textBox3.Text += hypotinuse.ToString(".###");
                textBox5.Text = beta.ToString(".###");
            }//a and alpha are known (find b,c)
            else if (textBox1.Text != "" && textBox5.Text != "")
            {
                a = double.Parse(textBox1.Text);
                beta = double.Parse(textBox5.Text);
                beta = Math.Cos(beta * (PI / 180));
                hypotinuse = a / beta;
                b = Math.Sqrt(Math.Pow(hypotinuse, 2) - Math.Pow(a, 2));
                alpha = 90 - double.Parse(textBox5.Text);
                textBox2.Text += b.ToString(".###");
                textBox3.Text += hypotinuse.ToString(".###");
                textBox4.Text += alpha.ToString(".###");

            }// a and beta known (find b,c,alpha)
            else if (textBox2.Text != "" && textBox4.Text != "")
            {
                b = double.Parse(textBox2.Text);
                alpha = double.Parse(textBox4.Text);
                alpha = Math.Cos(alpha * (PI / 180));
                hypotinuse = b / alpha;
                a = Math.Sqrt(Math.Pow(hypotinuse, 2) - Math.Pow(b, 2));
                beta = 90 - double.Parse(textBox4.Text);
                textBox3.Text += hypotinuse.ToString(".###");
                textBox1.Text += a.ToString(".###");
                textBox5.Text += beta.ToString(".###");


            } // b and alpha are known (find a, c, beta)
            else if (textBox2.Text != "" && textBox5.Text != "")
            {
                b = double.Parse(textBox2.Text);
                beta = double.Parse(textBox5.Text);
                beta = Math.Sin(beta * (PI / 180));
                hypotinuse = b / beta;
                a = Math.Sqrt(Math.Pow(hypotinuse, 2) - Math.Pow(b, 2));
                alpha = 90 - double.Parse(textBox5.Text);
                textBox3.Text += hypotinuse.ToString(".###");
                textBox1.Text += a.ToString(".####");
                textBox4.Text += alpha.ToString(".###");

            } // b and beta are known (find a, c, alpha)
            else if (textBox3.Text != "" && textBox4.Text != "")
            {
                hypotinuse = double.Parse(textBox3.Text);
                alpha = Math.Sin(double.Parse(textBox4.Text) * (PI / 180));
                a = alpha * hypotinuse;
                b = Math.Sqrt(Math.Pow(hypotinuse, 2) - Math.Pow(a, 2));
                beta = 90 - double.Parse(textBox4.Text);
                textBox1.Text += a.ToString(".###");
                textBox2.Text += b.ToString(".###");
                textBox5.Text += beta.ToString(".####");

            } //c and alpha are known( Find a, b , beta)
            else if (textBox3.Text != "" && textBox5.Text != "")
            {
                hypotinuse = double.Parse(textBox3.Text);
                beta = double.Parse(textBox5.Text);
                beta = Math.Cos(beta * (PI / 180));
                a = beta * hypotinuse;
                b = Math.Sqrt(Math.Pow(hypotinuse, 2) - Math.Pow(a, 2));
                alpha = 90 - double.Parse(textBox5.Text);
                textBox1.Text += a.ToString(".###");
                textBox2.Text += b.ToString(".###");
                textBox4.Text += alpha.ToString(".###");
            } // c and beta are known (find a, b, alpha)
            textBox6.Text = (hypotinuse / 2).ToString(".###");               //R -Sircumcribe circle
            textBox7.Text = ((a + b - hypotinuse) / 2).ToString(".###");       //r- inscribe circle
        }
       
        public static void Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }// When enter pressed jumps to next control

      
      


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CorrectInput.OnlyNumbers(sender,e);
            Enter(sender, e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            CorrectInput.OnlyNumbers(sender, e);
            Enter(sender, e);
        } 

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            CorrectInput.OnlyNumbers(sender, e);
            Enter(sender, e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            CorrectInput.OnlyNumbers(sender, e);
            Enter(sender, e);

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            CorrectInput.OnlyNumbers(sender, e);
            Enter(sender, e);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Solve();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
            textBox4.Text = ""; textBox5.Text = ""; textBox6.Text = "";
            textBox7.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            bool succes = double.TryParse(textBox4.Text, out alpha);
            if (alpha >= 90)
            {
                MessageBox.Show("Engle alpha should be less then 90°", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Text = "";
                textBox4.SelectAll();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        bool succes = double.TryParse(textBox5.Text, out beta);
            if (beta >= 90)
            {
                MessageBox.Show("Engle beta should be less then 90°", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox5.Text = "";
                textBox5.SelectAll();
            }
        }

        
    }

}
