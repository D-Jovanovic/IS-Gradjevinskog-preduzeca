using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace ISGradnja.Validators
{
    class ProjektiValidator : AbstractValidator<Class.Projekti>
    {
        public ProjektiValidator()
        {
            RuleFor(u => u.Naziv)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Naziv projekta je prazan!")
                .Length(2, 50).WithMessage("Duzina za projekta je pogresna!");

            RuleFor(u => u.Investitor)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Naziv investitora je prazan!")
                .Length(2, 50).WithMessage("Duzina za investitora je pogresna!");

            RuleFor(u => u.Adresa)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Adresa je prazan!")
                .Length(2, 50).WithMessage("Duzina za Adresu je pogresna!");

            RuleFor(u => u.Tip)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Tip je prazan!");

            RuleFor(u => u.Spratnost)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Spratnost je prazan!")
                .Length(2, 50).WithMessage("Duzina za Spratnost je pogresna!");

            RuleFor(u => u.PocetakDatum)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Datum za pocetak je prazan!");

            RuleFor(u => u.RokDatum)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Datum za rok je prazan!");

        }
    }
}
