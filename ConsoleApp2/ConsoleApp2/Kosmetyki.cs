using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Kosmetyki : ProduktMarkowy
    {
        public enum RodzajKosmetykow { Perfum, Woda, Dezodorant }
        public RodzajKosmetykow Typ { get; set; }

        public override void Czytaj()
        {
            base.Czytaj();
            Console.WriteLine("Typ (0-Perfum, 1-Woda, 2-Dezodorant): ");
            Typ = (RodzajKosmetykow)int.Parse(Console.ReadLine());
        }
        public override void Wyswietl()
        {
            base.Wyswietl();
            Console.WriteLine($"Typ: {Typ}");
        }
    }
}
