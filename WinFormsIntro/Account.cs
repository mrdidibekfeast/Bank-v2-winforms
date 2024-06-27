using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsIntro
{
    public class Account
    {
       public string Username;
       public string Password;
       public int Money;

       public Account(string username, string password, int money)
        {
            Username = username;
            Password = password;
            Money = money;
        }
    }


    
}
