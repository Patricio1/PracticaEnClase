using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using MsdnMag;


namespace TestMsgBox
{
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button ButtonTest;
		private System.Windows.Forms.Button btnYesAllNoCancel;
		private MsdnMag.MessageBox msg;

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ButtonTest = new System.Windows.Forms.Button();
			this.btnYesAllNoCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ButtonTest
			// 
			this.ButtonTest.Location = new System.Drawing.Point(16, 16);
			this.ButtonTest.Name = "ButtonTest";
			this.ButtonTest.Size = new System.Drawing.Size(312, 24);
			this.ButtonTest.TabIndex = 0;
			this.ButtonTest.Text = "Test MsdnMag.MessageBox";
			this.ButtonTest.Click += new System.EventHandler(this.ButtonTest_Click);
			// 
			// btnYesAllNoCancel
			// 
			this.btnYesAllNoCancel.Location = new System.Drawing.Point(16, 48);
			this.btnYesAllNoCancel.Name = "btnYesAllNoCancel";
			this.btnYesAllNoCancel.Size = new System.Drawing.Size(312, 24);
			this.btnYesAllNoCancel.TabIndex = 1;
			this.btnYesAllNoCancel.Text = "Test Yes-All-No-Cancel";
			this.btnYesAllNoCancel.Click += new System.EventHandler(this.btnYesAllNoCancel_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(344, 93);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnYesAllNoCancel,
																		  this.ButtonTest});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Testing MessageBox";
			this.ResumeLayout(false);

		}
		#endregion


		public Form1()
		{
			InitializeComponent();
			msg = new MsdnMag.MessageBox();
		}
		

		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		
		
		private void ButtonTest_Click(object sender, System.EventArgs e)
		{
			msg.IconFile = "shell32.dll";
			msg.IconIndex = 41;
			msg.YesAllNoCancel = false;

			DialogResult dr = msg.Show("Hello, managed world!", "Cutting Edge",
				MessageBoxButtons.OK); 

			Console.WriteLine(dr.ToString());
		}

		private void btnYesAllNoCancel_Click(object sender, System.EventArgs e)
		{
			msg.IconFile = "shell32.dll";
			msg.IconIndex = 41;
			msg.YesAllNoCancel = true;

			DialogResult dr = msg.Show("Hello, managed world!", "Cutting Edge"); 
			Console.WriteLine(dr.ToString());
		}
	}
}
