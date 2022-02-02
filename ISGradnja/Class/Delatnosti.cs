using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISGradnja.Class
{
    class Delatnosti
    {
        public Delatnosti() { }
        public string Naziv { get; set; }

        public Delatnosti(string naziv)
        {
            Naziv = naziv;
        }
    }
}
