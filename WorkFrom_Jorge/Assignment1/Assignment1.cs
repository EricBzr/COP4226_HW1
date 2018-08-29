using System;
using System.Windows.Forms;
using System.Drawing;


class Assignment1
{
    static void Main(string[] args)
    {
        String DEFAULT_TITLE = "Windows Forms!";
        String NAME = "Jorge";
        MyForm f = new MyForm(DEFAULT_TITLE, NAME);

        Application.Run(f);
    }

}


public class MyForm : Form
{
    String yourName;

    public MyForm(String title, String yourName)
    {
        setTitle(title);
        this.Size = new Size(512, 256);
        this.yourName = yourName;

        Panel panel = new Panel();
        Color colorCyan = Color.FromName("DarkSlateGray");
        panel.BackColor = colorCyan;
        panel.Dock = DockStyle.Bottom;



        Label label = new Label();
        label.Text = yourName;
        panel.Controls.Add(label);

        this.Controls.Add(panel);
        //panel.BackColor = new System.Drawing.Color()

    }

    private void setTitle(String title)
    {
        this.Text = title;
    }

}

