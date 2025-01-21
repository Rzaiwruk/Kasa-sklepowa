using Kasa_sklepowa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


ListaProduktow lista = new ListaProduktow();

Menu.PokazMenu();
while (true)
{
    var x = Console.ReadLine();
    int y = int.Parse(x);
    switch (y)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("Produkty: ");
            lista.WyswietlListe();
            Menu.PokazMenu();
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Podaj numer produktu, który chcesz dodać: ");
            var a = Console.ReadLine();
            int index = int.Parse(a);
            Console.WriteLine("Podaj nazwę produktu, który chcesz dodać: ");
            var nazwa = Console.ReadLine();
            Console.WriteLine("Podaj cenę produktu, który chcesz dodać: ");
            var b = Console.ReadLine();
            double cena = double.Parse(b);
            lista.Dodaj(index, nazwa, cena);
            Menu.PokazMenu();
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("Podaj numer produktu, który chcesz usunać: ");
            var c = Console.ReadLine();
            int usun = int.Parse(c);
            lista.UsunProdukt(usun);
            Menu.PokazMenu();
            break;
        case 4:
            Console.WriteLine("Dziękuję :)");
            return;
        default:
            Console.WriteLine("Podałeś złą liczbę. Podaj jeszcze raz.");
            Menu.PokazMenu();
            break;
    }
}
Console.ReadLine();
