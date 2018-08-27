using System;
using System.Windows.Forms;
using System.Drawing;


class Program 
{
	static void Main(string[] args) 
	{
		Console.Write("Enter the title: ");
		string title = Console.ReadLine();
		Console.Write("Enter your name: ");
		string name = Console.ReadLine();
		
		
		prog p = new prog (title, name);
		
		p.execute();
	}
}

class prog
{
	string titles;
	string names;
	
	public prog (string title, string name)
	{
		titles = title;
		names = name;
	}
	
	public void execute()
	{
		Form form = new FirstForm(titles, names);
		Application.Run(form);
	}
	
}

class FirstForm : Form 
{
	public FirstForm(string title, string name) 
	{
		
		this.Text = title;
		this.Size = new System.Drawing.Size(500,500);
		
		Panel pnl = new Panel();
		Label l = new Label();

		l.Text = name;
		pnl.Controls.Add(l);
		
		pnl.BackColor = Color.FromArgb(255, 0, 0);
		pnl.Dock = DockStyle.Bottom;
		
		this.Controls.Add(pnl);
		
		
		
		
		Panel pn2 = new Panel();
		Label l2 = new Label();
		TextBox txt = new TextBox();
		Button button = new Button();
		
		l2.Text = "Comment:";
		l2.Location = new Point(20,100);
		pn2.Controls.Add(l2);
		
		
		txt.Text = "helloo";
		int x = l2.Location.X + 200;
		int y = l2.Location.Y;
		
		txt.Location = new Point(txt.Right + 20, y);
		//txt.Anchor = (AnchorStyles.Top| AnchorStyles.Left | AnchorStyles.Right);
		txt.Width = 200;
		pn2.Controls.Add(txt);
			
		
	
		button.Text = "Click Me!";
		button.Location = new Point(txt.Right, y);
		button.Click += delegate(object sender2, EventArgs e2)
		{
			button_Click(sender2, e2, txt.Text);
		};
		pn2.Controls.Add(button);
		
		
		pn2.BackColor = Color.FromArgb(0, 255, 0);
		pn2.Dock = DockStyle.Fill;
		
		this.Controls.Add(pn2);
	}
	
	void button_Click(object sender, EventArgs e, string s)
	{
		MessageBox.Show(s);
	}
}

