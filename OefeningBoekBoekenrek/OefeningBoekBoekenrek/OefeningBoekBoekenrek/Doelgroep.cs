using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningBoekBoekenrek
{
    public class Doelgroep 
    {
        private float leeftijdValue;

        public float Leeftijd
        {
            get
            {
                return leeftijdValue;
            }
            set
            {

                leeftijdValue = value;

            }
        }
        public enum Categorie
        {

            Jeugd, Volwassen

        }


        
        public Categorie categorie
        {
            get
            {
                return (Leeftijd < 18 ? Categorie.Jeugd : Categorie.Volwassen);
            }
            set { }
        }

        //public decimal Winst => throw new NotImplementedException();


        public Doelgroep( float leeftijd) 
        {
            this.Leeftijd = leeftijd;



        }
        public override string ToString()
        {


            return $" {Leeftijd} Categorie : {categorie}";


        }

    }
}
    

