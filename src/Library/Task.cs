using System;
using System.Collections.Generic;

namespace Library
{
    public class Task
    {

        //La clase Task cumple con el patrón Expert ya que es experto en conocer la información necesaria 
        //para cumplir con la responsabilidad de crear una task, conocer los repuestos necesarios para realizar una task,
        //calcular el costo total y generar la id unica de cada task.  
        
        //La clase Task no cumple con el principio SRP ya que tiene más de una razón de cambio:
        //-El cómo se puede calcular el costo total.
        //-La forma de agregar repuestos.
        //-El cómo generar ID's unicas.
        
        
        private int identifier;
        public int Identifier
        {
            get
            {
                return this.identifier;
            }
            set
            {
                this.identifier = value;
            }
        }
        private DateTime date;
        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
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
        private int workHour;
        public int WorkHour
        {
            get
            {
                return this.workHour;
            }
            set
            {
                if (value != 0)
                {
                    this.workHour = value;
                }
            }
        }
        private string status;
        public string Status
        {
            get
            {
                return this.status;
            }
            set
            {
                this.status = value;
            }
        }
        
        private Employee auxMechanic;
        public Employee AuxMechanic
        {
            get
            {
                return auxMechanic;
            }
        }
        private Employee supMechanic;
        public Employee SupMechanic
        {
            get
            {
                return supMechanic;
            }
        }
        private Client client;
        public Client Client
        {
            get
            {
                return client;
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
        
        public List<Replacement> replacementsToUse;

        private int totalCost;
        private int replacementCostInUse;
        private int totalCostMechanicAux;
        private int totalCostMechanicSup;
        private int totalCostMechanic;
        private static int counter = 9000;

        public Task(Client client, Vehicle vehicle, DateTime date, string workType, int workHour, Employee supMechanic, Employee auxMechanic)
        {
            this.Identifier = IdGenerator();
            this.client = client;
            this.vehicle = client.Vehicle;
            this.Date = date;
            this.WorkType = workType;
            this.WorkHour = workHour;
            this.Status = "";
            this.auxMechanic = auxMechanic;
            this.supMechanic = supMechanic;
            this.replacementsToUse = new List<Replacement>();
            this.totalCost = TotalCost();
            
        }
        
        public int IdGenerator()
        {
            counter += 1;
            return counter;
        }

        public void ReplacementNeededAdd(Replacement replacement)
        {
            this.replacementsToUse.Add(replacement);
        }

        public int TotalCost()
        {
            if(replacementsToUse.Count != 0)
                {
                    foreach (Replacement element in replacementsToUse)
                    {
                        replacementCostInUse += element.ReplacementCost;
                    }

                    totalCostMechanicAux = (this.workHour * auxMechanic.HourValue);
                    totalCostMechanicSup = (this.workHour * supMechanic.HourValue);
                    totalCostMechanic = totalCostMechanicAux + totalCostMechanicSup;

                    totalCost = replacementCostInUse + totalCostMechanic;
                }
            else if(replacementsToUse.Count == 0)
            {
                replacementCostInUse = 0;
                totalCostMechanicAux = (this.workHour * auxMechanic.HourValue);
                totalCostMechanicSup = (this.workHour * supMechanic.HourValue);
                totalCostMechanic = totalCostMechanicAux + totalCostMechanicSup;

                totalCost = replacementCostInUse + totalCostMechanic;
            }
            return totalCost;
        }
    }
}