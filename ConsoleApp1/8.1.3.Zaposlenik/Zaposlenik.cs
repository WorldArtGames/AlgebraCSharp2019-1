using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._3.Zaposlenik
{
    class Zaposlenik
    {

        #region Svojstva

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

        private string jmbg;
        public string JMBG
        {
            get { return jmbg; }
            set { jmbg = value; }
        }

        double brojBodova;
        public double BrojBodova
        {
            get { return brojBodova; }
            set
            {
                if (value > 0)
                {
                    brojBodova = value;
                }
                else
                {
                    Exception ex = new Exception("Unijeti se može samo pozitivan broj!");
                    throw ex;
                }
            }
        }

        double vrijednostBoda;
        public double VrijednostBoda
        {
            get { return vrijednostBoda; }
            set
            {
                if (value > 0)
                {
                    vrijednostBoda = value;
                }
                else
                {
                    Exception ex = new Exception("Može se unijeti samo pozitivan broj!");
                    throw ex;
                }
            }
        }

        // ReadOnly svojstvo
        public double Porez
        {
            get
            {
                double neto = this.NetoIzracunPlace();
                if (neto < 3000)
                {
                    return
                }
            }
        }
    }
}
