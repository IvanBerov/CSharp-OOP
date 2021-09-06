using P02._Identity_Before.Contracts;

namespace P02._Identity_Before
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {

            IAccountAuthentication authentication = new AccountManager();
            string userName = "ivan";
            string password = "123456";
            authentication.Login(userName, password);

            IAccountAuthentication accountAuthentication = new AccountManager();
            accountAuthentication.ChangePassword("dddd", "ffff");

            IAccountAuthentication account = new AccountManager();
        }
    }
}
