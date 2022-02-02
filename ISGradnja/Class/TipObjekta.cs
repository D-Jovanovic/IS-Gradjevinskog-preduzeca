using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISGradnja.Class
{
    class TipObjekta
    {
        public TipObjekta() { }
        public string Naziv { get; set; }

        public TipObjekta(string naziv)
        {
            Naziv = naziv;
        }
    }
}
