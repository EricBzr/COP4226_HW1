using System;
using System.Windows.Forms;
using System.Drawing;

class FirstForm : Form 
{
	string titles;
	string names;
	
	public FirstForm(string title, string name) 
	{
		titles = title;
		names = name;
		this.frame();
	}
	
	public void frame()
	{
		this.Text = titles;
		this.Size = new System.Drawing.Size(350,250);
		this.pnls();
		this.pnls2();
	}
	
	public void pnls()
	{
		Panel pnl = new Panel();
		Label l = new Label();

		l.Text = names;
		pnl.Controls.Add(l);
		
		pnl.BackColor = Color.FromArgb(63, 255, 121);
		pnl.Dock = DockStyle.Bottom;
		
		this.Controls.Add(pnl);
	}
	
	public void pnls2()
	{
		Panel pn2 = new Panel();
		Label l2 = new Label();
		TextBox txt = new TextBox();
		Button button = new Button();
		
		pn2.BackColor = Color.FromArgb(66, 215, 244);
		pn2.Dock = DockStyle.Fill;
		
		l2.Text = "Comment:";
		l2.BackColor = Color.FromArgb(255,255,255);
		l2.Font = new Font("Arial", 10,FontStyle.Bold);
		l2.Location = new Point(20,35);
		pn2.Controls.Add(l2);
		
		int x = l2.Location.X + 200;
		int y = l2.Location.Y; 
		
		txt.Location = new Point(l2.Right + 5, y);
		txt.Anchor = (AnchorStyles.Top| AnchorStyles.Left | AnchorStyles.Right);
		txt.Width = 5;
		pn2.Controls.Add(txt);
			
	
		button.Text = "Click Me!";
		button.Location = new Point(txt.Right + 120, 80 );
		
		button.Click += delegate(object sender2, EventArgs e2)
		{
			button_Click(sender2, e2, txt.Text);
		};
		button.BackColor = Color.FromArgb(255,255,255);
		
		pn2.Controls.Add(button);
		
		this.Controls.Add(pn2);
		
	}	
	
	void button_Click(object sender, EventArgs e, string s)
	{
		MessageBox.Show(s);
	}
}

class Program 
{
	static void Main(string[] args) 
	{
		
		Console.Write("Enter the title: ");
		string title = Console.ReadLine();
		Console.Write("Enter your name: ");
		string name = Console.ReadLine();
		
		Form form = new FirstForm(title, name);

		Application.Run(form);

	}
}

