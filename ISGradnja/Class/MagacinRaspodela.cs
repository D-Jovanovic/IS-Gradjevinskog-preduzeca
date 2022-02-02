using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISGradnja.Class
{
    class MagacinRaspodela
    {
        public MagacinRaspodela() { }
        public string Naziv { get; set; }
        public string Gradiliste { get; set; }
        public int Kolicina { get; set; }

        public MagacinRaspodela(string naziv, string gradiliste, int kolicina)
        {
            Naziv = naziv;
            Gradiliste = gradiliste;
            Kolicina = kolicina;
        }
    }
}
