// REFERENCE
// https://stackoverflow.com/questions/1179532/how-do-i-pass-command-line-arguments-to-a-winforms-application
//https://social.msdn.microsoft.com/Forums/en-US/45941618-c2ed-4306-89fc-45632160e0d2/how-to-check-for-a-certain-objectcontrol-type?forum=csharplanguage

using System;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

class FirstForm : Form 
{
	string titles;
	string names;
	Label l2 = new Label();
	
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
		this.pnls2();
		this.pnls();
	}
	
	public void pnls()
	{
		Panel pnl = new Panel();
		Label l = new Label();
		
		
		l.Text = names;
		
		l2.Location = new Point(l.Right, 0 );
		pnl.Controls.Add(l2);
		pnl.Controls.Add(l);
		
		pnl.BackColor = Color.FromArgb(63, 255, 121);
		pnl.Dock = DockStyle.Bottom;
		
		this.Controls.Add(pnl);
	
		this.cont();

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
		button.Anchor = (AnchorStyles.Left );
		
		button.Click += delegate(object sender2, EventArgs e2)
		{
			button_Click(sender2, e2, txt.Text);
		};
		button.BackColor = Color.FromArgb(255,255,255);
		
		pn2.Controls.Add(button);
		
		this.Controls.Add(pn2);
		
	}
	
	public void cont()
	{
		string controlList = "Control List "+ this.GetType().ToString() + ", \r\n";
		
		foreach(Control c in this.Controls) 
		{
			controlList += c.GetType().ToString() + ", \r\n";
			
			foreach(Control p in c.Controls) {
			
				controlList += p.GetType().ToString() + ", \r\n";
			
			}
			
		}
		
		//Console.WriteLine(controlList);
		l2.AutoSize = false;
		l2.Size = new System.Drawing.Size(500, 500);
		l2.Text = controlList;
		
	}

	
	public void button_Click(object sender, EventArgs e, string s)
	{
		MessageBox.Show(s);
	}
}

class Program 
{
	static void Main(string[] args) 
	{
		string title = "";
		string name = "";
		
		for (int i = 0; i < args.Length; i++) 
		{
			title = args[0];
			name = args[1];
		}
		
		Form form = new FirstForm(title, name);

		Application.Run(form);

	}
}

