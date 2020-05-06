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
                if (value >= 18)
                    leeftijdsCategorieValue = Categorie.Volwassen;
                else
                    leeftijdsCategorieValue = Categorie.Jeugd;

            }
        }
        public enum Categorie
        {

            Jeugd, Volwassen

        }


        private Categorie leeftijdsCategorieValue;
        public Categorie LeeftijdsCategorie
        {
            get
            {
                return leeftijdsCategorieValue;
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


            return $" {Leeftijd} Categorie : {LeeftijdsCategorie}";


        }

    }
}
    

