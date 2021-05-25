
using ChatTogether.Application.ViewModels.Chat;
using ChatTogether.Application.ViewModels.Friend;
using ChatTogether.Application.ViewModels.User;
using ChatTogether.Domain.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChatTogether.Application.Interfaces
{
    public interface IUserService
    {
        //Tutaj definiujemy definicję logiki apliakcji

        //Przykład
        //int AddUser(NewOrEditUserVm userVM);
        int AddUser(UserRegister newUser);
        bool IsSucceslogin(string nickName, string password);
        int GetUserId(string nickName);
        User GetUserByNickName(string nickName);
        List<UserGetItem> GetUsers(string input,string userId);
        void AcceptFriend(string userId, int friendId);
        void RejectFriend(string userId, int friendId);
        void AddFriend(string userId, int friendId);
        void RemoveFriend(string userId, int friendId);
        bool ValidateUser(string nickName, string id, string token);
        void SetToken(string nickName);
        void AddConfirmation(Guid link, UserRegister newUser);
        void AccountConfirmation(string link);
        FriendsList GetFriendList(string id);
        bool CheckNameUniqueness(string nickname);
        bool CheckEmailUniqueness(string email);
        List<UserGetItem> CheckSend(List<UserGetItem> userList, string id);
        Task SendMessage(int userId, int friendId, string message);
        IEnumerable<MessagesListItem> GetMessage(int userId, int friendId);
    }
}
