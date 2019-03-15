namespace DoomRPG
{
	public partial class FormCommandLine : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.textBoxCommandLine = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.textBoxCommandLine.BackColor = global::System.Drawing.SystemColors.Window;
			this.textBoxCommandLine.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.textBoxCommandLine.Location = new global::System.Drawing.Point(0, 0);
			this.textBoxCommandLine.Multiline = true;
			this.textBoxCommandLine.Name = "textBoxCommandLine";
			this.textBoxCommandLine.ReadOnly = true;
			this.textBoxCommandLine.Size = new global::System.Drawing.Size(800, 450);
			this.textBoxCommandLine.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(12f, 25f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.Controls.Add(this.textBoxCommandLine);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormCommandLine";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Command line arguments";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.TextBox textBoxCommandLine;
	}
}
