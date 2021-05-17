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

namespace ChatTogether.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepo;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepo, IMapper mapper)
        {
            _userRepo = userRepo;
            _mapper = mapper;
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

        public bool IsSucceslogin(string nickName, string password)
        {
            SHA256 encryption = SHA256.Create();
            StringBuilder EncPass = new StringBuilder();

            var user = _userRepo.GetUser(nickName);

            if (user != null)
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
                        !x.Acquaintances.Any(a => a.UserId == Convert.ToInt32(userId) && a.AcquaintanceId == x.Id) &&
                        (
                            x.Name.ToLower().Contains(inputFirst) ||
                            x.Name.ToLower().Contains(inputSecond)
                        ) &&
                        (
                            x.Surname.ToLower().Contains(inputFirst) ||
                            x.Surname.ToLower().Contains(inputSecond)
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
            int test = friendList.Count();
            string test2 = friendList.FirstOrDefault().User.Nickname;
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

    }
}
