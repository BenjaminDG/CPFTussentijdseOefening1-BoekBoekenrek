using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningBoekBoekenrek
{
    public class BoekenRek : IVoorwerpen
    {
        public decimal Hoogte { get; set; }
        public decimal Breedte { get; set; }
        public decimal Aankoopprijs { get; set; }

        public  decimal Winst { get { return Aankoopprijs * 2M; } }

        public void GegevensTonen()
        {
            Console.WriteLine($"Hoogte: {Hoogte}");
            Console.WriteLine($"Breedte: {Breedte}");
            Console.WriteLine($"Aankoopprijs: {Aankoopprijs} euro");
            Console.WriteLine($"Winst: {Winst} euro");
        }

        public BoekenRek(decimal hoogte, decimal breedte, decimal aankoopprijs)
        {
            this.Hoogte = hoogte;
            this.Breedte = breedte;
            this.Aankoopprijs = aankoopprijs;
        }
    }
}
