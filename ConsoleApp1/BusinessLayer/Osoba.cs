using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer

{
    class Osoba
    {
        // Konstruktor
        public Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }

        // Svojstva ime i prezime
        private string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        private string prezime;
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        // Metoda PunoIme
        public string PunoIme()
        {
            return Ime + " " + Prezime;
        }
    }
}
