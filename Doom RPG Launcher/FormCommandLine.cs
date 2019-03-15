using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DoomRPG
{
	public partial class FormCommandLine : Form
	{
		public FormCommandLine(string commandLine)
		{
			this.InitializeComponent();
			this.textBoxCommandLine.Text = commandLine;
			this.textBoxCommandLine.Select(commandLine.Length, 0);
		}
	}
}
