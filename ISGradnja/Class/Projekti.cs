using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISGradnja.Class
{
    class Projekti
    {
        public Projekti() { }
        public string Naziv { get; set; }
        public string Investitor { get; set; }
        public string Adresa { get; set; }
        public string Tip { get; set; }
        public string Spratnost { get; set; }
        public string PocetakDatum { get; set; }
        public string RokDatum { get; set; }
        public string Dokument1 { get; set; }
        public string Dokument2 { get; set; }
        public string Dokument3 { get; set; }

        public Projekti(string naziv, string investitor, string adresa, string tip, string spratnost, string pocetakDatum, string rokDatum, string dokument1, string dokument2, string dokument3)
        {
            Naziv = naziv;
            Investitor = investitor;
            Adresa = adresa;
            Tip = tip;
            Spratnost = spratnost;
            PocetakDatum = pocetakDatum;
            RokDatum = rokDatum;
            Dokument1 = dokument1;
            Dokument2 = dokument2;
            Dokument3 = dokument3;
        }
    }
}
