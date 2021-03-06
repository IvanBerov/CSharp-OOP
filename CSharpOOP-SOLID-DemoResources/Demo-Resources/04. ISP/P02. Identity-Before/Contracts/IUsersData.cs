namespace P02._Identity_Before.Contracts
{
    using System.Collections.Generic;

    public interface IUsersData
    {
        IEnumerable<IUser> GetAllUsersOnline();

        IEnumerable<IUser> GetAllUsers();

        IUser GetUserByName(string name);
    }
}
