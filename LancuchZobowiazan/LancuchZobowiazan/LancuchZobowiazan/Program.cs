using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancuchZobowiazan
{
    public enum WielkoscLiczby
    {
        Jeden,
        Dwa,
        Trzy
    }
    class program
    {
        static void Main(string[] args)
        {
            Liczba jeden = new Jeden();
            Liczba dwa = new Dwa();
            Liczba trzy = new Trzy();

            jeden.UstawLiczbe(dwa);
            dwa.UstawLiczbe(trzy);

            List<WielkoscLiczby> Zapytanie = new List<WielkoscLiczby>
            {
                WielkoscLiczby.Jeden,
                WielkoscLiczby.Dwa,
                WielkoscLiczby.Trzy
            };

            foreach (var quest in Zapytanie)
            {
                jeden.Zadanie(quest);
            }

            Console.ReadKey();
        }
    }
}
