using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Elektronika : ProduktMarkowy
    {
        public double Moc { get; set; }

        public override void Czytaj()
        {
            base.Czytaj();
            Console.Write("Moc(W)=");
            Moc = double.Parse(Console.ReadLine());

        }
        public override void Wyswietl()
        {
            base.Wyswietl();
            Console.WriteLine($"Moc: {Moc}W");
        }
    }
}
