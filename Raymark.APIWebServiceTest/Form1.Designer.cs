namespace Raymark.APIWebServiceTest
{
	partial class Form1
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
			this.button1 = new System.Windows.Forms.Button();
			this.clientIdTBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.urlTBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(89, 81);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(278, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Test GetClientEmailAddressesForPOS";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// clientIdTBox
			// 
			this.clientIdTBox.Location = new System.Drawing.Point(89, 40);
			this.clientIdTBox.Name = "clientIdTBox";
			this.clientIdTBox.Size = new System.Drawing.Size(236, 22);
			this.clientIdTBox.TabIndex = 1;
			this.clientIdTBox.Text = "0000002934948";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Client ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "URL";
			// 
			// urlTBox
			// 
			this.urlTBox.Location = new System.Drawing.Point(89, 12);
			this.urlTBox.Name = "urlTBox";
			this.urlTBox.Size = new System.Drawing.Size(538, 22);
			this.urlTBox.TabIndex = 3;
			this.urlTBox.Text = "http://10.130.166.227:10001//CCA1APIWS/ClientWebService.asmx";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(639, 144);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.urlTBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.clientIdTBox);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "APIWebServiceTestForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox clientIdTBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox urlTBox;
	}
}

