namespace WindowsFormsApplication1
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
			this.timerBtn = new System.Windows.Forms.Button();
			this.watcherBtn = new System.Windows.Forms.Button();
			this.timer2Btn = new System.Windows.Forms.Button();
			this.checkUserIdentityTBox = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// timerBtn
			// 
			this.timerBtn.Location = new System.Drawing.Point(58, 111);
			this.timerBtn.Name = "timerBtn";
			this.timerBtn.Size = new System.Drawing.Size(136, 23);
			this.timerBtn.TabIndex = 0;
			this.timerBtn.Text = "Timer Test";
			this.timerBtn.UseVisualStyleBackColor = true;
			this.timerBtn.Click += new System.EventHandler(this.timerBtn_Click);
			// 
			// watcherBtn
			// 
			this.watcherBtn.Location = new System.Drawing.Point(58, 39);
			this.watcherBtn.Name = "watcherBtn";
			this.watcherBtn.Size = new System.Drawing.Size(136, 23);
			this.watcherBtn.TabIndex = 1;
			this.watcherBtn.Text = "Watcher Test";
			this.watcherBtn.UseVisualStyleBackColor = true;
			this.watcherBtn.Click += new System.EventHandler(this.watcherBtn_Click);
			// 
			// timer2Btn
			// 
			this.timer2Btn.Location = new System.Drawing.Point(58, 164);
			this.timer2Btn.Name = "timer2Btn";
			this.timer2Btn.Size = new System.Drawing.Size(136, 23);
			this.timer2Btn.TabIndex = 2;
			this.timer2Btn.Text = "Timer2 Test";
			this.timer2Btn.UseVisualStyleBackColor = true;
			this.timer2Btn.Click += new System.EventHandler(this.timer2Btn_Click);
			// 
			// checkUserIdentityTBox
			// 
			this.checkUserIdentityTBox.Location = new System.Drawing.Point(58, 217);
			this.checkUserIdentityTBox.Name = "checkUserIdentityTBox";
			this.checkUserIdentityTBox.Size = new System.Drawing.Size(178, 23);
			this.checkUserIdentityTBox.TabIndex = 3;
			this.checkUserIdentityTBox.Text = "Check User Identity";
			this.checkUserIdentityTBox.UseVisualStyleBackColor = true;
			this.checkUserIdentityTBox.Click += new System.EventHandler(this.checkUserIdentityTBox_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(282, 299);
			this.Controls.Add(this.checkUserIdentityTBox);
			this.Controls.Add(this.timer2Btn);
			this.Controls.Add(this.watcherBtn);
			this.Controls.Add(this.timerBtn);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button timerBtn;
		private System.Windows.Forms.Button watcherBtn;
		private System.Windows.Forms.Button timer2Btn;
		private System.Windows.Forms.Button checkUserIdentityTBox;
	}
}

