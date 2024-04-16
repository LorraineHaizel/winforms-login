namespace log_in_acc
{
    partial class fb
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fbLabel = new Label();
            emailTxt = new TextBox();
            passwordTxt = new TextBox();
            loginBtn = new Button();
            forgotAcc = new LinkLabel();
            signUpLbl = new LinkLabel();
            emailLbl = new Label();
            passwordLbl = new Label();
            showPass = new CheckBox();
            SuspendLayout();
            // 
            // fbLabel
            // 
            fbLabel.AutoSize = true;
            fbLabel.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fbLabel.ForeColor = Color.Blue;
            fbLabel.Location = new Point(187, 37);
            fbLabel.Name = "fbLabel";
            fbLabel.Size = new Size(208, 59);
            fbLabel.TabIndex = 0;
            fbLabel.Text = "facebook";
            // 
            // emailTxt
            // 
            emailTxt.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTxt.ForeColor = Color.Black;
            emailTxt.Location = new Point(149, 117);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(357, 27);
            emailTxt.TabIndex = 1;
            emailTxt.TextChanged += emailTxt_TextChanged;
            // 
            // passwordTxt
            // 
            passwordTxt.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTxt.ForeColor = Color.Black;
            passwordTxt.Location = new Point(149, 161);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(357, 27);
            passwordTxt.TabIndex = 2;
            passwordTxt.UseSystemPasswordChar = true;
            passwordTxt.TextChanged += passwordTxt_TextChanged;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.DodgerBlue;
            loginBtn.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = SystemColors.Control;
            loginBtn.Location = new Point(61, 225);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(445, 36);
            loginBtn.TabIndex = 3;
            loginBtn.Text = "Log In";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // forgotAcc
            // 
            forgotAcc.ActiveLinkColor = Color.Transparent;
            forgotAcc.AutoSize = true;
            forgotAcc.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forgotAcc.Location = new Point(134, 285);
            forgotAcc.Name = "forgotAcc";
            forgotAcc.Size = new Size(112, 19);
            forgotAcc.TabIndex = 4;
            forgotAcc.TabStop = true;
            forgotAcc.Text = "Forgot account?";
            forgotAcc.LinkClicked += forgotAcc_LinkClicked;
            // 
            // signUpLbl
            // 
            signUpLbl.ActiveLinkColor = Color.Transparent;
            signUpLbl.AutoSize = true;
            signUpLbl.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signUpLbl.Location = new Point(301, 285);
            signUpLbl.Name = "signUpLbl";
            signUpLbl.Size = new Size(143, 19);
            signUpLbl.TabIndex = 5;
            signUpLbl.TabStop = true;
            signUpLbl.Text = "Sign up for Facebook";
            signUpLbl.LinkClicked += signUpLbl_LinkClicked;
            // 
            // emailLbl
            // 
            emailLbl.AutoSize = true;
            emailLbl.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLbl.Location = new Point(71, 123);
            emailLbl.Name = "emailLbl";
            emailLbl.Size = new Size(45, 19);
            emailLbl.TabIndex = 6;
            emailLbl.Text = "Email";
            emailLbl.Click += emailLbl_Click;
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLbl.Location = new Point(71, 164);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(71, 19);
            passwordLbl.TabIndex = 7;
            passwordLbl.Text = "Password";
            // 
            // showPass
            // 
            showPass.AutoSize = true;
            showPass.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showPass.Location = new Point(149, 194);
            showPass.Name = "showPass";
            showPass.Size = new Size(112, 19);
            showPass.TabIndex = 8;
            showPass.Text = "Show Password";
            showPass.UseVisualStyleBackColor = true;
            showPass.CheckedChanged += showPass_CheckedChanged;
            // 
            // fb
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 380);
            Controls.Add(showPass);
            Controls.Add(passwordLbl);
            Controls.Add(emailLbl);
            Controls.Add(signUpLbl);
            Controls.Add(forgotAcc);
            Controls.Add(loginBtn);
            Controls.Add(passwordTxt);
            Controls.Add(emailTxt);
            Controls.Add(fbLabel);
            Name = "fb";
            Text = "Facebook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fbLabel;
        private TextBox emailTxt;
        private TextBox passwordTxt;
        private Button loginBtn;
        private LinkLabel forgotAcc;
        private LinkLabel signUpLbl;
        private Label emailLbl;
        private Label passwordLbl;
        private CheckBox showPass;
    }
}
