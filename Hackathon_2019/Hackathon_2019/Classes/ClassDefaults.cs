using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon_2019.Classes
{
	public static class ClassDefaults
	{
		public static void SaveFormWindwoStateToProperty(Form frm)
		{
			Properties.Settings.Default.FormMaximized = frm.WindowState == FormWindowState.Maximized;
			Properties.Settings.Default.Save();
		}

		public static void LoadFormWindowStateFromProperty(Form frm)
		{
			frm.WindowState = Properties.Settings.Default.FormMaximized ? FormWindowState.Maximized : FormWindowState.Normal;
		}

	}
}
