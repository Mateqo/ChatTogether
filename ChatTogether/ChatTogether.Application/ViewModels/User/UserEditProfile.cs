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
            RuleFor(x => x.NewNickname).Length(4, 15).WithMessage("Niepoprawna długosc");
            RuleFor(x => x.NewEmail).EmailAddress().WithMessage("Niepoprawny e-mail");
            RuleFor(x => x.NewEmailRep).EmailAddress().WithMessage("Niepoprawny e-mail");
            RuleFor(x => x.NewPassword).Length(6, 10).WithMessage("Niepoprawna dlugosc");
            RuleFor(x => x.NewPasswordRep).Length(6, 10).WithMessage("Niepoprawna dlugosc");
        }

    }
}
