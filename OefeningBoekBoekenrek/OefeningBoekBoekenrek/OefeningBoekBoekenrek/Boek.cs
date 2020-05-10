using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningBoekBoekenrek
{
    public  class Boek:IVoorwerpen
    {
        
        private decimal aankoopprijsValue;

        public string Titel { get; set; }
        public string Auteur { get; set; }
        public static string Eigenaar
        {
            get { return "VDAB"; }
            
        }
        public decimal Aankoopprijs
        {
            get { return aankoopprijsValue; }
            set{ aankoopprijsValue = value; }
        }

        public Genre GenreNaam { get; set; }

        public virtual decimal Winst { get; }

        public virtual void GegevensTonen()
        {
            Console.WriteLine($"Titel: {Titel}");
            Console.WriteLine($"Auteur: {Auteur}");
            Console.WriteLine($"Eigenaar: {Eigenaar}");
            Console.WriteLine($"Prijs: {Aankoopprijs} euro");
            Console.WriteLine($"Winst: {Winst} euro");
            Console.WriteLine($"Genre Gegevens :");
            Console.WriteLine($"Genre : {GenreNaam.Naam}");
            Console.WriteLine($"Doelgroepgegevens: ");
            Console.WriteLine($"Leeftijd : {GenreNaam.Doelgroep.Leeftijd}");
            Console.WriteLine($"Categorie : {GenreNaam.Doelgroep.categorie}");


        }
        public Boek(string titel, string auteur, decimal aankoopprijs, Genre genreNaam)
        {
            this.Titel = titel;
            this.Auteur = auteur;
            
            this.Aankoopprijs = aankoopprijs;
            this.GenreNaam = genreNaam;
        }
        
            
        
    }
}
