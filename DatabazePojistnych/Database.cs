using System.Collections.Generic;
using System.Xml.Linq;

namespace DatabazePojistnych
{
    public class Database
    {
        private List<Clovek> pojistenci;
        private string pokracuj = "Pokračujte libovolnou klávesou...";
        private string znovu = " znovu: ";
        private string zadejJmeno = "Zadejte jméno pojistného";
        private string zadejPrijmeni = "Zadejte příjmení";
        private string zadejTelefon = "Zadej telefonní číslo ";
        private string zadejVek = "Zadej věk";

        public Database() => pojistenci = new List<Clovek>();


        public void Zjisti(out string jmeno,out string prijmeni)
        {
            //Jméno
            Console.WriteLine(zadejJmeno + ":");
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))
            {
                Console.WriteLine(zadejJmeno + znovu);
            }
            Console.WriteLine("");
            jmeno = jmeno.Trim();

            //Příjmení 
            Console.WriteLine(zadejPrijmeni + ":");
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
            {
                Console.WriteLine(zadejPrijmeni + znovu);
            }
            Console.WriteLine("");
            prijmeni = prijmeni.Trim();
        }

        //Přidání pojištence do databaze podle Jmena a Přijmeni
        public void PridejPojistence( )
        {
            Zjisti(out string jmeno, out string prijmeni);

            //Telefonní číslo
            Console.WriteLine(zadejTelefon+":");
            string telefonniCislo = "";
            int telCislo;
            while (true)
            {
               telefonniCislo =Console.ReadLine().Trim();
                if (!int.TryParse(telefonniCislo, out telCislo))
                    Console.WriteLine(zadejTelefon + znovu);
                else
                    break;
            }

            //Vek
            Console.WriteLine(zadejVek+":");
            string vek = "";
            int vekPojistneho;
            while (true)
            {
                vek = Console.ReadLine().Trim();
                if (!int.TryParse(vek, out vekPojistneho))
                    Console.WriteLine(zadejVek + znovu);
                else
                    break;
            }

            pojistenci.Add(new Clovek(jmeno, prijmeni, vekPojistneho, telCislo));
            Console.WriteLine("Data byla uložená...");
            Console.WriteLine(pokracuj);
        }
        //Vyhledání pojištence v databazi podle Jmena a Přijmeni
        public Clovek VyhledejPojistence()
        {
            Zjisti(out string jmeno, out string prijmeni);

            Clovek nalezen = pojistenci.Where(x => x.Jmeno == jmeno && x.Prijmeni == prijmeni).FirstOrDefault();

            if (nalezen != null)
            {
                Console.WriteLine(nalezen);
                return nalezen;
            }
            else
            {
                Console.WriteLine("Osoba nebyla nalezena!");
            }
            return null;
            //Nenalezeno
            //throw new Exception("Osoba nebyla nalezena!");
        }

        //Vymazání pojištence z databaze podle Jmena a Přijmeni
        public void VymazPojistence()
        {
            Clovek clovekProVymazani = VyhledejPojistence();
            Console.WriteLine("Bude vymazán daný pojištenec: ");
            Console.WriteLine(clovekProVymazani);
            pojistenci.Remove(clovekProVymazani);
        }
        // všech pojištenců databaze
        public void VypisPojistence()
        {
            foreach (Clovek c in pojistenci)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine(pokracuj);   
        }
    }
}

