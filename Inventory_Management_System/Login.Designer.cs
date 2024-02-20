namespace Inventory_Management_System
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
            this.chk_user_showPassword = new System.Windows.Forms.CheckBox();
            this.txt_userUsername = new System.Windows.Forms.TextBox();
            this.txt_userPassword = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_usreLogin = new System.Windows.Forms.Button();
            this.lbl_signup = new System.Windows.Forms.Label();
            this.lbl_infoText = new System.Windows.Forms.Label();
            this.chk_adm_showPassword = new System.Windows.Forms.CheckBox();
            this.btn_admLogin = new System.Windows.Forms.Button();
            this.txt_admPassword = new System.Windows.Forms.TextBox();
            this.txt_admUsername = new System.Windows.Forms.TextBox();
            this.lbl_adminPassword = new System.Windows.Forms.Label();
            this.lbl_adminUsername = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_user_showPassword
            // 
            this.chk_user_showPassword.AutoSize = true;
            this.chk_user_showPassword.Location = new System.Drawing.Point(116, 96);
            this.chk_user_showPassword.Name = "chk_user_showPassword";
            this.chk_user_showPassword.Size = new System.Drawing.Size(104, 17);
            this.chk_user_showPassword.TabIndex = 15;
            this.chk_user_showPassword.Text = "Show Password";
            this.chk_user_showPassword.UseVisualStyleBackColor = true;
            this.chk_user_showPassword.CheckedChanged += new System.EventHandler(this.chk_user_showPassword_CheckedChanged);
            // 
            // txt_userUsername
            // 
            this.txt_userUsername.Location = new System.Drawing.Point(116, 36);
            this.txt_userUsername.Name = "txt_userUsername";
            this.txt_userUsername.Size = new System.Drawing.Size(255, 22);
            this.txt_userUsername.TabIndex = 14;
            // 
            // txt_userPassword
            // 
            this.txt_userPassword.Location = new System.Drawing.Point(116, 68);
            this.txt_userPassword.Name = "txt_userPassword";
            this.txt_userPassword.Size = new System.Drawing.Size(255, 22);
            this.txt_userPassword.TabIndex = 13;
            this.txt_userPassword.UseSystemPasswordChar = true;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(25, 75);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(55, 13);
            this.lbl_password.TabIndex = 12;
            this.lbl_password.Text = "Password";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(23, 43);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(58, 13);
            this.lbl_username.TabIndex = 11;
            this.lbl_username.Text = "Username";
            // 
            // btn_usreLogin
            // 
            this.btn_usreLogin.Location = new System.Drawing.Point(116, 117);
            this.btn_usreLogin.Name = "btn_usreLogin";
            this.btn_usreLogin.Size = new System.Drawing.Size(255, 23);
            this.btn_usreLogin.TabIndex = 4;
            this.btn_usreLogin.Text = "Login";
            this.btn_usreLogin.UseVisualStyleBackColor = true;
            this.btn_usreLogin.Click += new System.EventHandler(this.btn_usreLogin_Click_1);
            // 
            // lbl_signup
            // 
            this.lbl_signup.AutoSize = true;
            this.lbl_signup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signup.Location = new System.Drawing.Point(209, 172);
            this.lbl_signup.Name = "lbl_signup";
            this.lbl_signup.Size = new System.Drawing.Size(50, 15);
            this.lbl_signup.TabIndex = 17;
            this.lbl_signup.Text = "Sign Up";
            this.lbl_signup.Click += new System.EventHandler(this.lbl_signup_Click);
            // 
            // lbl_infoText
            // 
            this.lbl_infoText.AutoSize = true;
            this.lbl_infoText.Location = new System.Drawing.Point(174, 154);
            this.lbl_infoText.Name = "lbl_infoText";
            this.lbl_infoText.Size = new System.Drawing.Size(129, 13);
            this.lbl_infoText.TabIndex = 16;
            this.lbl_infoText.Text = "Don\'t have an  account ?";
            // 
            // chk_adm_showPassword
            // 
            this.chk_adm_showPassword.AutoSize = true;
            this.chk_adm_showPassword.Location = new System.Drawing.Point(115, 78);
            this.chk_adm_showPassword.Name = "chk_adm_showPassword";
            this.chk_adm_showPassword.Size = new System.Drawing.Size(104, 17);
            this.chk_adm_showPassword.TabIndex = 11;
            this.chk_adm_showPassword.Text = "Show Password";
            this.chk_adm_showPassword.UseVisualStyleBackColor = true;
            this.chk_adm_showPassword.CheckedChanged += new System.EventHandler(this.chk_adm_showPassword_CheckedChanged);
            // 
            // btn_admLogin
            // 
            this.btn_admLogin.Location = new System.Drawing.Point(115, 101);
            this.btn_admLogin.Name = "btn_admLogin";
            this.btn_admLogin.Size = new System.Drawing.Size(255, 23);
            this.btn_admLogin.TabIndex = 13;
            this.btn_admLogin.Text = "Login";
            this.btn_admLogin.UseVisualStyleBackColor = true;
            this.btn_admLogin.Click += new System.EventHandler(this.btn_admLogin_Click);
            // 
            // txt_admPassword
            // 
            this.txt_admPassword.Location = new System.Drawing.Point(115, 52);
            this.txt_admPassword.Name = "txt_admPassword";
            this.txt_admPassword.Size = new System.Drawing.Size(255, 22);
            this.txt_admPassword.TabIndex = 12;
            this.txt_admPassword.UseSystemPasswordChar = true;
            // 
            // txt_admUsername
            // 
            this.txt_admUsername.Location = new System.Drawing.Point(115, 19);
            this.txt_admUsername.Name = "txt_admUsername";
            this.txt_admUsername.Size = new System.Drawing.Size(255, 22);
            this.txt_admUsername.TabIndex = 11;
            // 
            // lbl_adminPassword
            // 
            this.lbl_adminPassword.AutoSize = true;
            this.lbl_adminPassword.Location = new System.Drawing.Point(22, 59);
            this.lbl_adminPassword.Name = "lbl_adminPassword";
            this.lbl_adminPassword.Size = new System.Drawing.Size(55, 13);
            this.lbl_adminPassword.TabIndex = 1;
            this.lbl_adminPassword.Text = "Password";
            // 
            // lbl_adminUsername
            // 
            this.lbl_adminUsername.AutoSize = true;
            this.lbl_adminUsername.Location = new System.Drawing.Point(22, 26);
            this.lbl_adminUsername.Name = "lbl_adminUsername";
            this.lbl_adminUsername.Size = new System.Drawing.Size(58, 13);
            this.lbl_adminUsername.TabIndex = 0;
            this.lbl_adminUsername.Text = "Username";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk_adm_showPassword);
            this.groupBox2.Controls.Add(this.btn_admLogin);
            this.groupBox2.Controls.Add(this.txt_admPassword);
            this.groupBox2.Controls.Add(this.txt_admUsername);
            this.groupBox2.Controls.Add(this.lbl_adminPassword);
            this.groupBox2.Controls.Add(this.lbl_adminUsername);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(37, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 155);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "For System Admins";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_user_showPassword);
            this.groupBox1.Controls.Add(this.btn_usreLogin);
            this.groupBox1.Controls.Add(this.txt_userUsername);
            this.groupBox1.Controls.Add(this.txt_userPassword);
            this.groupBox1.Controls.Add(this.lbl_infoText);
            this.groupBox1.Controls.Add(this.lbl_password);
            this.groupBox1.Controls.Add(this.lbl_signup);
            this.groupBox1.Controls.Add(this.lbl_username);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 216);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(509, 456);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_user_showPassword;
        private System.Windows.Forms.TextBox txt_userUsername;
        private System.Windows.Forms.TextBox txt_userPassword;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_usreLogin;
        private System.Windows.Forms.Label lbl_signup;
        private System.Windows.Forms.Label lbl_infoText;
        private System.Windows.Forms.CheckBox chk_adm_showPassword;
        private System.Windows.Forms.Button btn_admLogin;
        private System.Windows.Forms.TextBox txt_admPassword;
        private System.Windows.Forms.TextBox txt_admUsername;
        private System.Windows.Forms.Label lbl_adminPassword;
        private System.Windows.Forms.Label lbl_adminUsername;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}