namespace Hackathon_2019
{
	partial class FormMain
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
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.MainMenuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenuFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.MainMenuFileClose = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenuFileSave = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenuFileSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.MainMenuFileSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenuFileSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.MainMenuFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainMenu
			// 
			this.MainMenu.BackColor = System.Drawing.Color.WhiteSmoke;
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuFile});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(800, 24);
			this.MainMenu.TabIndex = 0;
			this.MainMenu.Text = "menuStrip1";
			// 
			// MainMenuFile
			// 
			this.MainMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuFileOpen,
            this.MainMenuFileSeparator1,
            this.MainMenuFileClose,
            this.MainMenuFileSave,
            this.MainMenuFileSeparator2,
            this.MainMenuFileSettings,
            this.MainMenuFileSeparator3,
            this.MainMenuFileExit});
			this.MainMenuFile.Name = "MainMenuFile";
			this.MainMenuFile.Size = new System.Drawing.Size(37, 20);
			this.MainMenuFile.Text = "File";
			// 
			// MainMenuFileOpen
			// 
			this.MainMenuFileOpen.Name = "MainMenuFileOpen";
			this.MainMenuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.MainMenuFileOpen.Size = new System.Drawing.Size(180, 22);
			this.MainMenuFileOpen.Text = "Open";
			this.MainMenuFileOpen.Click += new System.EventHandler(this.MainMenuFileOpen_Click);
			// 
			// MainMenuFileSeparator1
			// 
			this.MainMenuFileSeparator1.Name = "MainMenuFileSeparator1";
			this.MainMenuFileSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// MainMenuFileClose
			// 
			this.MainMenuFileClose.Name = "MainMenuFileClose";
			this.MainMenuFileClose.Size = new System.Drawing.Size(180, 22);
			this.MainMenuFileClose.Text = "Close";
			this.MainMenuFileClose.Click += new System.EventHandler(this.MainMenuFileClose_Click);
			// 
			// MainMenuFileSave
			// 
			this.MainMenuFileSave.Name = "MainMenuFileSave";
			this.MainMenuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.MainMenuFileSave.Size = new System.Drawing.Size(180, 22);
			this.MainMenuFileSave.Text = "Save";
			this.MainMenuFileSave.Click += new System.EventHandler(this.MainMenuFileSave_Click);
			// 
			// MainMenuFileSeparator2
			// 
			this.MainMenuFileSeparator2.Name = "MainMenuFileSeparator2";
			this.MainMenuFileSeparator2.Size = new System.Drawing.Size(177, 6);
			// 
			// MainMenuFileSettings
			// 
			this.MainMenuFileSettings.Name = "MainMenuFileSettings";
			this.MainMenuFileSettings.Size = new System.Drawing.Size(180, 22);
			this.MainMenuFileSettings.Text = "Settings";
			this.MainMenuFileSettings.Click += new System.EventHandler(this.MainMenuFileSettings_Click);
			// 
			// MainMenuFileSeparator3
			// 
			this.MainMenuFileSeparator3.Name = "MainMenuFileSeparator3";
			this.MainMenuFileSeparator3.Size = new System.Drawing.Size(177, 6);
			// 
			// MainMenuFileExit
			// 
			this.MainMenuFileExit.Name = "MainMenuFileExit";
			this.MainMenuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.MainMenuFileExit.Size = new System.Drawing.Size(180, 22);
			this.MainMenuFileExit.Text = "Exit";
			this.MainMenuFileExit.Click += new System.EventHandler(this.MainMenuFileExit_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.MainMenu);
			this.MainMenuStrip = this.MainMenu;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormMain";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip MainMenu;
		private System.Windows.Forms.ToolStripMenuItem MainMenuFile;
		private System.Windows.Forms.ToolStripMenuItem MainMenuFileOpen;
		private System.Windows.Forms.ToolStripSeparator MainMenuFileSeparator1;
		private System.Windows.Forms.ToolStripMenuItem MainMenuFileClose;
		private System.Windows.Forms.ToolStripMenuItem MainMenuFileSave;
		private System.Windows.Forms.ToolStripSeparator MainMenuFileSeparator2;
		private System.Windows.Forms.ToolStripMenuItem MainMenuFileSettings;
		private System.Windows.Forms.ToolStripSeparator MainMenuFileSeparator3;
		private System.Windows.Forms.ToolStripMenuItem MainMenuFileExit;
	}
}