using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISGradnja.Class
{
    class Magacin
    {
        public Magacin() { }
        public string Naziv { get; set; }
        public string MernaJedinica { get; set; }
        public int Kolicina { get; set; }
        public int Dostupno { get; set; }

        public Magacin(string naziv, string mernaJedinica, int kolicina, int dostupno)
        {
            Naziv = naziv;
            MernaJedinica = mernaJedinica;
            Kolicina = kolicina;
            Dostupno = dostupno;
        }
    }
}
