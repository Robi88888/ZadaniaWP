using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasada
{
   public interface WybKlasaPostaci
   {
        void UstawKlase();
   }

   public class KlasaPostaci : WybKlasaPostaci
   {
        public void UstawKlase()
        {
            Console.WriteLine("Klasa postaci - Wybierz Klase");
        }
   }

    public interface WybAtrybutyPostaci
    {
        void UstawAtrybuty();
    }

    public class AtrybutyPostaci : WybAtrybutyPostaci
    {
        public void UstawAtrybuty()
        {
            Console.WriteLine("Atrybuty postaci - Wybierz Atrybuty");
        }
    }

    public interface WybUmiejetnosciPostaci
    {
        void UstawUmiejetnosci();
    }

    public class UmiejetnosciPostaci : WybUmiejetnosciPostaci
    {
        public void UstawUmiejetnosci()
        {
            Console.WriteLine("Umiejętności postaci - Wybierz Umiejętności");
        }
    }

    public interface WybWygladPostaci
    {
        void UstawWyglad();
    }

    public class WygladPostaci : WybWygladPostaci
    {
        public void UstawWyglad()
        {
            Console.WriteLine("Wygląd postaci - Wybierz Wygląd");
        }
    }
}
