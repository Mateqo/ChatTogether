using ChatTogether.Application.Mapping;
using ChatTogether.Application.Services;
using FluentValidation;
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
        public string EncryptedPassword { get; set; }
        public string Salt { get; set; }
        public string ConfirmPassword { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Policy { get; set; }
        public bool Rodo { get; set; }

        public void Mapping(MappingProfile profile)
        {
            profile.CreateMap<ChatTogether.Domain.Model.User, UserLogin>().ReverseMap();
        }
    }

    public class UserRegisterValidator : FluentValidation.AbstractValidator<UserRegister>
    {
        public UserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Imie wymagane").Length(4, 15).WithMessage("Niepoprawna długosc");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Nazwisko wymagane").Length(4, 15).WithMessage("Niepoprawna długosc");
            RuleFor(x => x.Nickname).NotEmpty().WithMessage("Nickname wymagany").Length(4, 15).WithMessage("Niepoprawna długosc");
            RuleFor(x => x.EmailAddress).NotEmpty().WithMessage("E-mail wymagany").EmailAddress().WithMessage("Niepoprawny e-mail");
            RuleFor(x => x.ConfirmEmailAddress).Equal(x => x.EmailAddress).WithMessage("Niepoprawny e-mail");
            RuleFor(x => x.EncryptedPassword).NotEmpty().WithMessage("Wymagane hasło").Length(6, 10).WithMessage("Niepoprawna dlugosc");
            RuleFor(x => x.ConfirmPassword).Equal(x => x.EncryptedPassword).WithMessage("Złe hasło");
            RuleFor(x => x.DateOfBirth).Must(BeAValidAge).WithMessage("Niepoprawny wiek");
            RuleFor(x => x.Policy).Equal(true).WithMessage("Wymagana zgoda");
            RuleFor(x => x.Rodo).Equal(true).WithMessage("Wymagana zgoda");
        }
        protected bool BeAValidAge(DateTime value)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - Convert.ToDateTime(value).Year;
            if (age < 13)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    
}
