using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace PokemonTool {
	public class Program {
		static void Main(string[] args) {
			Application.EnableVisualStyles();
			Application.Run(new GuiForm());
		}
	}
}
