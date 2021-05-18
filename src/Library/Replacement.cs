using System;

namespace Library
{
    public class Replacement
    {   

        //La clase Replacement cumple con el patrón Expert ya que es experto en conocer la información necesaria 
        //para cumplir con la responsabilidad de crear un repuesto. La clase Replacement cumple con el principio SRP
        //ya que no hay más de una razón de cambio.

        private string brand;
        public string Brand
        {
            get
            {
                return this.brand;
            }
            set
            {
                this.brand = value;
            }
        }

        private int idPart;
        public int IdPart
        {
            get
            {
                return this.idPart;
            }
            set
            {
                if (value != 0)
                {
                    this.idPart = value;
                }
            }
        }

        private string description;
        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }

        private int replacementCost;
        public int ReplacementCost
        {
            get
            {
                return this.replacementCost;
            }
            set
            {
                if (value != 0)
                {
                    this.replacementCost = value;
                }
            }
        }

        public Replacement(string brand, int idPart, string description,int replacementCost)
        {
            this.Brand = brand;
            this.IdPart = idPart;
            this.Description = description;
            this.ReplacementCost = replacementCost;
        }
    }
}