using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;


//Main class that runs the Form application
class MyApplication {

	public static void Main(){

		Form mForm = new MyMainForm("Testing123", "Eric");
		Application.Run(mForm);

	}


}

//Main Form object 
class MyMainForm : Form {

	String name;
	TextBox textbx1;

    //Main frame object is initialized with text for the title and an arbitrary string passed to it
    public MyMainForm(String titleBarText, String name) {
	
		//Form properies set
		this.Text = titleBarText;
		this.name = name;
		this.Name = "Form Control";
		this.Size = new Size(540, 400);

		//First panel UI element object created with properties set
		Panel panel1 = new Panel();
		panel1.Name = "Panel Control";
		panel1.BackColor = Color.Cyan;
		panel1.Dock = DockStyle.Bottom;

        //Second panel UI element object created with properties set
        Panel panel2 = new Panel();
        panel2.Name = "Panel Control";
        panel2.BackColor = Color.Green;
        panel2.Dock = DockStyle.Fill;

        //First label object is created with properties set
        Label label1 = new Label();
		label1.Size = new Size(400, 80);
        label1.Top = 10;
        label1.Left = 10;
        label1.BorderStyle = BorderStyle.FixedSingle;
		label1.Text = this.name;
		label1.Name = "Label Control";

        //Second label object is created with properties set
        Label label2 = new Label();
        label2.Size = new Size(230, 30);
        label2.Top = 60;
        label2.Left = 20;
        label2.BorderStyle = BorderStyle.FixedSingle;
        label2.Text = "Comment: ";
        label2.Name = "Label Control";

        //First TextBox object is created with properties set
        textbx1 = new TextBox();
        textbx1.Top = 60;
        textbx1.Left = 260;
		textbx1.Width = 125;
        //textbx1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        textbx1.BorderStyle = BorderStyle.FixedSingle;
        textbx1.Text = "Type comment in me!";
        textbx1.Name = "TextBox Control";

        //First button UI element object is created with properties set
        //Event Handler method for click events has been set (see button1_Click() method)
        Button button1 = new Button();
		button1.Name = "Button Control";
		button1.Width = 300;
        button1.Top = 20;
        button1.Left = 20;
        button1.Text = "Show list of all controls";
        button1.Click += new EventHandler(button1_Click);
		
		//Second button UI element object is created with properties set
        //Event Handler method for click events has been set (see button2_Click() method)
		Button button2 = new Button();
		button2.Name = "Button Control";
		button2.Width = 120;
        button2.Top = 200;
        button2.Left = 400;
		// button2.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom);
        button2.Text = "Display Comment";
        button2.Click += new EventHandler(button2_Click);


		//First label ('label1') is set in the first panel ('panel1')
		//First panel ('panel1') and first button ('button1') are set inside form object
		panel1.Controls.Add(label1);
		this.Controls.Add(panel1);
        panel2.Controls.Add(button1);
        panel2.Controls.Add(label2);
        panel2.Controls.Add(textbx1);
		panel2.Controls.Add(button2);
        this.Controls.Add(panel2);
		
		
	}

    //A list of names of all controls in the application (technically, only at a depth of one child)- 
    //will be displayed in the forms bottom panel ('panel1')
    public void button1_Click(object sender, EventArgs e) {

        String controlList = "Control List: " + this.Name + ", ";
        
		foreach(Control c in this.Controls) {
			
			controlList += c.Name + ", ";
			
			foreach(Control p in c.Controls) {
			
				controlList += p.Name + ", ";
			
			}
			
		}
		
        MessageBox.Show(controlList);

    }
	
	//The text that is currently in "textbx1" will be displayed
	public void button2_Click(object sender, EventArgs e) {

        MessageBox.Show(textbx1.Text);

    }
	
	
}

	
