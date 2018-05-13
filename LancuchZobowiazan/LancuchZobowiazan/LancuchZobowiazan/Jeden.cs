using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancuchZobowiazan
{
    class Jeden : Liczba
    {
        public override void Zadanie(WielkoscLiczby wielkoscliczby)
        {
            if(wielkoscliczby == WielkoscLiczby.Jeden)
            {
                Console.WriteLine("Pierwsze żądanie");
            }
            else if(liczba != null)
            {
                liczba.Zadanie(wielkoscliczby);
            }
        }
    }

    class Dwa : Liczba
    {
        public override void Zadanie(WielkoscLiczby wielkoscliczby)
        {
            if (wielkoscliczby == WielkoscLiczby.Dwa)
            {
                Console.WriteLine("Drugie żądanie");
            }
            else if (liczba != null)
            {
                liczba.Zadanie(wielkoscliczby);
            }
        }
    }

    class Trzy : Liczba
    {
        public override void Zadanie(WielkoscLiczby wielkoscliczby)
        {
            if (wielkoscliczby == WielkoscLiczby.Trzy)
            {
                Console.WriteLine("Trzecie żądanie");
            }
            else if (liczba != null)
            {
                liczba.Zadanie(wielkoscliczby);
            }
        }
    }
}
