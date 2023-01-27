using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Rachunek
    {
        public Zamownienie Zamowienie { get; set; }



        public Rachunek(Zamownienie zamownienie)
        {
            Zamowienie = zamownienie;
        }

        public Rachunek()
        {

        }

        public void WywietlRachnek()
        {
            Zamowienie.WyswietlProdukty();
            Console.WriteLine($"Całkowita cena zamowienia: {Zamowienie.TotalPrice}zł");

        }
    }

 }
