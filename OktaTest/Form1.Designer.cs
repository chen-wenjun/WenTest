namespace OktaTest
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
            this.userBtn = new System.Windows.Forms.Button();
            this.groupBtn = new System.Windows.Forms.Button();
            this.userApiBtn = new System.Windows.Forms.Button();
            this.addGroupBtn = new System.Windows.Forms.Button();
            this.addUserToGroupBtn = new System.Windows.Forms.Button();
            this.authUser = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.getUsersBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userBtn
            // 
            this.userBtn.Location = new System.Drawing.Point(44, 88);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(144, 23);
            this.userBtn.TabIndex = 0;
            this.userBtn.Text = "User";
            this.userBtn.UseVisualStyleBackColor = true;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // groupBtn
            // 
            this.groupBtn.Location = new System.Drawing.Point(265, 50);
            this.groupBtn.Name = "groupBtn";
            this.groupBtn.Size = new System.Drawing.Size(102, 23);
            this.groupBtn.TabIndex = 1;
            this.groupBtn.Text = "Group";
            this.groupBtn.UseVisualStyleBackColor = true;
            this.groupBtn.Click += new System.EventHandler(this.groupBtn_Click);
            // 
            // userApiBtn
            // 
            this.userApiBtn.Location = new System.Drawing.Point(44, 12);
            this.userApiBtn.Name = "userApiBtn";
            this.userApiBtn.Size = new System.Drawing.Size(144, 23);
            this.userApiBtn.TabIndex = 2;
            this.userApiBtn.Text = "User (API)";
            this.userApiBtn.UseVisualStyleBackColor = true;
            this.userApiBtn.Click += new System.EventHandler(this.userApiBtn_Click);
            // 
            // addGroupBtn
            // 
            this.addGroupBtn.Location = new System.Drawing.Point(265, 88);
            this.addGroupBtn.Name = "addGroupBtn";
            this.addGroupBtn.Size = new System.Drawing.Size(102, 23);
            this.addGroupBtn.TabIndex = 3;
            this.addGroupBtn.Text = "Add Group";
            this.addGroupBtn.UseVisualStyleBackColor = true;
            this.addGroupBtn.Click += new System.EventHandler(this.addGroupBtn_Click);
            // 
            // addUserToGroupBtn
            // 
            this.addUserToGroupBtn.Location = new System.Drawing.Point(44, 172);
            this.addUserToGroupBtn.Name = "addUserToGroupBtn";
            this.addUserToGroupBtn.Size = new System.Drawing.Size(144, 23);
            this.addUserToGroupBtn.TabIndex = 4;
            this.addUserToGroupBtn.Text = "AddUserToGroup";
            this.addUserToGroupBtn.UseVisualStyleBackColor = true;
            this.addUserToGroupBtn.Click += new System.EventHandler(this.addUserToGroupBtn_Click);
            // 
            // authUser
            // 
            this.authUser.Location = new System.Drawing.Point(44, 50);
            this.authUser.Name = "authUser";
            this.authUser.Size = new System.Drawing.Size(144, 23);
            this.authUser.TabIndex = 5;
            this.authUser.Text = "Authenticate User";
            this.authUser.UseVisualStyleBackColor = true;
            this.authUser.Click += new System.EventHandler(this.authUser_Click);
            // 
            // addUserBtn
            // 
            this.addUserBtn.Location = new System.Drawing.Point(44, 117);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(144, 23);
            this.addUserBtn.TabIndex = 6;
            this.addUserBtn.Text = "Add User";
            this.addUserBtn.UseVisualStyleBackColor = true;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // getUsersBtn
            // 
            this.getUsersBtn.Location = new System.Drawing.Point(44, 233);
            this.getUsersBtn.Name = "getUsersBtn";
            this.getUsersBtn.Size = new System.Drawing.Size(144, 23);
            this.getUsersBtn.TabIndex = 7;
            this.getUsersBtn.Text = "Get Users";
            this.getUsersBtn.UseVisualStyleBackColor = true;
            this.getUsersBtn.Click += new System.EventHandler(this.getUsersBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 694);
            this.Controls.Add(this.getUsersBtn);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.authUser);
            this.Controls.Add(this.addUserToGroupBtn);
            this.Controls.Add(this.addGroupBtn);
            this.Controls.Add(this.userApiBtn);
            this.Controls.Add(this.groupBtn);
            this.Controls.Add(this.userBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button groupBtn;
        private System.Windows.Forms.Button userApiBtn;
        private System.Windows.Forms.Button addGroupBtn;
        private System.Windows.Forms.Button addUserToGroupBtn;
        private System.Windows.Forms.Button authUser;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.Button getUsersBtn;
    }
}

