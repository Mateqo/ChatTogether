using AutoMapper;
using ChatTogether.Application.Interfaces;
using ChatTogether.Application.ViewModels.User;
using ChatTogether.Domain.Interface;
using ChatTogether.Domain.Model;
using System;
using System.Collections.Generic;

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
            User user = new User
            {
                Nickname = newUser.Nickname,
                Name = newUser.Name,
                Surname = newUser.Surname,
                EmailAddress = newUser.EmailAddress,
                EncryptedPassword = newUser.EncryptedPassword,
                CreationDate = DateTime.Now,
                Active = true,
            };
            //var user = _mapper.Map<User>(newUser); do ogarnięcia mapper później
            var id = _userRepo.AddUser(user);

            return id;
        }

        public bool IsSucceslogin(string nickName, string password)
        {
            var user = _userRepo.GetUser(nickName);
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
