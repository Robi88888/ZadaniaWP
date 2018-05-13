using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class program
{
    static void Main(string[] args)
    {
        Krol krol = new Krol("Bolesław", "Chrobry", "Władca Polan");
        krol.DodajPoddanego(new Poddany("Mścigniew", "Płocki", "Kasztelan Płocka"));
        krol.DodajPoddanego(new Poddany("Dobromir", "Łęczycki", "Kasztelan Łęczycy"));
        krol.DodajPoddanego(new Poddany("Miecław", "Kaliski", "Kasztelan Kalisza"));

        krol.InformacjeOPoddanym();
        Console.ReadKey();
    }
}