using System;
using System.Windows.Forms;
using System.Drawing;


class Assignment1
{
    static void Main(string[] args)
    {
        String title = "";
        String name = "";

        if (args.Length >= 1)
            name = args[0];
        if (args.Length >= 2)
            title = args[1];

        MyForm f = new MyForm(title, name);

        Application.Run(f);
    }

}

public class MyForm : Form
{
    private String yourName;
    private String title;

    public MyForm(String title, String yourName)
    {
        //Cmd line initialization
        this.yourName = yourName;
        this.Text = title;

        //Set main form size
        this.Size = new Size(512, 256);

        //bottom docked panel
        Panel bottomPanel = new Panel();
        bottomPanel.Dock = DockStyle.Bottom;
        bottomPanel.BackColor = Color.FromName("DarkSlateGray");                

        //label for showing name
        Label nameLabel = new Label();
        nameLabel.Text = (yourName == null) ? "null" : yourName;
        bottomPanel.Controls.Add(nameLabel);        

        //label for showing controls
        Label controlInfoLabel = new Label();
        //String all_controls = getAllNamesControl();
        //Console.WriteLine(getAllNamesControl());
        //controlInfoLabel.Text = getAllNamesControl();
        controlInfoLabel.Size = new System.Drawing.Size(200,256);
        controlInfoLabel.Anchor = (AnchorStyles.Right) | (AnchorStyles.Top);
        bottomPanel.Controls.Add(controlInfoLabel);

        //filled panel (top panel of the main form)
        Panel filledPanel = new Panel();
        filledPanel.Dock = DockStyle.Fill;
        filledPanel.BackColor = System.Drawing.Color.Lime;

        //comment label
        Label commentInfoLabel = new Label();
        commentInfoLabel.Text = "Comment: ";
        commentInfoLabel.Width = 60;
        commentInfoLabel.Location = new System.Drawing.Point(10, 10);
        commentInfoLabel.Anchor = AnchorStyles.Left | AnchorStyles.Top;
        filledPanel.Controls.Add(commentInfoLabel);

        //text box
        TextBox textBox = new TextBox();
        textBox.Width = 100;
        textBox.Location = new System.Drawing.Point(90, 10);
        textBox.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
        filledPanel.Controls.Add(textBox);

        //button
        Button button = new Button();
        button.Text = "Click me!";
        button.Location = new System.Drawing.Point(112, 46);
        button.Anchor = (AnchorStyles.Right | AnchorStyles.Top);
        filledPanel.Controls.Add(button);

        button.Click += delegate (object sender2, EventArgs e2)
        {
            button_Click(sender2, e2, textBox.Text);
        };

        //add panels to main form
        this.Controls.Add(bottomPanel);
        this.Controls.Add(filledPanel);
        controlInfoLabel.Text = getAllNamesControl(); //load with information of added controls.        
    }

    private void button_Click(object sender, EventArgs e, String commentInfo)
    {
        MessageBox.Show(commentInfo);
    }

    //**Got this method from assignment 1 submission
    //get all the names that are part of the controller
    private string getAllNamesControl()
    {
        // get name of the form and store in controlList
        string controlList = "Control List " + this.GetType().ToString() + ":\r\n";
        // loop throught the form and get all controls that have been used
        foreach (Control c in this.Controls)
        {            
            controlList += "   " + c.GetType().ToString() + "\r\n"; // concatenate the string together, add new line

            // loop from the parent form to get child controls
            foreach (Control p in c.Controls)
            {
                controlList += "      " + p.GetType().ToString() + "\r\n";
            }
        }

        Console.WriteLine(controlList);

        return controlList;
    }

    //helper function
    private static void print(object o) { Console.WriteLine(o.ToString());}
}

