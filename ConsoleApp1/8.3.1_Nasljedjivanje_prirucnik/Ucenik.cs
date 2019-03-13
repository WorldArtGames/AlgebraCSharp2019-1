using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3._1_Nasljedjivanje_prirucnik
{
    // Klasa Ucenik nasljeđuje se iz klase Osoba
    public class Ucenik : Osoba
    {
        // Konstruktor 1
        public Ucenik(string ime, string prezime)
            : base(ime,prezime)
        { }

        // Konstruktor 2
        public Ucenik(string ime, string prezime, int matematika)
            : this(ime,prezime)
        {
            Matematika = matematika; 
        }

        // Novo svojstvo u nasljeđenoj klasi
        private int matematika;
        public int Matematika
        {


            get
            {
                return matematika;
            }
            set { matematika = value; }
        }

        // Premošćivanje metode ToString naslijeđene iz klase Object
        public override string ToString()
        {
            return PunoIme();
        }

        // Sjenčana metoda PunoIme
        public string PunoIme()
        {
            return Prezime + ", " + Ime;
        }

    }
}
