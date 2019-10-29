using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Hackathon_2019.Classes;

namespace Hackathon_2019
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
			this.Text = ProductName;
		}

		#region FormMain
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FormMain_Load(object sender, EventArgs e)
		{
			ClassDefaults.LoadFormWindowStateFromProperty(this);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
		{

		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
		{

			ClassDefaults.SaveFormWindwoStateToProperty(this);
		}
		#endregion


		#region MainMenu

		//MainMenuFile
		#region MainMenuFile - Events

		private void MainMenuFileOpen_Click(object sender, EventArgs e)
		{

		}

		private void MainMenuFileClose_Click(object sender, EventArgs e)
		{

		}

		private void MainMenuFileSave_Click(object sender, EventArgs e)
		{

		}

		private void MainMenuFileSettings_Click(object sender, EventArgs e)
		{

		}

		private void MainMenuFileExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion

		#endregion

		

	}
}
