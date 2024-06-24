namespace WinFormsIntro
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            LoginButton = new Button();
            label1 = new Label();
            PasswordBox = new TextBox();
            Username = new Label();
            Password = new Label();
            UsernameBox = new TextBox();
            LoggedIn = new Label();
            NotLoggedIn = new Label();
            OrText = new Label();
            CreateUsername = new TextBox();
            label2 = new Label();
            CreateAccountText = new Label();
            CreatePassword = new TextBox();
            label4 = new Label();
            CreateButton = new Button();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            AccountCreatedLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label7 = new Label();
            CreateAccountOptionButton = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(323, 202);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(75, 23);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(346, 184);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(395, 202);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(100, 23);
            PasswordBox.TabIndex = 3;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(232, 169);
            Username.Name = "Username";
            Username.Size = new Size(60, 15);
            Username.TabIndex = 4;
            Username.Text = "Username";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(439, 169);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 5;
            Password.Text = "Password";
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(225, 201);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(100, 23);
            UsernameBox.TabIndex = 7;
            UsernameBox.TextChanged += UsernameBox_TextChanged;
            // 
            // LoggedIn
            // 
            LoggedIn.AutoSize = true;
            LoggedIn.Font = new Font("Segoe UI", 60F);
            LoggedIn.Location = new Point(34, 26);
            LoggedIn.Name = "LoggedIn";
            LoggedIn.Size = new Size(719, 106);
            LoggedIn.TabIndex = 8;
            LoggedIn.Text = "You have logged in";
            // 
            // NotLoggedIn
            // 
            NotLoggedIn.AutoSize = true;
            NotLoggedIn.Location = new Point(255, 364);
            NotLoggedIn.Name = "NotLoggedIn";
            NotLoggedIn.Size = new Size(207, 15);
            NotLoggedIn.TabIndex = 9;
            NotLoggedIn.Text = "Username and Password didn't match";
            // 
            // OrText
            // 
            OrText.Location = new Point(0, 0);
            OrText.Name = "OrText";
            OrText.Size = new Size(100, 23);
            OrText.TabIndex = 19;
            // 
            // CreateUsername
            // 
            CreateUsername.Location = new Point(3, 32);
            CreateUsername.Name = "CreateUsername";
            CreateUsername.Size = new Size(100, 23);
            CreateUsername.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(439, 291);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 15;
            // 
            // CreateAccountText
            // 
            CreateAccountText.AutoSize = true;
            CreateAccountText.Location = new Point(316, 291);
            CreateAccountText.Name = "CreateAccountText";
            CreateAccountText.Size = new Size(89, 15);
            CreateAccountText.TabIndex = 14;
            CreateAccountText.Text = "Create Account";
            // 
            // CreatePassword
            // 
            CreatePassword.Location = new Point(395, 324);
            CreatePassword.Name = "CreatePassword";
            CreatePassword.Size = new Size(100, 23);
            CreatePassword.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(346, 306);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 12;
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(88, 100);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(75, 23);
            CreateButton.TabIndex = 11;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(293, 379);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 60F);
            label5.Location = new Point(-4, 240);
            label5.Name = "label5";
            label5.Size = new Size(0, 106);
            label5.TabIndex = 18;
            // 
            // label6
            // 
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 0;
            // 
            // AccountCreatedLabel
            // 
            AccountCreatedLabel.AutoSize = true;
            AccountCreatedLabel.Location = new Point(316, 391);
            AccountCreatedLabel.Name = "AccountCreatedLabel";
            AccountCreatedLabel.Size = new Size(96, 15);
            AccountCreatedLabel.TabIndex = 20;
            AccountCreatedLabel.Text = "Account Created";
            // 
            // timer1
            // 
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(316, 254);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 21;
            // 
            // CreateAccountOptionButton
            // 
            CreateAccountOptionButton.Location = new Point(312, 228);
            CreateAccountOptionButton.Name = "CreateAccountOptionButton";
            CreateAccountOptionButton.Size = new Size(100, 23);
            CreateAccountOptionButton.TabIndex = 22;
            CreateAccountOptionButton.Text = "Create Account\r\n";
            CreateAccountOptionButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(CreateButton);
            panel1.Controls.Add(CreateUsername);
            panel1.Location = new Point(590, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(203, 160);
            panel1.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 642);
            Controls.Add(NotLoggedIn);
            Controls.Add(CreateAccountOptionButton);
            Controls.Add(label7);
            Controls.Add(AccountCreatedLabel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CreateAccountText);
            Controls.Add(CreatePassword);
            Controls.Add(label4);
            Controls.Add(OrText);
            Controls.Add(LoggedIn);
            Controls.Add(UsernameBox);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(PasswordBox);
            Controls.Add(label1);
            Controls.Add(LoginButton);
            Controls.Add(panel1);
            Name = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private Label label1;
        private TextBox PasswordBox;
        private Label Username;
        private Label Password;
        private TextBox UsernameBox;
        private Label LoggedIn;
        private Label NotLoggedIn;
        private Label OrText;
        private TextBox CreateUsername;
        private Label label2;
        private Label CreateAccountText;
        private TextBox CreatePassword;
        private Label label4;
        private Button CreateButton;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label AccountCreatedLabel;
        private System.Windows.Forms.Timer timer1;
        private Label label7;
        private Button CreateAccountOptionButton;
        private Panel panel1;
    }
}
