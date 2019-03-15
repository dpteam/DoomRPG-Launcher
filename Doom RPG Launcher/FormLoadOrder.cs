using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DoomRPG
{
	public partial class FormLoadOrder : Form
	{
		public FormLoadOrder(List<string> mods)
		{
			this.InitializeComponent();
			this.listViewLoadOrder.MouseDown += this.ListViewLoadOrder_MouseDown;
			this.listViewLoadOrder.DragOver += this.ListViewLoadOrder_DragOver;
			this.listViewLoadOrder.DragDrop += this.ListViewLoadOrder_DragDrop;
			foreach (string text in mods)
			{
				this.listViewLoadOrder.Items.Add(text);
			}
			this.listViewLoadOrder.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
		}

		private void ListViewLoadOrder_DragDrop(object sender, DragEventArgs e)
		{
			ListViewItem[] array = e.Data.GetData(typeof(ListViewItem[])) as ListViewItem[];
			Point point = this.listViewLoadOrder.PointToClient(new Point(e.X, e.Y));
			ListViewItem itemAt = this.listViewLoadOrder.GetItemAt(point.X, point.Y);
			foreach (ListViewItem item in array)
			{
				this.listViewLoadOrder.Items.Remove(item);
				this.listViewLoadOrder.Items.Insert((itemAt != null) ? itemAt.Index : this.listViewLoadOrder.Items.Count, item);
			}
		}

		private void ListViewLoadOrder_DragOver(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Move;
		}

		private void ListViewLoadOrder_MouseDown(object sender, MouseEventArgs e)
		{
			ListViewItem itemAt = this.listViewLoadOrder.GetItemAt(e.Location.X, e.Location.Y);
			if (this.listViewLoadOrder.SelectedItems.Count != 0 && itemAt != null && this.listViewLoadOrder.SelectedItems.Contains(itemAt))
			{
				this.listViewLoadOrder.DoDragDrop(this.listViewLoadOrder.SelectedItems.Cast<ListViewItem>().ToArray<ListViewItem>(), DragDropEffects.Move);
			}
		}

		private void ButtonOK_Click(object sender, EventArgs e)
		{
			this.LoadOrder = new List<string>(this.listViewLoadOrder.Items.Count);
			foreach (object obj in this.listViewLoadOrder.Items)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				this.LoadOrder.Add(listViewItem.Text);
			}
		}

		public List<string> LoadOrder;
	}
}
