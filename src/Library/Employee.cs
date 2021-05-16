using System;

namespace Library
{
    public class Employee
    {

        //La clase Employee cumple con el patrón Expert ya que es experto en conocer la información necesaria 
        //para cumplir con la responsabilidad de crear un empleado. La clase Employee cumple con el principio SRP
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

        private string surName;
        public string SurName
        {
            get
            {
                return this.surName;
            }
            set
            {
                this.surName = value;
            }
        }
        
        private string workType;
        public string WorkType
        {
            get
            {
                return this.workType;
            }
            set
            {
                this.workType = value;
            }
        }

        private string role;
        public string Role
        {
            get
            {
                return this.role;
            }
            set
            {
                this.role = value;
            }
        }
        
        private int hourValue;
        public int HourValue
        {
            get
            {
                return this.hourValue;
            }
            set
            {
                if (value > 0)
                {
                    this.hourValue = value;
                }
            }
        }

        public Employee(int id, string name, string surName, string workType, string role, int hourValue)
        {
            this.Id = id;
            this.Name = name;
            this.SurName = surName;
            this.WorkType = workType;
            this.Role = role;
            this.HourValue = hourValue;
        }
    }
}