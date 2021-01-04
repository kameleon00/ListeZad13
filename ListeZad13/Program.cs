using System;
using System.Collections.Generic;

namespace ListeZad13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kreiranje recnika
            Dictionary<string, int> automobili = new Dictionary<string, int>()
            {
                {"Kia", 2014 },
                {"Opel", 2007 },
                {"Reno", 2018 },
                {"Alfa romeo", 2018 },
                {"Honda", 2000 },
                {"Ford", 2009 }
            };
            
            // ispis elemenata recnika nakon kreiranja
            Console.WriteLine("Marke automobila i godina proizvodnje.");
            foreach (KeyValuePair<string, int> auto in automobili)
            {
                Console.WriteLine(auto.Key + " - " + auto.Value);
            }
            Console.WriteLine("=========================================");
            
            // Ispis elemenata recnika preko var (rezultat kolekcije je anonimni tip)
            Console.WriteLine("Ispis putem var funkcije.");
            foreach (var a in automobili)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("=========================================");

            // Ispis elemenata preko kljuca
            Console.WriteLine("Ispis elemenata preko kljuca.");
            foreach (var a in automobili.Keys)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("=========================================");

            // Ispis elemenata preko vrednosti
            Console.WriteLine("Ispis elemenata preko vrednosti.");
            foreach (var a in automobili.Values)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("=========================================");

            // Dodavanje elemenata u recnik sa bacanjem izuzetka
            try
            {
                automobili.Add("BMW", 2014);
                automobili.Add("Mercedes", 2019);
                automobili.Add("Toyota", 2014);
                automobili.Add("Alfa romeo", 2020); // baca izuzetak
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("=========================================");
            
            // Ispis nakon dodavanja elemenata u recnik
            Console.WriteLine("Ispis elemenata nakon dodavanja Add metodom");
            foreach (var a in automobili)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("=========================================");

            // Pretrazivanje elemenata recnika
            Console.WriteLine("Pretraga elemenata.");
            Console.WriteLine(automobili["Alfa romeo"]);
            Console.WriteLine("=========================================");

            // Pretrazivanje nepostojeceg elementa recnika
            Console.WriteLine("Pretraga nepostojeceg elementa");
            int godiste;
            bool postoji = automobili.TryGetValue("Tesla", out godiste);
            
            if(postoji)
                Console.WriteLine(godiste);
            else 
                Console.WriteLine("Trazeni automobil ne postoji");
            Console.WriteLine("=========================================");

            // Modifikovanje elementa recnika
            Console.WriteLine("Modifikovanje elemenata preko indeksa");
            automobili["BMW"] = 2000;
            Console.WriteLine("=========================================");
            
            // Ispis nakon modifikovanja elemenata recnika
            Console.WriteLine("Ispis nakon modifikovanja elementa");
            foreach (var a in automobili)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("=========================================");
            
            // Uklanjanje elementa recnika
            Console.WriteLine("Uklanjanje elementa recnika");
            Console.WriteLine(automobili.Remove("Kia"));
            Console.WriteLine("=========================================");
            
            // Ispis nakon uklanjanja elemenata recnika
            Console.WriteLine("Ispis nakon Remove metode");
            foreach (var a in automobili)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}