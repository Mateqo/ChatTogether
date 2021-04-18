using ChatTogether.Application.Mapping;
using System;

namespace ChatTogether.Application.ViewModels.User
{
    public class UserRegister : IMapFrom<ChatTogether.Domain.Model.User>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nickname { get; set; }
        public string EmailAddress { get; set; }
        public string ConfirmEmailAddress { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Policy { get; set; }
        public bool Rodo { get; set; }

        public void Mapping(MappingProfile profile)
        {
            profile.CreateMap<ChatTogether.Domain.Model.User, UserLogin>().ReverseMap();
        }
    }
}
