using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISGradnja.Class;
using FluentValidation;

namespace ISGradnja.Validators
{
    class DelatnostiValidator: AbstractValidator<Delatnosti>
    {
        public DelatnostiValidator()
        {
            RuleFor(u => u.Naziv)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Naziv delatnosti je prazan!")
                .Length(2, 50).WithMessage("Duzina za delatnst je pogresna!")
                .Must(ValidName).WithMessage("Delatnost sadrzi nedozvoljene karaktere!");

        }

        private bool ValidName(string name)
        {
            return name.All(Char.IsLetter);
        }
    }
}
