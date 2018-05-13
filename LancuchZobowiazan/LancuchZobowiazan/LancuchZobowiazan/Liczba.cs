using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancuchZobowiazan
{
    abstract class Liczba
    {
        protected Liczba liczba;

        public void UstawLiczbe(Liczba liczba)
        {
            this.liczba = liczba;
        }

        public abstract void Zadanie(WielkoscLiczby wielkoscliczby); // Zadanie -> Żądanie :P
    }
}
