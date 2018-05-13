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
}
