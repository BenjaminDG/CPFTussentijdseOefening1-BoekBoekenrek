using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningBoekBoekenrek
{
    public  class Boek:IVoorwerpen
    {
        private string eigenaarValue;
        private decimal aankoopprijsValue;

        public string Titel { get; set; }
        public string Auteur { get; set; }
        public string Eigenaar
        {
            get { return eigenaarValue; }
            set { eigenaarValue = value; }
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
            Console.WriteLine($"Prijs: {Aankoopprijs}");
            Console.WriteLine($"Winst: {Winst}");
            Console.WriteLine($"Genre: {GenreNaam}");

            

        }
        public Boek(string titel, string auteur, string eigenaar, decimal aankoopprijs, Genre genreNaam)
        {
            this.Titel = titel;
            this.Auteur = auteur;
            this.Eigenaar = eigenaar;
            this.Aankoopprijs = aankoopprijs;
            this.GenreNaam = genreNaam;
        }
        
            
        
    }
}
