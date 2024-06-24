namespace WinFormsIntro
{
    public partial class Form1 : Form
    {
        Account[] accounts = new Account[3];
        int accountsInAray = 3;
        Label currentLabel;


        public Form1()
        {
            InitializeComponent();
        }


        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string userUsernameInput = UsernameBox.Text;
            string userPasswordInput = PasswordBox.Text;

            for (int i = 0; i < accounts.Length; i++)
            {
                if (userUsernameInput == accounts[i].Username && userPasswordInput == accounts[i].Password)
                {
                    currentLabel = LoggedIn;
                    LoggedIn.Visible = true;
                    timer1.Enabled = true;


                    

                    return;
                }

            }
            currentLabel = NotLoggedIn;
            NotLoggedIn.Visible = true;
            timer1.Enabled = true;



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Account brandon = new Account("brandon", "doa");
            Account hakop = new Account("hakop", "zik");
            Account edden = new Account("zrandon", "doa");

            accounts = new Account[3]
            {
                brandon, hakop, edden
            };

            LoggedIn.Visible = false;
            NotLoggedIn.Visible = false;
            AccountCreatedLabel.Visible = false;
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
            string newUsername = CreateUsername.Text;
            string newPassword = CreatePassword.Text;



            if (accountsInAray == accounts.Length)
            {

                resizeAray(2);
                Account newAcc = new Account(newUsername, newPassword);
                accounts[accountsInAray] = newAcc;



            }
            else
            {
                accounts[accountsInAray] = new Account(newUsername, newPassword);
              
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
    }
}
