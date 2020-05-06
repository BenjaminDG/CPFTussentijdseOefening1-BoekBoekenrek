using System;

namespace OefeningBoekBoekenrek
{
    class Program
    {
        static void Main(string[] args)
        {

            Doelgroep LeeftijdLees = new Doelgroep( 15);
            Doelgroep LeeftijdWoord = new Doelgroep(20);
            Genre Fictie = new Genre("Fictie", LeeftijdLees);
            Genre Vreemd = new Genre("Vreemd", LeeftijdWoord);
            
            IVoorwerpen[] voorwerpen = new IVoorwerpen[3];
            voorwerpen[0] = new Leesboek("Harry Potter", "J.K Rowling","VDAB",20M, Fictie, LeeftijdLees,"Toveren");
            voorwerpen[1] = new Woordenboek("Vandale", "Kramers","VDAB",100m, Vreemd, LeeftijdWoord,"NL-E");
            voorwerpen[2] = new BoekenRek(2.5M, 3M, 200);
            LijnenTrekker lijnenTrekker = new LijnenTrekker(); 

            lijnenTrekker.TrekLijn(30);

            
            foreach (IVoorwerpen voorwerp in voorwerpen)
            {
                voorwerp.GegevensTonen();
                lijnenTrekker.TrekLijn(30);

            }

        }
    }
}
