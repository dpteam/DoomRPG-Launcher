using System;
using System.Windows.Forms;

namespace DoomRPG
{
	public static class Utils
	{
		public static void ShowError(Exception e)
		{
			MessageBox.Show(string.Concat(new object[]
			{
				e.Message,
				"\n\n",
				e.StackTrace,
				"\n\n",
				e.InnerException
			}), "Произошла ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		public static void ShowError(string text, string caption = "Ошибка")
		{
			MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
}
