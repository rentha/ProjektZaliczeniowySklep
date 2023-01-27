using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Zywnosc : Produkt
    {
        public double Waga { get; set; } // waga kg
        public double Objetosc { get; set; }

        public string Markowe { get; set; }

        public override void Czytaj()
        {
            base.Czytaj();
            Console.Write("Waga=");
            Waga = double.Parse(Console.ReadLine());
            Console.Write("Objetosc=");
            Objetosc = double.Parse(Console.ReadLine());
            Console.Write("Produkty Markowe=");
            Markowe = Console.ReadLine();

        }
        public override void Wyswietl()
        {
            base.Wyswietl();
            Console.WriteLine($"Waga: {Waga}kg");
            Console.WriteLine($"Objetosc: {Objetosc}ml");
            Console.WriteLine($"Produkty Markowe: {Markowe}");
        }
    }
}
