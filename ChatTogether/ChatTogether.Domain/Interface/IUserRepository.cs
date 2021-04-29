
using ChatTogether.Domain.Model;
using System.Collections.Generic;

namespace ChatTogether.Domain.Interface
{
    public interface IUserRepository
    {
        // Tutaj dodajemy definicje naszego repozytorium

        //Przykład
        //IQueryable<User> GetAllUsers();
        int AddUser(User newUser);
        User GetUser(string nickName);
        string GetSalt(string nickName);
        IEnumerable<User> GetUsers(string input);
    }
}
