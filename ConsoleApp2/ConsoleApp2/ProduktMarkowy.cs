using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ProduktMarkowy : Produkt
    {
        public string Marka { get; set; }

        public override void Czytaj()
        {
            base.Czytaj();
            Console.Write("Marka=");
            Marka = Console.ReadLine();

        }
        public override void Wyswietl()
        {
            base.Wyswietl();
            Console.WriteLine($"Marka: {Marka}");
        }
    }
}
