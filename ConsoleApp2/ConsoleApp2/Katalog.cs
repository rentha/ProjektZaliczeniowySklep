using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Katalog
    {
        List<Produkt> produkty;

        public Katalog()
        {
            produkty = new List<Produkt>();
        }

        public void Dodaj(Produkt p)
        {
            produkty.Add(p);
        }

        public void Wyswietl()
        {
            Console.WriteLine("PRODUKTY:");
            Console.WriteLine("---------");
            foreach (Produkt p in produkty)
            {
                p.Wyswietl();
                Console.WriteLine("---------");
            }
        }

        public void Usun(Produkt p) 
        {
            produkty.Remove(p);
        }


        public List<Produkt> WyszukajProdukty(Predicate<Produkt> predicate)
        {            
            return produkty.FindAll(predicate);        
        }

        public Produkt ZnajdzProd(string nazwa)
        {
            return produkty.FirstOrDefault(prod => prod.Nazwa.Equals(nazwa));
        }
    }

}
