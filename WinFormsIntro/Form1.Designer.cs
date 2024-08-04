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
            OrText = new Label();
            CreateUsername2 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            CreateButton = new Button();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            AccountCreatedLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            CreateAccountPanel = new Panel();
            DepositAmountText = new Label();
            DepositMoneyBox = new TextBox();
            ReturnToLoginButtonOption = new Button();
            PasswordButton2 = new Label();
            UsernameButton2 = new Label();
            CreatePassword2 = new TextBox();
            StartPageLoginPanel = new Panel();
            label1 = new Label();
            label8 = new Label();
            CreateAccountOptionButton = new Button();
            LoginButton = new Button();
            NotLoggedIn = new Label();
            label15 = new Label();
            label10 = new Label();
            PasswordBox = new TextBox();
            label11 = new Label();
            UsernameText = new Label();
            PasswordText = new Label();
            UsernameBox = new TextBox();
            LoggedInPanel = new Panel();
            TransferButton = new Button();
            WithdrawButton = new Button();
            DepositButton = new Button();
            label7 = new Label();
            CheckBalanceButton = new Button();
            LoggedIn = new Label();
            CheckBalancePanel = new Panel();
            ReturnToOptionsButton = new Button();
            DollarsText = new Label();
            CurrentBalanceNumberText = new Label();
            CurrentBalanceText = new Label();
            DepositPanel = new Panel();
            ErrorTryAgainText2 = new Label();
            MoneyDepositedSuccessfullyText = new Label();
            DepositButtonConfirm = new Button();
            ReturnToOptionsButton2 = new Button();
            DepositAmountBox = new TextBox();
            EnterDepositAmountText = new Label();
            WithdrawPanel = new Panel();
            ErrorTryAgainText = new Label();
            MoneyWithdrawSuccessfullText = new Label();
            ReturnToOptionsButton3 = new Button();
            WithdrawAmountButton = new Button();
            WithdrawAmountBox = new TextBox();
            EnterWithdrawAmountText = new Label();
            TransferPanel = new Panel();
            toText = new Label();
            ErrorTryAgainText3 = new Label();
            ReturnToOptionsButton4 = new Button();
            TransferAmountButton = new Button();
            TransferSuccessfullText = new Label();
            TransferAmountBox = new TextBox();
            TransferAmountText = new Label();
            SecondAccountText = new Label();
            FirstAccountText = new Label();
            SecondAccountPassword = new TextBox();
            SecondAccountUsername = new TextBox();
            label9 = new Label();
            FirstAccountPassword = new TextBox();
            TransferExample = new Label();
            TransferExample2 = new Label();
            FirstAccountUsername = new TextBox();
            LogoutButton = new Button();
            CreateAccountPanel.SuspendLayout();
            StartPageLoginPanel.SuspendLayout();
            LoggedInPanel.SuspendLayout();
            CheckBalancePanel.SuspendLayout();
            DepositPanel.SuspendLayout();
            WithdrawPanel.SuspendLayout();
            TransferPanel.SuspendLayout();
            SuspendLayout();
            // 
            // OrText
            // 
            OrText.Location = new Point(0, 0);
            OrText.Name = "OrText";
            OrText.Size = new Size(100, 23);
            OrText.TabIndex = 19;
            // 
            // CreateUsername2
            // 
            CreateUsername2.Location = new Point(74, 88);
            CreateUsername2.Name = "CreateUsername2";
            CreateUsername2.Size = new Size(100, 23);
            CreateUsername2.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(439, 291);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 15;
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
            CreateButton.Location = new Point(172, 153);
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
            AccountCreatedLabel.Location = new Point(160, 205);
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
            // CreateAccountPanel
            // 
            CreateAccountPanel.Controls.Add(DepositAmountText);
            CreateAccountPanel.Controls.Add(DepositMoneyBox);
            CreateAccountPanel.Controls.Add(ReturnToLoginButtonOption);
            CreateAccountPanel.Controls.Add(PasswordButton2);
            CreateAccountPanel.Controls.Add(UsernameButton2);
            CreateAccountPanel.Controls.Add(CreatePassword2);
            CreateAccountPanel.Controls.Add(AccountCreatedLabel);
            CreateAccountPanel.Controls.Add(CreateButton);
            CreateAccountPanel.Controls.Add(CreateUsername2);
            CreateAccountPanel.Location = new Point(456, 46);
            CreateAccountPanel.Name = "CreateAccountPanel";
            CreateAccountPanel.Size = new Size(415, 305);
            CreateAccountPanel.TabIndex = 23;
            // 
            // DepositAmountText
            // 
            DepositAmountText.AutoSize = true;
            DepositAmountText.Location = new Point(163, 113);
            DepositAmountText.Name = "DepositAmountText";
            DepositAmountText.Size = new Size(94, 15);
            DepositAmountText.TabIndex = 28;
            DepositAmountText.Text = "Deposit Amount";
            // 
            // DepositMoneyBox
            // 
            DepositMoneyBox.Location = new Point(172, 131);
            DepositMoneyBox.Name = "DepositMoneyBox";
            DepositMoneyBox.Size = new Size(75, 23);
            DepositMoneyBox.TabIndex = 27;
            // 
            // ReturnToLoginButtonOption
            // 
            ReturnToLoginButtonOption.Location = new Point(153, 232);
            ReturnToLoginButtonOption.Name = "ReturnToLoginButtonOption";
            ReturnToLoginButtonOption.Size = new Size(111, 23);
            ReturnToLoginButtonOption.TabIndex = 26;
            ReturnToLoginButtonOption.Text = "Return To Login";
            ReturnToLoginButtonOption.UseVisualStyleBackColor = true;
            ReturnToLoginButtonOption.Click += ReturnToLoginButtonOption_Click;
            // 
            // PasswordButton2
            // 
            PasswordButton2.AutoSize = true;
            PasswordButton2.Location = new Point(288, 55);
            PasswordButton2.Name = "PasswordButton2";
            PasswordButton2.Size = new Size(57, 15);
            PasswordButton2.TabIndex = 25;
            PasswordButton2.Text = "Password";
            // 
            // UsernameButton2
            // 
            UsernameButton2.AutoSize = true;
            UsernameButton2.Location = new Point(74, 55);
            UsernameButton2.Name = "UsernameButton2";
            UsernameButton2.Size = new Size(60, 15);
            UsernameButton2.TabIndex = 24;
            UsernameButton2.Text = "Username";
            // 
            // CreatePassword2
            // 
            CreatePassword2.Location = new Point(245, 88);
            CreatePassword2.Name = "CreatePassword2";
            CreatePassword2.Size = new Size(100, 23);
            CreatePassword2.TabIndex = 17;
            // 
            // StartPageLoginPanel
            // 
            StartPageLoginPanel.Controls.Add(label1);
            StartPageLoginPanel.Controls.Add(label8);
            StartPageLoginPanel.Controls.Add(CreateAccountOptionButton);
            StartPageLoginPanel.Controls.Add(LoginButton);
            StartPageLoginPanel.Controls.Add(NotLoggedIn);
            StartPageLoginPanel.Controls.Add(label15);
            StartPageLoginPanel.Controls.Add(label10);
            StartPageLoginPanel.Controls.Add(PasswordBox);
            StartPageLoginPanel.Controls.Add(label11);
            StartPageLoginPanel.Controls.Add(UsernameText);
            StartPageLoginPanel.Controls.Add(PasswordText);
            StartPageLoginPanel.Controls.Add(UsernameBox);
            StartPageLoginPanel.Location = new Point(35, 18);
            StartPageLoginPanel.Name = "StartPageLoginPanel";
            StartPageLoginPanel.Size = new Size(415, 303);
            StartPageLoginPanel.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 43);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 39;
            label1.Text = "Welcome To Marcus Bank";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(198, 159);
            label8.Name = "label8";
            label8.Size = new Size(20, 15);
            label8.TabIndex = 38;
            label8.Text = "Or";
            // 
            // CreateAccountOptionButton
            // 
            CreateAccountOptionButton.Location = new Point(151, 173);
            CreateAccountOptionButton.Name = "CreateAccountOptionButton";
            CreateAccountOptionButton.Size = new Size(117, 23);
            CreateAccountOptionButton.TabIndex = 37;
            CreateAccountOptionButton.Text = "Create Account";
            CreateAccountOptionButton.UseVisualStyleBackColor = true;
            CreateAccountOptionButton.Click += CreateAccountOptionButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(172, 129);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(75, 23);
            LoginButton.TabIndex = 27;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click_1;
            // 
            // NotLoggedIn
            // 
            NotLoggedIn.AutoSize = true;
            NotLoggedIn.Location = new Point(99, 203);
            NotLoggedIn.Name = "NotLoggedIn";
            NotLoggedIn.Size = new Size(207, 15);
            NotLoggedIn.TabIndex = 34;
            NotLoggedIn.Text = "Username and Password didn't match";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(195, 111);
            label15.Name = "label15";
            label15.Size = new Size(0, 15);
            label15.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(165, 181);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 36;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(244, 129);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(100, 23);
            PasswordBox.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(288, 218);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 35;
            // 
            // UsernameText
            // 
            UsernameText.AutoSize = true;
            UsernameText.Location = new Point(81, 96);
            UsernameText.Name = "UsernameText";
            UsernameText.Size = new Size(60, 15);
            UsernameText.TabIndex = 30;
            UsernameText.Text = "Username";
            // 
            // PasswordText
            // 
            PasswordText.AutoSize = true;
            PasswordText.Location = new Point(288, 96);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(57, 15);
            PasswordText.TabIndex = 31;
            PasswordText.Text = "Password";
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(74, 128);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(100, 23);
            UsernameBox.TabIndex = 32;
            // 
            // LoggedInPanel
            // 
            LoggedInPanel.BackColor = Color.Transparent;
            LoggedInPanel.Controls.Add(LogoutButton);
            LoggedInPanel.Controls.Add(TransferButton);
            LoggedInPanel.Controls.Add(WithdrawButton);
            LoggedInPanel.Controls.Add(DepositButton);
            LoggedInPanel.Controls.Add(label7);
            LoggedInPanel.Controls.Add(CheckBalanceButton);
            LoggedInPanel.Controls.Add(LoggedIn);
            LoggedInPanel.Location = new Point(24, 327);
            LoggedInPanel.Name = "LoggedInPanel";
            LoggedInPanel.Size = new Size(415, 306);
            LoggedInPanel.TabIndex = 27;
            // 
            // TransferButton
            // 
            TransferButton.Location = new Point(257, 176);
            TransferButton.Name = "TransferButton";
            TransferButton.Size = new Size(75, 23);
            TransferButton.TabIndex = 38;
            TransferButton.Text = "Transfer";
            TransferButton.UseVisualStyleBackColor = true;
            TransferButton.Click += TransferButton_Click;
            // 
            // WithdrawButton
            // 
            WithdrawButton.Location = new Point(179, 176);
            WithdrawButton.Name = "WithdrawButton";
            WithdrawButton.Size = new Size(75, 23);
            WithdrawButton.TabIndex = 37;
            WithdrawButton.Text = "Withdraw";
            WithdrawButton.UseVisualStyleBackColor = true;
            WithdrawButton.Click += WithdrawButton_Click;
            // 
            // DepositButton
            // 
            DepositButton.Location = new Point(103, 176);
            DepositButton.Name = "DepositButton";
            DepositButton.Size = new Size(75, 23);
            DepositButton.TabIndex = 36;
            DepositButton.Text = "Deposit";
            DepositButton.UseVisualStyleBackColor = true;
            DepositButton.Click += DepositButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 13F);
            label7.Location = new Point(140, 56);
            label7.Name = "label7";
            label7.Size = new Size(131, 25);
            label7.TabIndex = 35;
            label7.Text = "Pick An Option";
            // 
            // CheckBalanceButton
            // 
            CheckBalanceButton.Location = new Point(2, 176);
            CheckBalanceButton.Name = "CheckBalanceButton";
            CheckBalanceButton.Size = new Size(100, 23);
            CheckBalanceButton.TabIndex = 34;
            CheckBalanceButton.Text = "Check Balance";
            CheckBalanceButton.UseVisualStyleBackColor = true;
            CheckBalanceButton.Click += CheckBalanceButton_Click;
            // 
            // LoggedIn
            // 
            LoggedIn.AutoSize = true;
            LoggedIn.BackColor = Color.Transparent;
            LoggedIn.Font = new Font("Segoe UI", 13F);
            LoggedIn.Location = new Point(63, 31);
            LoggedIn.Name = "LoggedIn";
            LoggedIn.Size = new Size(282, 25);
            LoggedIn.TabIndex = 33;
            LoggedIn.Text = "Welcome to your account account";
            // 
            // CheckBalancePanel
            // 
            CheckBalancePanel.BackColor = Color.Transparent;
            CheckBalancePanel.Controls.Add(ReturnToOptionsButton);
            CheckBalancePanel.Controls.Add(DollarsText);
            CheckBalancePanel.Controls.Add(CurrentBalanceNumberText);
            CheckBalancePanel.Controls.Add(CurrentBalanceText);
            CheckBalancePanel.Location = new Point(445, 383);
            CheckBalancePanel.Name = "CheckBalancePanel";
            CheckBalancePanel.Size = new Size(415, 305);
            CheckBalancePanel.TabIndex = 39;
            // 
            // ReturnToOptionsButton
            // 
            ReturnToOptionsButton.Location = new Point(145, 187);
            ReturnToOptionsButton.Name = "ReturnToOptionsButton";
            ReturnToOptionsButton.Size = new Size(111, 23);
            ReturnToOptionsButton.TabIndex = 29;
            ReturnToOptionsButton.Text = "Return To Options";
            ReturnToOptionsButton.UseVisualStyleBackColor = true;
            ReturnToOptionsButton.Click += ReturnToOptionsButton_Click;
            // 
            // DollarsText
            // 
            DollarsText.AutoSize = true;
            DollarsText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            DollarsText.Location = new Point(165, 131);
            DollarsText.Name = "DollarsText";
            DollarsText.Size = new Size(64, 21);
            DollarsText.TabIndex = 2;
            DollarsText.Text = "Dollars";
            // 
            // CurrentBalanceNumberText
            // 
            CurrentBalanceNumberText.AutoSize = true;
            CurrentBalanceNumberText.Font = new Font("Segoe UI", 12F);
            CurrentBalanceNumberText.Location = new Point(154, 93);
            CurrentBalanceNumberText.Name = "CurrentBalanceNumberText";
            CurrentBalanceNumberText.Size = new Size(19, 21);
            CurrentBalanceNumberText.TabIndex = 1;
            CurrentBalanceNumberText.Text = "$";
            // 
            // CurrentBalanceText
            // 
            CurrentBalanceText.AutoSize = true;
            CurrentBalanceText.Font = new Font("Segoe UI", 12F);
            CurrentBalanceText.Location = new Point(141, 49);
            CurrentBalanceText.Name = "CurrentBalanceText";
            CurrentBalanceText.Size = new Size(123, 21);
            CurrentBalanceText.TabIndex = 0;
            CurrentBalanceText.Text = "Current Balance:";
            // 
            // DepositPanel
            // 
            DepositPanel.BackColor = Color.Transparent;
            DepositPanel.Controls.Add(ErrorTryAgainText2);
            DepositPanel.Controls.Add(MoneyDepositedSuccessfullyText);
            DepositPanel.Controls.Add(DepositButtonConfirm);
            DepositPanel.Controls.Add(ReturnToOptionsButton2);
            DepositPanel.Controls.Add(DepositAmountBox);
            DepositPanel.Controls.Add(EnterDepositAmountText);
            DepositPanel.Location = new Point(877, 46);
            DepositPanel.Name = "DepositPanel";
            DepositPanel.Size = new Size(415, 305);
            DepositPanel.TabIndex = 40;
            // 
            // ErrorTryAgainText2
            // 
            ErrorTryAgainText2.AutoSize = true;
            ErrorTryAgainText2.Location = new Point(158, 211);
            ErrorTryAgainText2.Name = "ErrorTryAgainText2";
            ErrorTryAgainText2.Size = new Size(87, 15);
            ErrorTryAgainText2.TabIndex = 43;
            ErrorTryAgainText2.Text = "Error Try Again.";
            // 
            // MoneyDepositedSuccessfullyText
            // 
            MoneyDepositedSuccessfullyText.AutoSize = true;
            MoneyDepositedSuccessfullyText.Location = new Point(119, 211);
            MoneyDepositedSuccessfullyText.Name = "MoneyDepositedSuccessfullyText";
            MoneyDepositedSuccessfullyText.Size = new Size(170, 15);
            MoneyDepositedSuccessfullyText.TabIndex = 40;
            MoneyDepositedSuccessfullyText.Text = "Money Deposited Successfully!";
            // 
            // DepositButtonConfirm
            // 
            DepositButtonConfirm.Location = new Point(164, 137);
            DepositButtonConfirm.Name = "DepositButtonConfirm";
            DepositButtonConfirm.Size = new Size(75, 23);
            DepositButtonConfirm.TabIndex = 39;
            DepositButtonConfirm.Text = "Deposit";
            DepositButtonConfirm.UseVisualStyleBackColor = true;
            DepositButtonConfirm.Click += DepositButtonConfirm_Click;
            // 
            // ReturnToOptionsButton2
            // 
            ReturnToOptionsButton2.Location = new Point(145, 173);
            ReturnToOptionsButton2.Name = "ReturnToOptionsButton2";
            ReturnToOptionsButton2.Size = new Size(112, 23);
            ReturnToOptionsButton2.TabIndex = 30;
            ReturnToOptionsButton2.Text = "Return To Options";
            ReturnToOptionsButton2.UseVisualStyleBackColor = true;
            ReturnToOptionsButton2.Click += ReturnToOptionsButton2_Click;
            // 
            // DepositAmountBox
            // 
            DepositAmountBox.Location = new Point(151, 98);
            DepositAmountBox.Name = "DepositAmountBox";
            DepositAmountBox.Size = new Size(100, 23);
            DepositAmountBox.TabIndex = 29;
            // 
            // EnterDepositAmountText
            // 
            EnterDepositAmountText.AutoSize = true;
            EnterDepositAmountText.Font = new Font("Segoe UI", 12F);
            EnterDepositAmountText.Location = new Point(123, 52);
            EnterDepositAmountText.Name = "EnterDepositAmountText";
            EnterDepositAmountText.Size = new Size(163, 21);
            EnterDepositAmountText.TabIndex = 30;
            EnterDepositAmountText.Text = "Enter Deposit Amount";
            // 
            // WithdrawPanel
            // 
            WithdrawPanel.Controls.Add(ErrorTryAgainText);
            WithdrawPanel.Controls.Add(MoneyWithdrawSuccessfullText);
            WithdrawPanel.Controls.Add(ReturnToOptionsButton3);
            WithdrawPanel.Controls.Add(WithdrawAmountButton);
            WithdrawPanel.Controls.Add(WithdrawAmountBox);
            WithdrawPanel.Controls.Add(EnterWithdrawAmountText);
            WithdrawPanel.Location = new Point(866, 388);
            WithdrawPanel.Name = "WithdrawPanel";
            WithdrawPanel.Size = new Size(415, 305);
            WithdrawPanel.TabIndex = 41;
            // 
            // ErrorTryAgainText
            // 
            ErrorTryAgainText.AutoSize = true;
            ErrorTryAgainText.Location = new Point(155, 192);
            ErrorTryAgainText.Name = "ErrorTryAgainText";
            ErrorTryAgainText.Size = new Size(87, 15);
            ErrorTryAgainText.TabIndex = 42;
            ErrorTryAgainText.Text = "Error Try Again.";
            // 
            // MoneyWithdrawSuccessfullText
            // 
            MoneyWithdrawSuccessfullText.AutoSize = true;
            MoneyWithdrawSuccessfullText.Location = new Point(116, 209);
            MoneyWithdrawSuccessfullText.Name = "MoneyWithdrawSuccessfullText";
            MoneyWithdrawSuccessfullText.Size = new Size(162, 15);
            MoneyWithdrawSuccessfullText.TabIndex = 41;
            MoneyWithdrawSuccessfullText.Text = "Money Withdraw Successfull!";
            // 
            // ReturnToOptionsButton3
            // 
            ReturnToOptionsButton3.Location = new Point(142, 165);
            ReturnToOptionsButton3.Name = "ReturnToOptionsButton3";
            ReturnToOptionsButton3.Size = new Size(112, 23);
            ReturnToOptionsButton3.TabIndex = 41;
            ReturnToOptionsButton3.Text = "Return To Options";
            ReturnToOptionsButton3.UseVisualStyleBackColor = true;
            ReturnToOptionsButton3.Click += ReturnToOptionsButton3_Click;
            // 
            // WithdrawAmountButton
            // 
            WithdrawAmountButton.Location = new Point(160, 136);
            WithdrawAmountButton.Name = "WithdrawAmountButton";
            WithdrawAmountButton.Size = new Size(75, 23);
            WithdrawAmountButton.TabIndex = 41;
            WithdrawAmountButton.Text = "Withdraw";
            WithdrawAmountButton.UseVisualStyleBackColor = true;
            WithdrawAmountButton.Click += WithdrawAmountButton_Click;
            // 
            // WithdrawAmountBox
            // 
            WithdrawAmountBox.Location = new Point(147, 94);
            WithdrawAmountBox.Name = "WithdrawAmountBox";
            WithdrawAmountBox.Size = new Size(100, 23);
            WithdrawAmountBox.TabIndex = 41;
            // 
            // EnterWithdrawAmountText
            // 
            EnterWithdrawAmountText.AutoSize = true;
            EnterWithdrawAmountText.Font = new Font("Segoe UI", 12F);
            EnterWithdrawAmountText.Location = new Point(116, 46);
            EnterWithdrawAmountText.Name = "EnterWithdrawAmountText";
            EnterWithdrawAmountText.Size = new Size(178, 21);
            EnterWithdrawAmountText.TabIndex = 41;
            EnterWithdrawAmountText.Text = "Enter Withdraw Amount";
            // 
            // TransferPanel
            // 
            TransferPanel.Controls.Add(toText);
            TransferPanel.Controls.Add(ErrorTryAgainText3);
            TransferPanel.Controls.Add(ReturnToOptionsButton4);
            TransferPanel.Controls.Add(TransferAmountButton);
            TransferPanel.Controls.Add(TransferSuccessfullText);
            TransferPanel.Controls.Add(TransferAmountBox);
            TransferPanel.Controls.Add(TransferAmountText);
            TransferPanel.Controls.Add(SecondAccountText);
            TransferPanel.Controls.Add(FirstAccountText);
            TransferPanel.Controls.Add(SecondAccountPassword);
            TransferPanel.Controls.Add(SecondAccountUsername);
            TransferPanel.Controls.Add(label9);
            TransferPanel.Controls.Add(FirstAccountPassword);
            TransferPanel.Controls.Add(TransferExample);
            TransferPanel.Controls.Add(TransferExample2);
            TransferPanel.Controls.Add(FirstAccountUsername);
            TransferPanel.Location = new Point(1298, 388);
            TransferPanel.Name = "TransferPanel";
            TransferPanel.Size = new Size(415, 305);
            TransferPanel.TabIndex = 42;
            // 
            // toText
            // 
            toText.AutoSize = true;
            toText.Location = new Point(190, 81);
            toText.Name = "toText";
            toText.Size = new Size(18, 15);
            toText.TabIndex = 45;
            toText.Text = "to";
            // 
            // ErrorTryAgainText3
            // 
            ErrorTryAgainText3.AutoSize = true;
            ErrorTryAgainText3.Location = new Point(162, 251);
            ErrorTryAgainText3.Name = "ErrorTryAgainText3";
            ErrorTryAgainText3.Size = new Size(87, 15);
            ErrorTryAgainText3.TabIndex = 43;
            ErrorTryAgainText3.Text = "Error Try Again.";
            // 
            // ReturnToOptionsButton4
            // 
            ReturnToOptionsButton4.Location = new Point(147, 207);
            ReturnToOptionsButton4.Name = "ReturnToOptionsButton4";
            ReturnToOptionsButton4.Size = new Size(112, 23);
            ReturnToOptionsButton4.TabIndex = 43;
            ReturnToOptionsButton4.Text = "Return To Options";
            ReturnToOptionsButton4.UseVisualStyleBackColor = true;
            ReturnToOptionsButton4.Click += ReturnToOptionsButton4_Click;
            // 
            // TransferAmountButton
            // 
            TransferAmountButton.Location = new Point(166, 178);
            TransferAmountButton.Name = "TransferAmountButton";
            TransferAmountButton.Size = new Size(75, 23);
            TransferAmountButton.TabIndex = 43;
            TransferAmountButton.Text = "Transfer";
            TransferAmountButton.UseVisualStyleBackColor = true;
            TransferAmountButton.Click += TransferAmountButton_Click;
            // 
            // TransferSuccessfullText
            // 
            TransferSuccessfullText.AutoSize = true;
            TransferSuccessfullText.Location = new Point(147, 236);
            TransferSuccessfullText.Name = "TransferSuccessfullText";
            TransferSuccessfullText.Size = new Size(112, 15);
            TransferSuccessfullText.TabIndex = 41;
            TransferSuccessfullText.Text = "Transfer Successfull!";
            // 
            // TransferAmountBox
            // 
            TransferAmountBox.Location = new Point(153, 149);
            TransferAmountBox.Name = "TransferAmountBox";
            TransferAmountBox.Size = new Size(100, 23);
            TransferAmountBox.TabIndex = 44;
            // 
            // TransferAmountText
            // 
            TransferAmountText.AutoSize = true;
            TransferAmountText.Location = new Point(140, 131);
            TransferAmountText.Name = "TransferAmountText";
            TransferAmountText.Size = new Size(126, 15);
            TransferAmountText.TabIndex = 43;
            TransferAmountText.Text = "Input Transfer Amount";
            // 
            // SecondAccountText
            // 
            SecondAccountText.AutoSize = true;
            SecondAccountText.Location = new Point(154, 96);
            SecondAccountText.Name = "SecondAccountText";
            SecondAccountText.Size = new Size(94, 15);
            SecondAccountText.TabIndex = 42;
            SecondAccountText.Text = "Second Account";
            // 
            // FirstAccountText
            // 
            FirstAccountText.AutoSize = true;
            FirstAccountText.Location = new Point(162, 66);
            FirstAccountText.Name = "FirstAccountText";
            FirstAccountText.Size = new Size(77, 15);
            FirstAccountText.TabIndex = 41;
            FirstAccountText.Text = "First Account";
            // 
            // SecondAccountPassword
            // 
            SecondAccountPassword.Location = new Point(252, 92);
            SecondAccountPassword.Name = "SecondAccountPassword";
            SecondAccountPassword.Size = new Size(100, 23);
            SecondAccountPassword.TabIndex = 40;
            // 
            // SecondAccountUsername
            // 
            SecondAccountUsername.Location = new Point(48, 92);
            SecondAccountUsername.Name = "SecondAccountUsername";
            SecondAccountUsername.Size = new Size(100, 23);
            SecondAccountUsername.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(181, 50);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 34;
            // 
            // FirstAccountPassword
            // 
            FirstAccountPassword.Location = new Point(252, 63);
            FirstAccountPassword.Name = "FirstAccountPassword";
            FirstAccountPassword.Size = new Size(100, 23);
            FirstAccountPassword.TabIndex = 35;
            // 
            // TransferExample
            // 
            TransferExample.AutoSize = true;
            TransferExample.Location = new Point(67, 35);
            TransferExample.Name = "TransferExample";
            TransferExample.Size = new Size(60, 15);
            TransferExample.TabIndex = 36;
            TransferExample.Text = "Username";
            // 
            // TransferExample2
            // 
            TransferExample2.AutoSize = true;
            TransferExample2.Location = new Point(274, 35);
            TransferExample2.Name = "TransferExample2";
            TransferExample2.Size = new Size(57, 15);
            TransferExample2.TabIndex = 37;
            TransferExample2.Text = "Password";
            // 
            // FirstAccountUsername
            // 
            FirstAccountUsername.Location = new Point(48, 63);
            FirstAccountUsername.Name = "FirstAccountUsername";
            FirstAccountUsername.Size = new Size(100, 23);
            FirstAccountUsername.TabIndex = 38;
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(334, 176);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(75, 23);
            LogoutButton.TabIndex = 39;
            LogoutButton.Text = "Log Out";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1878, 903);
            Controls.Add(TransferPanel);
            Controls.Add(WithdrawPanel);
            Controls.Add(DepositPanel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(OrText);
            Controls.Add(CheckBalancePanel);
            Controls.Add(LoggedInPanel);
            Controls.Add(StartPageLoginPanel);
            Controls.Add(CreateAccountPanel);
            Name = "Form1";
            Load += Form1_Load;
            CreateAccountPanel.ResumeLayout(false);
            CreateAccountPanel.PerformLayout();
            StartPageLoginPanel.ResumeLayout(false);
            StartPageLoginPanel.PerformLayout();
            LoggedInPanel.ResumeLayout(false);
            LoggedInPanel.PerformLayout();
            CheckBalancePanel.ResumeLayout(false);
            CheckBalancePanel.PerformLayout();
            DepositPanel.ResumeLayout(false);
            DepositPanel.PerformLayout();
            WithdrawPanel.ResumeLayout(false);
            WithdrawPanel.PerformLayout();
            TransferPanel.ResumeLayout(false);
            TransferPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label OrText;
        private TextBox CreateUsername2;
        private Label label2;
        private Label label4;
        private Button CreateButton;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label AccountCreatedLabel;
        private System.Windows.Forms.Timer timer1;
        private Panel CreateAccountPanel;
        private Label UsernameButton2;
        private TextBox CreatePassword2;
        private Label PasswordButton2;
        private Panel StartPageLoginPanel;
        private Label label8;
        private Label LoggedIn;
        private Button CreateAccountOptionButton;
        private Button LoginButton;
        private Label NotLoggedIn;
        private Label label15;
        private Label label10;
        private TextBox PasswordBox;
        private Label label11;
        private Label UsernameText;
        private Label PasswordText;
        private TextBox UsernameBox;
        private Button ReturnToLoginButtonOption;
        private Label label1;
        private Panel LoggedInPanel;
        private Button CheckBalanceButton;
        private Button TransferButton;
        private Button WithdrawButton;
        private Button DepositButton;
        private Label label7;
        private Label DepositAmountText;
        private TextBox DepositMoneyBox;
        private Panel CheckBalancePanel;
        private Label CurrentBalanceText;
        private Label CurrentBalanceNumberText;
        private Label DollarsText;
        private Button ReturnToOptionsButton;
        private Panel DepositPanel;
        private Label EnterDepositAmountText;
        private Button ReturnToOptionsButton2;
        private TextBox DepositAmountBox;
        private Button DepositButtonConfirm;
        private Label MoneyDepositedSuccessfullyText;
        private Panel WithdrawPanel;
        private Button ReturnToOptionsButton3;
        private Button WithdrawAmountButton;
        private TextBox WithdrawAmountBox;
        private Label EnterWithdrawAmountText;
        private Label MoneyWithdrawSuccessfullText;
        private Panel TransferPanel;
        private Label label9;
        private TextBox FirstAccountPassword;
        private Label TransferExample;
        private Label TransferExample2;
        private TextBox FirstAccountUsername;
        private Label SecondAccountText;
        private Label FirstAccountText;
        private TextBox SecondAccountPassword;
        private Label TransferSuccessfullText;
        private TextBox TransferAmountBox;
        private Label TransferAmountText;
        private TextBox SecondAccountUsername;
        private Label ErrorTryAgainText;
        private Label ErrorTryAgainText2;
        private Button ReturnToOptionsButton4;
        private Button TransferAmountButton;
        private Label ErrorTryAgainText3;
        private Label toText;
        private Button LogoutButton;
    }
}
