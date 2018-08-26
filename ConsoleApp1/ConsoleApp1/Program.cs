using System;
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
            Form form  = new MyFirstForm();
            Application.Run(form);


        }
    }
    class MyFirstForm : Form
    {
        public MyFirstForm()
        {
            this.Text = "Hello, FinWorms!";
            Button button = new Button();
            button.Text = "Click Me!";
            this.Controls.Add(button);

        }

    }
}
