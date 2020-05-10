using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningBoekBoekenrek
{
    public class Woordenboek : Boek
    {
        private string taalValue;
        public string Taal
        {
            get { return taalValue; }
            set { taalValue = value; }
        }

        public override decimal Winst {get{ return Aankoopprijs * 1.75m; } }

        public override void GegevensTonen()
        {
            base.GegevensTonen();
            Console.WriteLine($"Taal: {Taal}");
        }

        public Woordenboek(string titel, string auteur, decimal aankoopprijs,Genre genreNaam, Doelgroep doelgroep,string taal) : base(titel, auteur, aankoopprijs, genreNaam)
        {
            Taal = taal;
        }
    }
}
