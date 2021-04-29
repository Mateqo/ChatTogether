using AutoMapper;
using ChatTogether.Application.Interfaces;
using ChatTogether.Application.ViewModels.User;
using ChatTogether.Domain.Interface;
using ChatTogether.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

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
                Active = true,
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
            var encPassBytes = encryption.ComputeHash(
                    Encoding.ASCII.GetBytes(
                        password + _userRepo.GetSalt(nickName)));

            for (int i = 0; i < encPassBytes.Length; i++)
            {
                EncPass.Append(encPassBytes[i].ToString("x2"));
            }
            password = EncPass.ToString();

            if (user != null && password == user.EncryptedPassword)
                return true;
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

        public List<UserGetItem> GetUsers(string input)
        {
            List<UserGetItem> userListVM = new List<UserGetItem>();
            var userList = _userRepo.GetUsers(input);

            foreach (var item in userList)
            {
                userListVM.Add(new UserGetItem { 
                    Id = item.Id,
                    Name = item.Name,
                    Surname = item.Surname,
                    NickName = item.Nickname
                });
            }

            return userListVM;
        }

    }
}
