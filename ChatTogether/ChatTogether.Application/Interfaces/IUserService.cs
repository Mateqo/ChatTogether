
using ChatTogether.Application.ViewModels.Friend;
using ChatTogether.Application.ViewModels.User;
using ChatTogether.Domain.Model;
using System.Collections.Generic;

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
        bool ValidateUser(string nickName, string id, string token);
        void SetToken(string nickName);
        FriendsList GetFriendList(string id);

    }
}
