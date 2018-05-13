using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasada
{
    class Class2
    {
        static void Main(string[] args)
        {
            var fasada = new FasadaPostaci(new KlasaPostaci(), new AtrybutyPostaci(), new UmiejetnosciPostaci(), new WygladPostaci());

            fasada.UtworzPostac();

            Console.ReadKey();
        }
    }
}
