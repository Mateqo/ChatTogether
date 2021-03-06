using AutoMapper;
using ChatTogether.Application.Interfaces;
using ChatTogether.Application.ViewModels.User;
using ChatTogether.Domain.Interface;
using ChatTogether.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Linq;
using ChatTogether.Application.ViewModels.Friend;
using System.Threading.Tasks;
using ChatTogether.Application.ViewModels.Chat;

namespace ChatTogether.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepo;

        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        //Tutaj definiujemy logikę apliakcji

        //Przykład
        //public int AddUser(NewOrEditUserVm usertVM)
        //{
        //    var user = _mapper.Map<User>(userVM);
        //    var id = _userRepo.AddUser(user);

        //    return id;
        //}

        public int AddUser(UserRegister newUser)
        {
            SHA256 encryption = SHA256.Create();
            StringBuilder EncPass = new StringBuilder();

            var saltGuid = Guid.NewGuid().ToString();
            var encPassBytes = encryption.ComputeHash(
                Encoding.ASCII.GetBytes(
                    newUser.EncryptedPassword + saltGuid));

            for (int i = 0; i < encPassBytes.Length; i++)
            {
                EncPass.Append(encPassBytes[i].ToString("x2"));
            }

            User user = new User
            {
                Nickname = newUser.Nickname,
                Name = newUser.Name,
                Surname = newUser.Surname,
                EmailAddress = newUser.EmailAddress,
                EncryptedPassword = EncPass.ToString(),
                Salt = saltGuid,
                CreationDate = DateTime.Now,
                Active = false,
            };
            //var user = _mapper.Map<User>(newUser); do ogarnięcia mapper później
            var id = _userRepo.AddUser(user);

            return id;
        }

        public bool CheckNameUniqueness(string nickname)
        {
            var checkUser = _userRepo.GetUser(nickname);

            if (checkUser == null)
            {
                return true;
            }
            return false;
        }

        public bool CheckEmailUniqueness(string email)
        {
            var checkEmail = _userRepo.GetUserByEmail(email);

            if (checkEmail == null)
            {
                return true;
            }
            return false;
        }

        public bool IsSucceslogin(string nickName, string password)
        {
            SHA256 encryption = SHA256.Create();
            StringBuilder EncPass = new StringBuilder();

            var user = _userRepo.GetUser(nickName);

            if (user != null && user.Active)
            {
                var encPassBytes = encryption.ComputeHash(
                    Encoding.ASCII.GetBytes(
                        password + _userRepo.GetSalt(nickName)));

                for (int i = 0; i < encPassBytes.Length; i++)
                {
                    EncPass.Append(encPassBytes[i].ToString("x2"));
                }
                password = EncPass.ToString();

                if (password == user.EncryptedPassword)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public int GetUserId(string nickName)
        {
            return _userRepo.GetUser(nickName).Id;
        }

        public User GetUserByNickName(string nickName)
        {
            return _userRepo.GetUser(nickName);
        }

        public User GetUserById(int id)
        {
            return _userRepo.GetUserById(id);
        }

        public void AcceptFriend(string userId, int friendId)
        {
            _userRepo.AcceptFriend(Convert.ToInt32(userId), friendId);
        }

        public void RejectFriend(string userId, int friendId)
        {
            _userRepo.RejectFriend(Convert.ToInt32(userId), friendId);
        }

        public void AddFriend(string userId, int friendId)
        {
            _userRepo.AddFriend(Convert.ToInt32(userId), friendId);
        }

        public void RemoveFriend(string userId, int friendId)
        {
            _userRepo.RemoveFriend(Convert.ToInt32(userId), friendId);
        }

        public List<UserGetItem> GetUsers(string input, string userId)
        {
            List<UserGetItem> userListVM = new List<UserGetItem>();

            if (!string.IsNullOrEmpty(input))
            {
                var fullName = input.Split(' ');
                var inputFirst = fullName[0].ToLower();
                var inputSecond = fullName.Count() > 1 ? fullName[1].ToLower() : "";
                var userList = _userRepo.GetUsers().Where
                    (
                        x => x.Id != Convert.ToInt32(userId) &&
                        !x.Acquaintances.Any
                        (
                            a => a.UserId == x.Id && a.AcquaintanceId == Convert.ToInt32(userId)
                        ) &&
                        (
                            (x.Name + x.Surname).ToLower().Contains(inputFirst) ||
                            (x.Name + x.Surname).ToLower().Contains(inputSecond != "" ? inputSecond : inputFirst)
                        )
                    ).Take(5);

                foreach (var item in userList)
                {
                    userListVM.Add(new UserGetItem
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Surname = item.Surname,
                        NickName = item.Nickname
                    });
                }
            }

            return userListVM;
        }

        public bool ValidateUser(string nickName, string id, string token)
        {
            var user = _userRepo.GetUser(nickName);

            if (user != null && nickName != null && id == user.Id.ToString() && token == user.Token)
                return true;

            return false;
        }

        public void SetToken(string nickName)
        {
            _userRepo.SetToken(nickName, Guid.NewGuid().ToString());
        }

        public void AddConfirmation(Guid link, UserRegister newUser)
        {
            Confirmation confirmation = new Confirmation
            {
                UserId = GetUserId(newUser.Nickname),
                Link = link.ToString(),
                LinkSendingDate = DateTime.Now,
                ConfirmationDate = null
            };
            _userRepo.AddConfirmation(confirmation);
        }

        public void AccountConfirmation(string link)
        {
            _userRepo.AccountConfirmation(link);
        }

        public FriendsList GetFriendList(string id)
        {
            var userId = Convert.ToInt32(id);
            var allUsers = _userRepo.GetAcquaintances();
            var friendList = allUsers.Where(x => x.UserId == userId && !string.IsNullOrEmpty(x.ConfirmationDate.ToString()));
            var pendingFriendList = allUsers.Where(x => x.AcquaintanceId == userId && string.IsNullOrEmpty(x.ConfirmationDate.ToString()));
            List<FriendItem> friendsViewModel = new List<FriendItem>();
            List<FriendItem> pendingFriendsViewModel = new List<FriendItem>();
            //int test = friendList.Count();
            //string test2 = friendList.FirstOrDefault().User.Nickname;
            foreach (var item in friendList)
            {
                friendsViewModel.Add(new FriendItem
                {
                    Id = item.AcqUser.Id,
                    NickName = item.AcqUser.Nickname,
                    Name = item.AcqUser.Name,
                    Surname = item.AcqUser.Surname
                }
                );
            }

            foreach (var item in pendingFriendList)
            {
                pendingFriendsViewModel.Add(new FriendItem
                {
                    Id = item.User.Id,
                    NickName = item.User.Nickname,
                    Name = item.User.Name,
                    Surname = item.User.Surname
                }
                );
            }

            return new FriendsList()
            {
                Friends = friendsViewModel,
                PendingFriends = pendingFriendsViewModel
            };

        }

        public List<UserGetItem> CheckSend(List<UserGetItem> userList, string id)
        {
            var sendingInvite = _userRepo.GetAcquaintances().Where(x => x.UserId == Convert.ToInt32(id));


            foreach (var item in userList)
            {
                if (sendingInvite.Any(x => x.AcquaintanceId == item.Id))
                    item.isSend = true;
            }

            return userList;
        }

        public async Task SendMessage(int userId, int friendId, string message)
        {
            await _userRepo.SendMessage(userId, friendId, message);
        }

        public IEnumerable<MessagesListItem> GetMessage(int userId, int friendId)
        {
            var messageList = _userRepo.GetMessage(userId, friendId);
            List<MessagesListItem> messageListViewModel = new List<MessagesListItem>();

            foreach (var item in messageList)
            {
                var newMessage = new MessagesListItem()
                {
                    Id = item.Id,
                    SenderId = item.SenderId,
                    SenderNick = item.Sender.Nickname,
                    ReceiverId = item.ReceiverId,
                    ReceiverNick = item.Receiver.Nickname,
                    Content = item.Content,
                    CreationDate = item.CreationDate,
                    ReceivementDate = item.ReceivementDate
                };
                messageListViewModel.Add(newMessage);
            }

            return messageListViewModel;
        }

        public void ChangeNickname(string userId, string newNickname)
        {
            var user = _userRepo.GetUserById(Convert.ToInt32(userId));
            _userRepo.ChangeNicknameForUser(user, newNickname);
        }

        public void ChangeEmail(string userId, string newEmail)
        {
            var user = _userRepo.GetUserById(Convert.ToInt32(userId));
            _userRepo.ChangeEmailForUser(user, newEmail);
        }

        public void ChangePassword(string userId, string newPassword)
        {
            SHA256 encryption = SHA256.Create();
            StringBuilder EncPass = new StringBuilder();

            var user = _userRepo.GetUserById(Convert.ToInt32(userId));

            var encPassBytes = encryption.ComputeHash(
                    Encoding.ASCII.GetBytes(
                        newPassword + _userRepo.GetSalt(user.Nickname)));

            for (int i = 0; i < encPassBytes.Length; i++)
            {
                EncPass.Append(encPassBytes[i].ToString("x2"));
            }

            _userRepo.ChangePasswordForUser(user, EncPass.ToString());
        }
    }
}
