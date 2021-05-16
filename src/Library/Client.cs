using System;

namespace Library
{
    public class Client
    {   

        //La clase Client cumple con el patrón Expert ya que es experto en conocer la información necesaria 
        //para cumplir con la responsabilidad de crear un cliente. La clase Client cumple con el principio SRP
        //ya que no hay más de una razón de cambio.

        private int id;
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value != 0)
                {
                    this.id = value;
                }
            }
        }
        
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        private int contactNumber;
        public int ContactNumber
        {
            get
            {
                return this.contactNumber;
            }
            set
            {
                if (value != 0)
                {
                    this.contactNumber = value;
                }
            }
        }

        private Vehicle vehicle;
        public Vehicle Vehicle
        {
            get
            {
                return vehicle;
            }
        }

        public Client(int id, string name, int contactNumber, Vehicle vehicle)
        {
            this.Id = id;
            this.Name = name;
            this.ContactNumber = contactNumber;
            this.vehicle = vehicle;
        }
    }
}