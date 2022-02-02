using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISGradnja.Class
{
    class Radnik
    {
        public Radnik() { }
        public string ImePrezime { get; set; }
        public string Adresa { get; set; }
        public string BrojTelefona { get; set; }
        public string JMBG { get; set; }
        public string Delatnost { get; set; }
        public string Gradiliste { get; set; }

        public Radnik(string imePrezime, string adresa, string brojTelefona, string jMBG, string delatnost, string gradiliste)
        {
            ImePrezime = imePrezime;
            Adresa = adresa;
            BrojTelefona = brojTelefona;
            JMBG = jMBG;
            Delatnost = delatnost;
            Gradiliste = gradiliste;
        }
    }
}
