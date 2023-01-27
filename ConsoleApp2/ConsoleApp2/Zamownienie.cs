using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Zamownienie
    {
        public Dictionary<Produkt, int> Produkty { get; set; }
        public double TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }

        public Zamownienie()
        {
            Produkty = new Dictionary<Produkt, int>();
            TotalPrice = 0;
            OrderDate = DateTime.Now;
        }

        public void AddProduct(Produkt produkt, int liczba)
        {
            if (!Produkty.ContainsKey(produkt)) Produkty[produkt] = liczba;
            else Produkty[produkt] += liczba;
            TotalPrice += produkt.Cena * liczba;
        }

        public void RemoveProduct(Produkt produkt, int liczba)
        {
            int spr = Produkty[produkt];
            if (liczba > spr)
            {
                liczba = spr;
                Produkty.Remove(produkt);
            }
            else
            {
                Produkty[produkt] -= liczba;
            }
            TotalPrice -= produkt.Cena * liczba;
        }
        public void WyswietlProdukty()
        {
            foreach(KeyValuePair<Produkt, int> p in Produkty)
            {
                Console.WriteLine($"Nazwa: {p.Key.Nazwa}, Cena: {p.Key.Cena}zł, ilosć: {p.Value}");
            }
        }
    }
}

