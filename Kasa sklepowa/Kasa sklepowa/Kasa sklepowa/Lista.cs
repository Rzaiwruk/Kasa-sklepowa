using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasa_sklepowa
{
    public class Produkt
    {
        public int Index { get; set; }
        public string Nazwa { get; set; }
        public double Cena { get; set; }

        public Produkt(int index, string nazwa, double cena)
        { 
            Index = index;
            Nazwa = nazwa;
            Cena = cena;
        }
    }
    public class ListaProduktow
    {
        public List<Produkt> produkty = new List<Produkt>();

        public void Dodaj(int index, string nazwa, double cena)
        {
            produkty.Add(new Produkt(index, nazwa, cena));
        }

        public void WyswietlListe()
        {
            foreach (var produkt in produkty) Console.WriteLine($"Numer: {produkt.Index} Nazwa: {produkt.Nazwa} Cena: {produkt.Cena}");
            return;
        }
    public void UsunProdukt(int index)
    {
        var usun = produkty.Find(x => x.Index == index);

            if (usun != null)
            {
                produkty.Remove(usun);
                Console.WriteLine($"Produkt o numerze {index} został usunięty.");
            }
            else Console.WriteLine($"Produkt o numerze {index} nie istnieje na liście.");
        }
    }

}
