
using ChatTogether.Domain.Model;

namespace ChatTogether.Domain.Interface
{
    public interface IUserRepository
    {
        // Tutaj dodajemy definicje naszego repozytorium

        //Przykład
        //IQueryable<User> GetAllUsers();
        int AddUser(User newUser);
        User GetUser(string nickName);
    }
}
