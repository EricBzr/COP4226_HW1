using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyFirstButton
    {
        static void Main(string[] args)
        {
            Form form  = new MyFirstForm("Label Name", "Mehdi");
            
            Application.Run(form);


        }
    }
    class MyFirstForm : Form
    {
        public MyFirstForm(string a, string b)
        {
            this.Text = b;
            this.Size = new Size(600, 400);





            // panel1 Setup
            Panel panel1 = new Panel();
            //panel1.Location = new Point(26, 12);
            panel1.BackColor = Color.FromArgb(150, 150, 150); 
            //panel1.Size = new Size(228, 200);
            panel1.Dock = DockStyle.Bottom;
            this.Controls.Add(panel1);

            // textBox1 Setup
            TextBox textBox1 = new TextBox();
            textBox1.Location = new Point(10, 20);
            textBox1.Text = "I am a TextBox";
            textBox1.Size = new Size(200, 30);

            // checkBox1 Setup
            CheckBox checkBox1 = new CheckBox();
            checkBox1.Location = new Point(10, 50);
            checkBox1.Text = "Check Me";
            checkBox1.Size = new Size(200, 30);

            // label1 Setup
            Label label1 = new Label();
            label1.AutoSize = false;
            label1.Text = a;
            label1.Left = textBox1.Left; // label1's text and TextBox1 alignment
             
            //= System.Windows.Forms.RightToLeft.Yes;

            // pcaking elements onto panel1
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label1);


            Panel panel2 = new Panel();
            //panel2.Location = new Point(26, 12);
            panel2.BackColor = Color.FromArgb(250, 150, 150);
            //panel2.Size = new Size(228, 200);
            panel2.Dock = DockStyle.Fill;
            this.Controls.Add(panel2);

            // label2 Setup
            Label label2 = new Label();
            label2.Top = panel2.Top;
            label2.Left = panel2.Left;
      
            label2.AutoSize = false;
            label2.Text = "Comment";
            

            panel2.Controls.Add(label2);


            // textBox1 Setup
            TextBox textBox2 = new TextBox();
            textBox2.Text = "I am a TextBox";
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Width = 200;

            //textBox2.Left = label2.Right;
            //textBox2.Top = label2.Top;

            panel2.Controls.Add(textBox2);

            Button button = new Button();
            button.Text = "Click Me!";
            panel2.Controls.Add(button);

            button.Left = textBox2.Right;

            button.Click += new EventHandler(button_Click);

       

        void button_Click(object sender, EventArgs e)
                {
                
                    MessageBox.Show("Hello, I am a TextBox");

                }

        }

    }
}
