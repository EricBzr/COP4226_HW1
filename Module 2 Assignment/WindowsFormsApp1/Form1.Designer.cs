//Reference
//https://www.arclab.com/en/kb/csharp/save-and-restore-position-size-windows-forms-application.html


using System;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Red;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1140, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(395, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(342, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reset Settings";
            this.button1.Click += new System.EventHandler(this.button_Reset);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(774, 154);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(343, 71);
            this.button4.TabIndex = 3;
            this.button4.Text = "Save Location";
            this.button4.Click += new System.EventHandler(this.button_SaveLocation);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(12, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(342, 72);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save Size";
            this.button2.Click += new System.EventHandler(this.button_SaveSize);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(774, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(342, 70);
            this.button3.TabIndex = 2;
            this.button3.Text = "Name";
            this.button3.Click += new System.EventHandler(this.button_ClickName);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(60, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(684, 44);
            this.textBox1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(47, 291);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(983, 326);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1140, 964);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        // Input user names
        private void button_ClickName(object sender, System.EventArgs e)
        {
            Boolean x = true;

            if (this.textBox1.Text.Length == 0)
            {
                MessageBox.Show("Please Enter a Name","Name Validation", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                x = false;
            }
            else if(this.textBox1.Text.Length > 15)
            {
                MessageBox.Show("Length of Name Cannot be Greater than 15 Characters!", "Name Size",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                x = false;
            }
            else
            {
                foreach (char c in this.textBox1.Text)
                {
                    if(c == ' ')
                    {

                        MessageBox.Show("Name Cannot Contain Space Characters!", "Space",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        x = false;
                        break;
                    }
                }        
            }

            if(x)
            {
                //MessageBox.Show(this.textBox1.Text);
                this.listView1.Items.Add(this.textBox1.Text);
                this.textBox1.Clear();
            }
            this.button3.Focus();
            
        }

        // Save the form Size of the user
        private void button_SaveSize(object sender, System.EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.F1Size = Size;
            }
            else
            {
                Properties.Settings.Default.F1Size = RestoreBounds.Size;
            }
            Properties.Settings.Default.Save();

            MessageBox.Show("Form Size Saved");
        }

        // Save the Location of the user
        private void button_SaveLocation(object sender, System.EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.F1Location = Location;
            }
            else
            {
                Properties.Settings.Default.F1Location = RestoreBounds.Location;
            }
            Properties.Settings.Default.Save();

            MessageBox.Show("Form Location Saved");
        }

        // Reset user settings to default
        private void button_Reset(object sender, System.EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(350, 300);
            Properties.Settings.Default.Save();


            MessageBox.Show("Form Setting Reset to Default");
        }

        // Load the new settings
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = Properties.Settings.Default.F1Size;
            this.Location = Properties.Settings.Default.F1Location;
        }


        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private ListView listView1;
    }
}

