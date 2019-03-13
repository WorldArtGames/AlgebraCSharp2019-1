using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._3.Zaposlenik
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciramo novi objekt Z1 klase Zaposlenik
            Zaposlenik Z1 = new _3.Zaposlenik("Leo", "Ford", "2002999301389");

            List<Zaposlenik> listaZaposlenika = new List<Zaposlenik>();
            listaZaposlenika.Add(Z1);


            listaZaposlenika.ForEach(UnesiBodove(Zaposlenik));
              


        }
    }
}
