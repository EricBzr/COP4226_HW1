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
    Label label1;

    //Main frame object is initialized with text for the title and an arbitrary string passed to it
    public MyMainForm(String titleBarText, String name) {
	
		//Form properies set
		this.Text = titleBarText;
		this.name = name;
		this.Name = "Form Control";
		this.Size = new Size(500, 500);

		//First panel UI element object created with properties set
		Panel panel1 = new Panel();
		panel1.Name = "Panel Control";
		panel1.BackColor = Color.Cyan;
		panel1.Dock = DockStyle.Bottom;

		//First label object is created with text property set
		label1 = new Label();
		label1.Size = new Size(500, 500);
		label1.Text = this.name;
		label1.Name = "Label Control";
		
		//First button UI element object is created with properties set
		//Event Handler method for click events has been set (see button1_Click() method)
		Button button1 = new Button();
		button1.Name = "Button Control";
		button1.Width = 300;
        button1.Text = "Show list of all controls";
        button1.Click += new EventHandler(button1_Click);


		//First label ('label1') is set in the first panel ('panel1')
		//First panel ('panel1') and first button ('button1') are set inside form object
		panel1.Controls.Add(label1);
		this.Controls.Add(panel1);
		this.Controls.Add(button1);
		
	}

	//A list of names of all controls in the application will be displayed in the forms bottom panel ('panel1')
    public void button1_Click(object sender, EventArgs e) {

        String controlList = "Control List: " + this.Name + ", ";
        
		foreach(Control c in this.Controls) {
			
			controlList += c.Name + ", ";
			
			foreach(Control p in c.Controls) {
			
				controlList += p.Name + ", ";
			
			}
			
		}
		
        label1.Text = controlList;

    }
}

	
