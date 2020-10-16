namespace WindowsFormsApp1
{
    partial class fm_hello_world
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
            this.btnUnPwd = new System.Windows.Forms.Button();
            this.btnClientId = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblClientId = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblAuthentication = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUnPwd
            // 
            this.btnUnPwd.Location = new System.Drawing.Point(16, 388);
            this.btnUnPwd.Name = "btnUnPwd";
            this.btnUnPwd.Size = new System.Drawing.Size(344, 52);
            this.btnUnPwd.TabIndex = 0;
            this.btnUnPwd.Text = "Username and Password";
            this.btnUnPwd.UseVisualStyleBackColor = true;
            this.btnUnPwd.Click += new System.EventHandler(this.btnUnPwd_Click);
            // 
            // btnClientId
            // 
            this.btnClientId.Location = new System.Drawing.Point(16, 313);
            this.btnClientId.Name = "btnClientId";
            this.btnClientId.Size = new System.Drawing.Size(344, 52);
            this.btnClientId.TabIndex = 1;
            this.btnClientId.Text = "Client Id and Secret";
            this.btnClientId.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(16, 160);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(146, 26);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "arjun@a-um.me";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 122);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(239, 122);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(243, 160);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(146, 26);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "P@ssw0rd4aum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Client Secret";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(243, 262);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 26);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "P@ssw0rd4aum";
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(12, 224);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(67, 20);
            this.lblClientId.TabIndex = 7;
            this.lblClientId.Text = "Client Id";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(16, 262);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(146, 26);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "arjun@a-um.me";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(12, 18);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(42, 20);
            this.lblURL.TabIndex = 11;
            this.lblURL.Text = "URL";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(16, 54);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(698, 26);
            this.txtURL.TabIndex = 10;
            this.txtURL.Text = "https://aumonline.sharepoint.com/sites/Dev";
            // 
            // lblAuthentication
            // 
            this.lblAuthentication.AutoSize = true;
            this.lblAuthentication.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblAuthentication.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAuthentication.Location = new System.Drawing.Point(530, 166);
            this.lblAuthentication.Name = "lblAuthentication";
            this.lblAuthentication.Size = new System.Drawing.Size(12, 20);
            this.lblAuthentication.TabIndex = 12;
            this.lblAuthentication.Text = "l";
            // 
            // fm_hello_world
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAuthentication);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblClientId);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnClientId);
            this.Controls.Add(this.btnUnPwd);
            this.Name = "fm_hello_world";
            this.Text = "fm_hello_world";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnPwd;
        private System.Windows.Forms.Button btnClientId;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblAuthentication;
    }
}