using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Produkt
    {
        public string Nazwa { get; set; }
        public int Cena { get; set; }

        public virtual void Czytaj() // funkacja wirtualna
        {
            Console.Write("Nazwa=");
            Nazwa = Console.ReadLine();
            Console.Write("Cena=");
            Cena = int.Parse(Console.ReadLine());
        }

        public virtual void Wyswietl()
        {
            Console.WriteLine($"Nazwa: {Nazwa}");
            Console.WriteLine($"Cena: {Cena}zł");
        }
    }
}
