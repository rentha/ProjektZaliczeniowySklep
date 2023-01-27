# ProjektZaliczeniowySklep

Zadanie 3

Zaprojektować i wykonać obiektowy system zarządzania sklepem. Podstawowe założenia podano poniżej:


1.	System powinien posiadać obiekty podstawowe: 
•	Produkt (charakteryzuje pojedynczy produkt w sklepie)
•	Kategoria (przechowuje produkty z określonej kategorii, np. napoje, kosmetyki, zabawki, itp.), KATALOG
•	Asortyment (przechowuje asortyment sklepu z podziałem na kategorie)
•	Zamówienie (opisuje pojedyncze zamówienie użytkownika)
•	Rachunek (opisuje rachunek za zamówienie: faktura lub paragon)
•	Aplikacja (główny obiekt zapewniający interakcję z użytkownikiem)
2.	Dziedziczenie: zaprojektować obiekty potomne od obiektu typu Produkt będące typami produktów, np. ProduktSpożywczy, ProduktMarkowy, ProduktElectro, itp. Można też zaprojektować obiekty potomne Faktura i Paragon od obiektu Rachunek.
3.	Umożliwić podstawowe operacje na Produkcie, Kategoriach, Asortymencie, Zamówieniach i Rachunkach. Do podstawowych operacji zaliczamy:
1)	Dodawanie obiektu/kolekcji obiektów
2)	Usuwanie obiektu/kolekcji obiektów
3)	Wyświetlanie obiektu/kolekcji obiektów
4)	Wyszukiwanie/Filtrowanie obiektu/kolekcji obiektów
4)	Funkcje dodatkowe programu (na ocenę powyżej 4.0)
1.	Zaprojektować i zaimplementować interfejsy. Całość systemu oprzeć na interfejsach
2.	Wykonać zapis i odczyt do pliku/plików (utrwalanie danych)
3.	Wykorzystać mechanizmy „Dependency Injection”, np. Singleton, Fabryka, Dekorator (np. dekoratory przy wprowadzeniu operatorów and/or przy wyszukiwaniu)
