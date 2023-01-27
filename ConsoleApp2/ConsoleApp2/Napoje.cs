using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Napoje : Produkt
    {
        public double Objetosc { get; set; }

        public override void Czytaj()
        {
            base.Czytaj();
            Console.Write("Objetosc=");
            Objetosc = double.Parse(Console.ReadLine());

        }
        public override void Wyswietl()
        {
            base.Wyswietl();
            Console.WriteLine($"Objetosc: {Objetosc}ml");
        }
    }
}
