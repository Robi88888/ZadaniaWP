using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasada
{
    public class FasadaPostaci
    {
        private readonly WybKlasaPostaci klasa;
        private readonly WybAtrybutyPostaci atrybuty;
        private readonly WybUmiejetnosciPostaci umiejetnosci;
        private readonly WybWygladPostaci wyglad;

        public FasadaPostaci(WybKlasaPostaci klasa, WybAtrybutyPostaci atrybuty, WybUmiejetnosciPostaci umiejetnosci, WybWygladPostaci wyglad)
        {
            this.klasa = klasa;
            this.atrybuty = atrybuty;
            this.umiejetnosci = umiejetnosci;
            this.wyglad = wyglad;
        }

        public void UtworzPostac()
        {
            Console.WriteLine("Utwórz postać");
            klasa.UstawKlase();
            atrybuty.UstawAtrybuty();
            umiejetnosci.UstawUmiejetnosci();
            wyglad.UstawWyglad();

            Console.WriteLine("Postać zostałą stworzona");
        }
    }
}
