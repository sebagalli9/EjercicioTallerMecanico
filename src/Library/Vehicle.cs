using System;

namespace Library
{
    public class Vehicle
    {

        //La clase Vehicle cumple con el patrón Expert ya que es experto en conocer la información necesaria 
        //para cumplir con la responsabilidad de crear un vehiculo. La clase Vehicle cumple con el principio SRP
        //ya que no hay más de una razón de cambio.

        private int vin;
        public int Vin
        {
            get
            {
                return this.vin;
            }
            set
            {
                if (value > 0)
                {
                    this.vin = value;
                }
            }
        }

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

        private string model;
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        private int age;
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value > 0)
                {
                    this.age = value;
                }
            }
        }

        private int idRegister;
        public int IdRegister
        {
            get
            {
                return this.idRegister;
            }
            set
            {
                if (value > 0)
                {
                    this.idRegister = value;
                }
            }
        }

        public Vehicle(int vin, string brand, string model, int age, int idRegister)
        {
            this.Vin = vin;
            this.Brand = brand;
            this.Model = model;
            this.Age = age;
            this.IdRegister = idRegister;
        }
    }
}