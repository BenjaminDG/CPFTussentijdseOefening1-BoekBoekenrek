﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningBoekBoekenrek
{
    public class Genre 
    {
        public string Naam { get; set; }


        public Doelgroep Doelgroep { get; set;  }

      /*  public override void GegevensTonen()
        {
            base.GegevensTonen();
            Console.WriteLine($"Naam: {Naam}");
        }*/

        public Genre (string naam, Doelgroep doelgroep)
        {
            Naam = naam;
            Doelgroep = doelgroep;
            
            
        }

        public override string ToString()
        {
            return  
                $" Genrenaam :  {Naam}    Leeftijd : {Doelgroep}"; 
        }




    }
}
