using AutoMapper;
using ChatTogether.Application.Interfaces;


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
    }
}
