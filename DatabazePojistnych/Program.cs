
using System;
using System.Xml.Linq;

namespace DatabazePojistnych
{
    public class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            //hlavní cyklus
            char volba = '0';
            while (volba != 5)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Evidence pojistenych");
                Console.WriteLine("--------------------------------\n");

                Console.WriteLine("Vyberte si akci:");
                Console.WriteLine("1 - Přidat nového pojistného");
                Console.WriteLine("2 - Vypsat všechny pojistené");
                Console.WriteLine("3 - Vyhledat pojistného");
                Console.WriteLine("4 - Vymazat pojistného");
                Console.WriteLine("5 - Konec\n");
                volba = Console.ReadKey().KeyChar;
                Console.WriteLine();

                //reakce na volbu
                switch (volba)
                {
                    case '1':
                        database.PridejPojistence();
                        break;
                    case '2':
                        database.VypisPojistence();
                        break;
                    case '3':
                        database.VyhledejPojistence();
                        break;
                    case '4':
                        database.VymazPojistence();
                        break;
                    case '5':
                        Console.WriteLine("Libovolnou klávesou ukončíte program...");
                        break;
                    default:
                        Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}





