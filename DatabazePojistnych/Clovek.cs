using System;
namespace DatabazePojistnych
{
    public class Clovek
    {
        /// <summary>
        /// Jméno pojistného 
        /// </summary>
        public  string Jmeno { get; set; }
        /// <summary>
        /// Přijmení pojistného
        /// </summary>
        public string Prijmeni { get; set; }
        /// <summary>
        /// Věk pojistného
        /// </summary>
        public int Vek { get; set; }
        /// <summary>
        /// Telefonní Číslo pojistného
        /// </summary>
        public int TelefonniCislo { get; set; }
        
        public Clovek() { }

        /// <summary>
        /// Konstruktor Cloveka podle jmena a prijmeni
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        public Clovek(string jmeno, string prijmeni):this()
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }
        /// <summary>
        /// Konstruktor Cloveka se všemi vlastnostmi v parametru
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="vek"></param>
        /// <param name="telefonniCislo"></param>
        public Clovek(string jmeno, string prijmeni, int vek, int telefonniCislo):this(jmeno,prijmeni)
        {
            Vek = vek;
            TelefonniCislo = telefonniCislo;
        }

        /// <summary>
        /// Vrátí textovou reprezentaci záznamu o pojistnem
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return (Jmeno + "\t" + Prijmeni +"\t"+Vek+"\t"+TelefonniCislo) ;
        }
    }
}

