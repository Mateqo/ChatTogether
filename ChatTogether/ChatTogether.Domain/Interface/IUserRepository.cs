
using ChatTogether.Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        IEnumerable<User> GetUsers();
        IEnumerable<Acquaintance> GetAcquaintances();
        void AcceptFriend(int userId, int friendId);
        void RejectFriend(int userId, int friendId);
        void AddFriend(int userId, int friendId);
        void RemoveFriend(int userId, int friendId);
        void SetToken(string nickName, string token);
        void AddConfirmation(Confirmation confirmation);
        void AccountConfirmation(string link);
        IEnumerable<Acquaintance> GetUserFriends(int id);
        IEnumerable<Acquaintance> GetPendingFriends(int id);
        User GetUserById(int id);
        User GetUserByEmail(string email);
        Task SendMessage(int userId, int friendId, string message);
        IEnumerable<Message> GetMessage(int userId, int friendId);
        void ChangeNicknameForUser(int userId, string newNickname);
        void ChangePasswordForUser(Model.User user, string encryptedPassword);
    }
}
