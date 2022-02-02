using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISGradnja.Class;
using FluentValidation;

namespace ISGradnja.Validators
{
    class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Username)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Korisničko ime je prazno!")
                .Length(2, 50).WithMessage("Duzina za korisničkog imena je pogresna!")
                .Must(ValidUserName).WithMessage("Korisničko ime sadrzi nedozvoljene karaktere!");

            RuleFor(u => u.Password)
               .Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("Lozinka je prazna!")
               .Length(5, 50).WithMessage("Duzina za lozinka je pogresna!");

            RuleFor(u => u.Email)
               .Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("Email je prazan!")
               .EmailAddress().WithMessage("Email nije validan!")
               .Length(5, 50).WithMessage("Duzina za email je pogresna!");

            RuleFor(u => u.FullName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Puno ime je prazno!")
                .Length(2, 50).WithMessage("Duzina za puno ime je pogrešno!")
                .Must(ValidName).WithMessage("Puno ime sadrzi nedozvoljene karaktere!");

            RuleFor(u => u.PhoneNumber)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Broj telefona je prazno!")
                .Length(2, 50).WithMessage("Duzina za broj telefona je pogresna!")
                .Must(ValidPhone).WithMessage("Broj telefona sadrzi nedozvoljene karaktere!");

            RuleFor(u => u.Role)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Dozvole je prazno!");
        }

        private bool ValidUserName(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");
            return name.All(Char.IsLetter);
        }

        private bool ValidName(string name)
        {
            name = name.Replace(" ", "");
            return name.All(Char.IsLetter);
        }

        private bool ValidPhone(string name)
        {
            return name.All(Char.IsNumber);
        }
    }
}
