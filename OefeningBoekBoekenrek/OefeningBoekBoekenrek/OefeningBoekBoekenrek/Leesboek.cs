using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningBoekBoekenrek
{
    public class Leesboek: Boek
    {
        private string onderwerpValue;
        public string Onderwerp
        {
            get { return onderwerpValue; }
            set { onderwerpValue = value; }
        }

        public override decimal Winst { get { return Aankoopprijs * 1.5m; } }

        public override void GegevensTonen()
        {
            base.GegevensTonen();
            Console.WriteLine($"Onderwerp: {Onderwerp}");
        }

        public Leesboek(string titel, string auteur,  decimal aankoopprijs,Genre genreNaam,Doelgroep doelgroep ,string onderwerp) : base(titel, auteur, aankoopprijs, genreNaam)
        {
            Onderwerp = onderwerp;
        }
       
            
        

    }
}
