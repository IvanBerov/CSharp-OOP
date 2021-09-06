namespace P02._Identity_Before
{
    using Contracts;
   
    public class AccountManager : IAccountAuthentication
    {
        public void Register(string username, string password)
        {
            //register
        }

        public void Login(string username, string password)
        {
            //login
        }

        public void ChangePassword(string oldPass, string newPass)
        {
            //change password
        }
    }
}
