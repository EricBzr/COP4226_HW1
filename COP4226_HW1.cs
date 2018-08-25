using System;
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

	//Main frame object is initialized with text for the title and an arbitrary string passed to it
	public MyMainForm(String titleBarText, String name) {
	
	
		//Form properies set
		this.Text = titleBarText;
		this.name = name;
		this.Size = new Size(500, 500);

		//First panel UI element object created with properties set
		Panel panel1 = new Panel();
		panel1.BackColor = Color.Cyan;
		panel1.Dock = DockStyle.Bottom;

		//First label object is created with text property set
		Label label1 = new Label();
		label1.Text = this.name;

		//First label ('label1') is set in the first panel (panel1)
		//First panel is set inside form object
		panel1.Controls.Add(label1);
		this.Controls.Add(panel1);
		
	}
}

	
