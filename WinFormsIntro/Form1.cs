namespace WinFormsIntro
{
    public partial class Form1 : Form
    {
        Account[] accounts = new Account[3];
        int accountsInAray = 3;
        Label currentLabel;
        Account currentAccount;

        Panel currentPanel;

        public Form1()
        {
            InitializeComponent();
        }






        private void Form1_Load(object sender, EventArgs e)
        {
            Account brandon = new Account("brandon", "doa", 50000);
            Account hakop = new Account("hakop", "zik", 1);
            Account edden = new Account("zrandon", "doa", 50000);



            accounts = new Account[3]
            {
                brandon, hakop, edden
            };

            currentPanel = CheckBalancePanel;

            LoggedIn.Visible = false;
            NotLoggedIn.Visible = false;
            LoggedInPanel.Visible = false;
            AccountCreatedLabel.Visible = false;
            CreateAccountPanel.Visible = false;
            StartPageLoginPanel.Visible = true;
            CheckBalancePanel.Visible = false;
            DepositPanel.Visible = false;
            MoneyDepositedSuccessfullyText.Visible = false;
            WithdrawPanel.Visible = false;
            TransferPanel.Visible = false;
            MoneyWithdrawSuccessfullText.Visible = false;
            ErrorTryAgainText.Visible = false;
            ErrorTryAgainText2.Visible = false;
            ErrorTryAgainText3.Visible = false;
            TransferSuccessfullText.Visible = false;
        }

        public void resizeAray(int size)
        {
            Account[] newAccounts = new Account[accounts.Length * size];


            for (int i = 0; i < accounts.Length; i++)
            {
                newAccounts[i] = accounts[i];

            }

            accounts = newAccounts;
        }



        private void CreateButton_Click(object sender, EventArgs e)
        {
            string newUsername = CreateUsername2.Text;
            string newPassword = CreatePassword2.Text;
            string moneyAmountWant = DepositMoneyBox.Text;
            int moneyAmount;
            while (!int.TryParse(moneyAmountWant, out moneyAmount))
            {

            }
            //   int moneyAmount = int.Parse(DepositMoneyBox.Text);




            if (accountsInAray == accounts.Length)
            {

                resizeAray(2);
                Account newAcc = new Account(newUsername, newPassword, moneyAmount);
                accounts[accountsInAray] = newAcc;



            }
            else
            {
                accounts[accountsInAray] = new Account(newUsername, newPassword, moneyAmount);

            }
            accountsInAray++;

            currentLabel = AccountCreatedLabel;
            AccountCreatedLabel.Visible = true;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentLabel.Visible = false;
            timer1.Enabled = false;
        }

        private void CreateAccountOptionButton_Click(object sender, EventArgs e)
        {

            CreateAccountPanel.Visible = true;
            StartPageLoginPanel.Visible = false;

        }

        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            string userUsernameInput = UsernameBox.Text;
            string userPasswordInput = PasswordBox.Text;

            for (int i = 0; i < accounts.Length; i++)
            {
                if (userUsernameInput == accounts[i].Username && userPasswordInput == accounts[i].Password)
                {
                    currentAccount = accounts[i];

                    currentLabel = LoggedIn;
                    LoggedInPanel.Visible = true;
                    StartPageLoginPanel.Visible = false;
                    LoggedIn.Visible = true;
                    timer1.Enabled = true;




                    return;
                }

            }
            currentLabel = NotLoggedIn;
            NotLoggedIn.Visible = true;
            timer1.Enabled = true;

        }

        public void returnButtonLogic()
        {
            currentPanel.Visible = false;
            LoggedInPanel.Visible = true;
        }
        private void ReturnToLoginButtonOption_Click(object sender, EventArgs e)
        {
            StartPageLoginPanel.Visible = true;
            CreateAccountPanel.Visible = false;
        }

        private void CheckBalanceButton_Click(object sender, EventArgs e)
        {
            currentPanel = CheckBalancePanel;
            LoggedInPanel.Visible = false;
            CheckBalancePanel.Visible = true;

            CurrentBalanceNumberText.Text = currentAccount.Money.ToString();
        }

        private void ReturnToOptionsButton_Click(object sender, EventArgs e)
        {
            returnButtonLogic();
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            LoggedInPanel.Visible = false;
            DepositPanel.Visible = true;
            currentPanel = DepositPanel;

        }

        private void ReturnToOptionsButton2_Click(object sender, EventArgs e)
        {
            returnButtonLogic();
        }

        private void DepositButtonConfirm_Click(object sender, EventArgs e)
        {
            string wantDeposit = DepositAmountBox.Text;
            int wantDepositMoney;
            bool depositParse = int.TryParse(wantDeposit, out wantDepositMoney);

            if (depositParse == false || wantDepositMoney < 0)
            {

                currentLabel = ErrorTryAgainText2;
                ErrorTryAgainText2.Visible = true;
                timer1.Enabled = true;
            }
            else
            {
                currentAccount.Money += wantDepositMoney;

                currentLabel = MoneyDepositedSuccessfullyText;
                MoneyDepositedSuccessfullyText.Visible = true;
                timer1.Enabled = true;
            }
        }

        private void ReturnToOptionsButton3_Click(object sender, EventArgs e)
        {
            returnButtonLogic();
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            currentPanel = WithdrawPanel;
            LoggedInPanel.Visible = false;
            WithdrawPanel.Visible = true;

        }

        private void WithdrawAmountButton_Click(object sender, EventArgs e)
        {
            string wantWithdraw = WithdrawAmountBox.Text;
            int wantWithdrawMoney;
            bool withdrawParse = int.TryParse(wantWithdraw, out wantWithdrawMoney);
            if (withdrawParse == false || wantWithdrawMoney < 0 || wantWithdrawMoney > currentAccount.Money)
            {
                currentLabel = ErrorTryAgainText;
                ErrorTryAgainText.Visible = true;
                timer1.Enabled = true;
            }
            else
            {
                currentAccount.Money -= wantWithdrawMoney;

                currentLabel = MoneyWithdrawSuccessfullText;
                MoneyWithdrawSuccessfullText.Visible = true;
                timer1.Enabled = true;
            }
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            currentPanel = TransferPanel;
            LoggedInPanel.Visible = false;
            TransferPanel.Visible = true;
        }

        private void ReturnToOptionsButton4_Click(object sender, EventArgs e)
        {
            returnButtonLogic();
        }


        public Account FindAccount(string username, string password)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (username == accounts[i].Username && password == accounts[i].Password)
                {
                    return accounts[i];
                }
            }
            return null;
        }



        private void TransferAmountButton_Click(object sender, EventArgs e)
        {



            Account firstAccountVerified = FindAccount(FirstAccountUsername.Text, FirstAccountPassword.Text);
            Account secondAccountVerified = FindAccount(SecondAccountUsername.Text, SecondAccountPassword.Text);
            //if (FirstAccountUsername.Text == accounts[i].Username && FirstAccountPassword.Text == accounts[i].Password)
            //{
            //    validAccount1 = true;
            //    firstAccountVerified = FindAccount(FirstAccountUsername.Text, FirstAccountPassword.Text);
            //}
            //else
            //{
            //    validAccount1 = false;
            //}


            //if(SecondAccountUsername.Text == accounts[i].Username && SecondAccountPassword.Text == accounts[i].Password)
            //{
            //    validAccount2 = true;
            //    secondAccountVerified = FindAccount(SecondAccountUsername.Text, SecondAccountPassword.Text);
            //}
            //else
            //{
            //    validAccount2 = false;
            //}



            string transferAmountMoney = TransferAmountBox.Text;
            int transferAmountMoneyInt;
            bool transferParse = int.TryParse(transferAmountMoney, out transferAmountMoneyInt);

            if (firstAccountVerified != null && secondAccountVerified != null && transferParse && transferAmountMoneyInt > 0 && FirstAccountUsername.Text == currentAccount.Username)
            {
                // use current Account variable to transfer to a random account , second account money going into to find that account set up a for loop like line 130

                firstAccountVerified.Money -= transferAmountMoneyInt;
                secondAccountVerified.Money += transferAmountMoneyInt;
                currentLabel = TransferSuccessfullText;
                TransferSuccessfullText.Visible = true;
                timer1.Enabled = true;
            }
            else if (firstAccountVerified == null && secondAccountVerified == null && transferParse == false && transferAmountMoneyInt < 0 && FirstAccountUsername.Text != currentAccount.Username)
            {
                currentLabel = ErrorTryAgainText3;
                ErrorTryAgainText3.Visible = true;
                timer1.Enabled = true;
            }


        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoggedInPanel.Visible = false;
            StartPageLoginPanel.Visible = true;
        }
    }
}
