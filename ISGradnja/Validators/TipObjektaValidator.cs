using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISGradnja.Class;
using FluentValidation;

namespace ISGradnja.Validators
{
    class TipObjektaValidator : AbstractValidator<TipObjekta>
    {
        public TipObjektaValidator()
        {
            RuleFor(u => u.Naziv)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Naziv tipa objketa je prazan!")
                .Length(2, 50).WithMessage("Duzina za tip objekta je pogresna!")
                .Must(ValidName).WithMessage("Tip objketa sadrzi nedozvoljene karaktere!");

        }

        private bool ValidName(string name)
        {
            return name.All(Char.IsLetter);
        }
    }
}
