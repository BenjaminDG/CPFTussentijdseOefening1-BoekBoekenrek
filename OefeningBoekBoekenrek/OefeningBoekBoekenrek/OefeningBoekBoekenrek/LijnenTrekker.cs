using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningBoekBoekenrek
{
    class LijnenTrekker
    {

        public void TrekLijn(int lengte)
        {
            for (int teller = 0; teller < lengte; teller++)
                Console.Write('-');

            Console.WriteLine();
        }
    }
}
