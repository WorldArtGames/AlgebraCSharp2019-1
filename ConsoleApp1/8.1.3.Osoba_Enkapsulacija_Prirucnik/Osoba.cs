using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._3.Osoba_Enkapsulacija_Prirucnik
{
    class Osoba
    {
        string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        string prezime;
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        int starost;
        public int Starost
        {
            get { return starost; }
            set
            {
                if (value > 0)
                {
                    starost = value;
                }
                else
                {
                    Exception ex = new Exception("Neispravan unos!");
                    throw ex;
                }
            }
        }
    }
}
