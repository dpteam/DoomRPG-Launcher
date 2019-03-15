namespace DoomRPG
{
	public partial class FormLoadOrder : global::System.Windows.Forms.Form
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
			this.tableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.buttonOK = new global::System.Windows.Forms.Button();
			this.listViewLoadOrder = new global::System.Windows.Forms.ListView();
			this.columnHeaderMod = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeaderN = new global::System.Windows.Forms.ColumnHeader();
			this.tableLayoutPanel1.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.Controls.Add(this.buttonCancel, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.buttonOK, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.listViewLoadOrder, 0, 0);
			this.tableLayoutPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new global::System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 20f));
			this.tableLayoutPanel1.Size = new global::System.Drawing.Size(734, 832);
			this.tableLayoutPanel1.TabIndex = 0;
			this.buttonCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.buttonCancel.AutoSize = true;
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new global::System.Drawing.Point(3, 791);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(102, 38);
			this.buttonCancel.TabIndex = 0;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonOK.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.buttonOK.AutoSize = true;
			this.buttonOK.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new global::System.Drawing.Point(629, 791);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new global::System.Drawing.Size(102, 38);
			this.buttonOK.TabIndex = 1;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new global::System.EventHandler(this.ButtonOK_Click);
			this.listViewLoadOrder.AllowDrop = true;
			this.listViewLoadOrder.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeaderMod,
				this.columnHeaderN
			});
			this.tableLayoutPanel1.SetColumnSpan(this.listViewLoadOrder, 2);
			this.listViewLoadOrder.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listViewLoadOrder.FullRowSelect = true;
			this.listViewLoadOrder.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listViewLoadOrder.LabelWrap = false;
			this.listViewLoadOrder.Location = new global::System.Drawing.Point(3, 3);
			this.listViewLoadOrder.Name = "listViewLoadOrder";
			this.listViewLoadOrder.ShowGroups = false;
			this.listViewLoadOrder.Size = new global::System.Drawing.Size(728, 782);
			this.listViewLoadOrder.TabIndex = 2;
			this.listViewLoadOrder.UseCompatibleStateImageBehavior = false;
			this.listViewLoadOrder.View = global::System.Windows.Forms.View.List;
			this.columnHeaderMod.Text = "Mod";
			this.columnHeaderMod.Width = -1;
			this.columnHeaderN.Text = "N";
			this.columnHeaderN.Width = -2;
			base.AcceptButton = this.buttonOK;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(12f, 25f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new global::System.Drawing.Size(734, 832);
			base.ControlBox = false;
			base.Controls.Add(this.tableLayoutPanel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.Name = "FormLoadOrder";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Load Order";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			base.ResumeLayout(false);
		}

		private global::System.ComponentModel.IContainer components = null;

		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		private global::System.Windows.Forms.Button buttonCancel;

		private global::System.Windows.Forms.Button buttonOK;

		private global::System.Windows.Forms.ListView listViewLoadOrder;

		private global::System.Windows.Forms.ColumnHeader columnHeaderMod;

		private global::System.Windows.Forms.ColumnHeader columnHeaderN;
	}
}
