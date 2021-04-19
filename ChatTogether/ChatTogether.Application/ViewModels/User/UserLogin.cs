using ChatTogether.Application.Mapping;
using FluentValidation;

namespace ChatTogether.Application.ViewModels.User
{
    public class UserLogin
    {
        public string NickName { get; set; }
        public string EncryptedPassword { get; set; }

    }

    public class UserLoginValidator: AbstractValidator<UserLogin>
    {
        public UserLoginValidator()
        {
            RuleFor(x => x.NickName).NotEmpty().WithMessage("Wymagany login");
            RuleFor(x => x.EncryptedPassword).NotEmpty().WithMessage("Wymagane haslo");
        }

    }
}
