using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Aplikacja
    {
        Katalog k = new Katalog();
        List<Produkt> produkty = new List<Produkt>();
        Zamownienie z = new Zamownienie();

        private void Dodaj()
        {
            Produkt p = null;

            Console.WriteLine("(0-Zywnosc, 1-Napoje, 2-Elektronika, 3-Kosmetyki)");
            Console.WriteLine("?> ");
            int wybor = int.Parse(Console.ReadLine());

            switch (wybor)
            {
                case 0: p = new Zywnosc(); break;
                case 1: p = new Napoje(); break;
                case 2: p = new Elektronika(); break;
                case 3: p = new Kosmetyki(); break;
            }

            p.Czytaj();
            k.Dodaj(p);
        }

        private void Wyswietl()
        {
            k.Wyswietl();
        }

        private void Usun()
        {
            Produkt p = new Produkt();

            Console.WriteLine("(0-Zywnosc, 1-Napoje, 2-Elektronika, 3-Kosmetyki)");
            Console.WriteLine("?> ");
            int wybor = int.Parse(Console.ReadLine());

            switch (wybor)
            {
                case 0: p = new Zywnosc(); break;
                case 1: p = new Napoje(); break;
                case 2: p = new Elektronika(); break;
                case 3: p = new Kosmetyki(); break;
            }

            p.Czytaj();
            k.Usun(p);
        }

        private void Wyszukaj()
        {
            Console.WriteLine("Podaj nazwe: ");
            string nazwa = Console.ReadLine();
            List<Produkt> produkty = k.WyszukajProdukty(prod => prod.Nazwa.ToLower().Contains(nazwa.ToLower()));
            foreach (Produkt produkt in produkty)
            {
                produkt.Wyswietl();
                Console.WriteLine();
            }
        }

        private void Rachunek()
        {
            Rachunek r = new Rachunek(z);
            r.WywietlRachnek();

        }

        public void Menu()
        {
            bool koniec = false;

            while (!koniec)
            {
                Console.WriteLine("MENU:");
                Console.WriteLine("-----");
                Console.WriteLine("1. Dodaj");
                Console.WriteLine("2. Usun");
                Console.WriteLine("3. Wyswietl");
                Console.WriteLine("4. Wyszukaj");
                Console.WriteLine("5. Zamówienie");
                Console.WriteLine("6. Rachunek");
                Console.WriteLine("0. KONIEC");
                Console.WriteLine("?> ");

                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) continue; // zabezpieczenie przed wciśnienciem enter przez uzytkownika 
                int wybor = int.Parse(input);


                switch (wybor)
                {
                    case 1: Dodaj(); break;
                    case 2: Usun(); break;
                    case 3:
                        Wyswietl();
                        Console.WriteLine(); // system poczeka na wprowadzenie czegoś prze użytkownika
                        break;
                    case 4:
                        Wyszukaj();
                        Console.WriteLine();
                        break;
                    case 5: MenuZam(); break;
                    case 6: Rachunek(); break;
                    case 0: koniec = true; break;
                }

            }
        }

        public void MenuZam()
        {
            bool koniec = false;

            while (!koniec)
            {
                
                Console.WriteLine("MENU ZAMOWIENIA:");
                Console.WriteLine("-----");
                Console.WriteLine("1. Dodaj do zamowienia");
                Console.WriteLine("2. Usun w zamowieniu");
                Console.WriteLine("3. Wyswietl zamowienie");
                Console.WriteLine("0. KONIEC");
                Console.WriteLine("?> ");

                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) continue; // zabezpieczenie przed wciśnienciem enter przez uzytkownika 
                int wybor = int.Parse(input);


                switch (wybor)
                {
                    case 1:
                        Console.WriteLine("Podaj nazwe: ");
                        string nazwaR = Console.ReadLine();
                        Produkt prod = k.ZnajdzProd(nazwaR);
                        Console.WriteLine("Podaj ilosc: ");
                        int iloscR = int.Parse(Console.ReadLine());
                        z.AddProduct(prod, iloscR); break;
                    case 2:
                        Console.WriteLine("Podaj nazwe: ");
                        nazwaR = Console.ReadLine();
                        prod = k.ZnajdzProd(nazwaR);
                        Console.WriteLine("Podaj ilosc: ");
                        iloscR = int.Parse(Console.ReadLine());
                        z.RemoveProduct(prod, iloscR); break;
                    case 3:
                        z.WyswietlProdukty();
                        Console.WriteLine(); // system poczeka na wprowadzenie czegoś prze użytkownika
                        break;

                    case 0: koniec = true; break;
                }

            }
        }
    }
}
