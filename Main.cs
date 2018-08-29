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

