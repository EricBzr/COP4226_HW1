// TEAM 4M
// Hairon Martin, Joseph Adams, Jose Mercado, Eric Bazan, Jorge Costafreda, Otto Gonzalez-vega, Mehdi Hajikhani

// REFERENCE
// https://stackoverflow.com/questions/1179532/how-do-i-pass-command-line-arguments-to-a-winforms-application
// https://social.msdn.microsoft.com/Forums/en-US/45941618-c2ed-4306-89fc-45632160e0d2/how-to-check-for-a-certain-objectcontrol-type?forum=csharplanguage
// https://stackoverflow.com/questions/4815629/how-do-i-pass-variables-to-a-buttons-event-method

using System;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

// form class called FirstForm
class FirstForm : Form 
{
	string titles;			  	  // title input from user
	string names; 			 	  // name input from user
	Label labl2 = new Label();	  // create label 2 for panel 1
	
	// constructor for the class
	public FirstForm(string title, string name) 
	{
		titles = title;		// store the title from command lines
		names = name;       // store the name from command lines
		this.frame();  		// execute the frame of the application
	}
	
	// this method executes all the panels and controls the main form
	public void frame()
	{
		this.Text = titles;	 // display the users title
		this.Size = new System.Drawing.Size(350,250);	// resize the form
		this.pnls2();		 // execute panel 2
		this.pnls();		 // execute panel 1
	}
	
	// panel one method
	public void pnls()
	{
		Panel pnl = new Panel();
		Label labl = new Label();		// label one
	
		labl.Text = names;				// get name from user, add it to label one
		
		// adjust location of label 2
		labl2.Location = new Point(labl.Right, 0 );
		
		pnl.Controls.Add(labl2);		// add label 2 to panel	1
		pnl.Controls.Add(labl);			// add labl 1 to panel 1
		pnl.BackColor = Color.FromArgb(63, 255, 121);	// using RGB color palet change the back color
		pnl.Dock = DockStyle.Bottom;	// dock panel to the bottom
		
		this.Controls.Add(pnl);			// add panel to form
	
		this.cont();					// execute the control loop method

	}
	
	// panel 2 of form
	public void pnls2()
	{
		// create new panel, label, textbox, and button
		Panel pn2 = new Panel();
		Label l2 = new Label();
		TextBox txt = new TextBox();
		Button button = new Button();
		
		pn2.BackColor = Color.FromArgb(66, 215, 244);
		pn2.Dock = DockStyle.Fill;
		
		l2.Text = "Comment:";						
		l2.BackColor = Color.FromArgb(255,255,255);		// change label color to white
		l2.Font = new Font("Arial", 10,FontStyle.Bold);	// change the font and font size of the label
		l2.Location = new Point(20,35);					// change the location of the label
		pn2.Controls.Add(l2);							// add it to the panel
		
		// get label x and y coordinates
		int x = l2.Location.X + 200;				
		int y = l2.Location.Y; 
		
		// adjust the location of the txt box next to label
		txt.Location = new Point(l2.Right + 5, y);
		txt.Anchor = (AnchorStyles.Top| AnchorStyles.Left | AnchorStyles.Right);	// anchor the txtbox
		txt.Width = 5;			// adjust width
		pn2.Controls.Add(txt);  // add it to the panel
			
	
		button.Text = "Click Me!";
		button.Location = new Point(txt.Right - 10, txt.Top + 40 );
		button.Anchor = (AnchorStyles.Right | AnchorStyles.Bottom);
		button.BackColor = Color.FromArgb(255,255,255);
		
		// call the click handler method and pass the input from the text box
		button.Click += delegate(object sender2, EventArgs e2)
		{
			button_Click(sender2, e2, txt.Text);
		};
		
		pn2.Controls.Add(button);
		
		this.Controls.Add(pn2);	
		
	}
	
	// this method will get all the controls from the form
	public void cont()
	{
		// get name of the form and store in controlList
		string controlList = "Control List "+ this.GetType().ToString() + ", \r\n";
		
		// loop throught the form and get all controls that have been used
		foreach(Control c in this.Controls) 
		{
			controlList += c.GetType().ToString() + ", \r\n"; // concatenate the string together, add new line
			
			// loop from the parent form to get child controls
			foreach(Control p in c.Controls) 
			{
				controlList += p.GetType().ToString() + ", \r\n";
			}
		}
		
		labl2.AutoSize = false;	
		labl2.Size = new System.Drawing.Size(500, 500);
		labl2.Text = controlList;
		
	}
	
	// button click handler
	public void button_Click(object sender, EventArgs e, string input)
	{
		// display the input from the user
		MessageBox.Show(input);
	}
}

// Main class
class Program 
{
	static void Main(string[] args) 
	{
		// get title and name from command lines
		string title = "";
		string name = "";
		
		for (int i = 0; i < args.Length; i++) 
		{
			title = args[0];   // get first argument and store it title
			name = args[1];    // get second argument and store it in name
		}
		
		// instanciate the form class with the two arguments title and name.
		Form form = new FirstForm(title, name);
		// run application
		Application.Run(form);
	}
}

