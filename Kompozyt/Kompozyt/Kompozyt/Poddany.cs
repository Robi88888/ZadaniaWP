using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    interface Poddani
    {
        void InformacjeOPoddanym();
    }


class Poddany : Poddani
{
    private string Imie, Przydomek, Godnosc;

    public Poddany(string imie, string przydomek, string godnosc)
    {
        Imie = imie;
        Przydomek = przydomek;
        Godnosc = godnosc;
    }

    public void InformacjeOPoddanym()
    {
        Console.WriteLine("Poddani: " + Imie + " " + Przydomek);
    }
}


class Krol : Poddani
{
    private string Imie, Przydomek, Godnosc;
    private List<Poddani> poddanii = new List<Poddani>();

    public Krol(string imie, string przydomek, string godnosc)
    {
        Imie = imie;
        Przydomek = przydomek;
        Godnosc = godnosc;
    }

    public void DodajPoddanego(Poddani poddany)
    {
        poddanii.Add(poddany);
    }

    public void InformacjeOPoddanym()
    {
        Console.WriteLine("Poddani: " + Imie + " " + Przydomek);
        foreach (Poddani poddany in poddanii)
        {
            poddany.InformacjeOPoddanym();
        }
    }
}