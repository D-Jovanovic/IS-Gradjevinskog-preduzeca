using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISGradnja.Class;
using FluentValidation;

namespace ISGradnja.Validators
{
    class RadnikValidator : AbstractValidator<Radnik>
    {
        public RadnikValidator()
        {
            RuleFor(u => u.ImePrezime)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Ime i prezime je prazno!")
                .Length(2, 50).WithMessage("Duzina za ime i prezime je pogresna!")
                .Must(ValidName).WithMessage("Ime i prezime sadrzi nedozvoljene karaktere!");

            RuleFor(u => u.Adresa)
               .Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("Adresa je prazna!")
               .Length(5, 50).WithMessage("Duzina za adresu je pogresna!");

            RuleFor(u => u.BrojTelefona)
               .Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("Broj telefona je prazan!")
               .Length(5, 50).WithMessage("Duzina za broj telefona je pogresna!");

            RuleFor(u => u.Delatnost)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Delatnost je prazno!")
                .Length(2, 50).WithMessage("Duzina za delatnost je pogrešna!");

            RuleFor(u => u.JMBG)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("JMBG je prazno!")
                .Length(13, 13).WithMessage("Duzina za JMBG je pogresna!")
                .Must(ValidPhone).WithMessage("JMBG sadrzi nedozvoljene karaktere!");

            RuleFor(u => u.Gradiliste)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Gradilište je prazno!");
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
