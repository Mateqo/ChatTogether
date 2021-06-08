using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace ChatTogether.Application.ViewModels.User
{
    public class UserEditProfile
    {
        public string CurrentPassword { get; set; }
        public string NewNickname { get; set; }
        public string NewPassword { get; set; }
        public string NewPasswordRep { get; set; }
        public string NewEmail { get; set; }
        public string NewEmailRep { get; set; }

    }

    public class UserEditProfileValidator : AbstractValidator<UserEditProfile>
    {
        public UserEditProfileValidator()
        {
            RuleFor(x => x.CurrentPassword).NotEmpty().WithMessage("Wymagane aktualne hasło");
            RuleFor(x => x.NewNickname).NotEmpty().WithMessage("Wymagana nazwa użytkownika");
            RuleFor(x => x.NewEmail).NotEmpty().WithMessage("Wymagany adres email");
            RuleFor(x => x.NewPassword).NotEmpty().WithMessage("Wymagane nowe haslo");
        }

    }
}
