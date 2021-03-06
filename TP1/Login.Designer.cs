
namespace TP1
{
    partial class Login
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
            this.lb_username = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(18, 105);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(55, 13);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "Username";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(106, 102);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(203, 20);
            this.tb_username.TabIndex = 1;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(106, 128);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(203, 20);
            this.tb_password.TabIndex = 3;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(18, 131);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(53, 13);
            this.lb_password.TabIndex = 2;
            this.lb_password.Text = "Password";
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(226, 154);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(83, 36);
            this.bt_login.TabIndex = 4;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_loginPress);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 241);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lb_username);
            this.MaximumSize = new System.Drawing.Size(329, 241);
            this.MinimumSize = new System.Drawing.Size(329, 241);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Button bt_login;
    }
}