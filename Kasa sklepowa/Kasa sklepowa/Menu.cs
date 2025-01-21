using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasa_sklepowa
{
    public class Menu
    {
        public static void PokazMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Lista produktów");
            Console.WriteLine("Co chcesz zrobić?");
            Console.WriteLine("1. Wyświetl wszystkie produkty");
            Console.WriteLine("2. Dodaj produkt");
            Console.WriteLine("3. Usuń produkt");
            Console.WriteLine("4. Wyjdź");
            Console.WriteLine();
        }
    }
}
