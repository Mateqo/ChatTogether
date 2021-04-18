using AutoMapper;
using ChatTogether.Application.Interfaces;
using ChatTogether.Application.ViewModels.User;
using ChatTogether.Domain.Interface;
using ChatTogether.Domain.Model;
using System;

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
            var user = _mapper.Map<User>(newUser);
            user.CreationDate = DateTime.Now;
            user.Active = true;
            var id = _userRepo.AddUser(user);

            return id;
        }

        public bool IsSucceslogin(string nickName, string password)
        {
            var user = _userRepo.GetUser(nickName);
            if (password == user.EncryptedPassword)
                return true;
            else
                return false;
        }

        public int GetUserId(string nickName)
        {
            return _userRepo.GetUser(nickName).Id;
        }
    }
}
