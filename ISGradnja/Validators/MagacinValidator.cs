using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using ISGradnja.Class;

namespace ISGradnja.Validators
{
    class MagacinValidator : AbstractValidator<Magacin>
    {
        public MagacinValidator()
        {
            RuleFor(u => u.Naziv)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Naziv je prazan!")
                .Length(2, 50).WithMessage("Duzina je pogresna!");

            RuleFor(u => u.MernaJedinica)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Merna jedinica je prazaa!");

            RuleFor(u => u.Kolicina)
               .Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("Kolicina je prazaa!");

        }

        private bool ValidName(string name)
        {
            name = name.Replace(" ", "");
            return name.All(Char.IsLetter);
        }

        private bool ValidNumber(string name)
        {
            return name.All(Char.IsNumber);
        }
    }
}
