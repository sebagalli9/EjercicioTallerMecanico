/* using NUnit.Framework;
using Library;
using System;

namespace Library.Test
{
    public class TaskTest
    {
        private Client client1;
        private Vehicle vehicle1;
        private Client client2;
        private Vehicle vehicle2;

        private Employee mechanic1;
        private Employee mechanic2;
        private Replacement repuesto1;
        private Replacement repuesto2;
        private Task task1;
        private Task task2;
        private WorkShop workShop;

        [SetUp]
        public void Setup()
        {
            //Arrange
            repuesto1 = new Replacement("Porsche", 2001, "Motor", 6000);
            repuesto2 = new Replacement("Pirelli", 2002, "Ruedas", 1000);

            mechanic1 = new Employee(1001, "Brian", "Torres", "Pintura", "Auxiliar", 100);
            mechanic2 = new Employee(1002, "Ernesto", "Lopez", "Mecanica Ligera", "Supervisor", 80);

            vehicle1 = new Vehicle(62542, "Chevrolet", "Onix", 2013, 154546);
            client1 = new Client(16384574, "Fernando Machado", 094632577, vehicle1);

            vehicle2 = new Vehicle(45217, "Porsche", "911 Carrera S", 2021, 632541);
            client2 = new Client(28735801, "Gonzalo Martinez", 096874365, vehicle2);

            task1 = new Task(client1, client1.Vehicle, new DateTime(2021, 05, 14, 17, 00, 00), "Pintura", 6, mechanic2, mechanic1);
            task2 = new Task(client2, client2.Vehicle, new DateTime(2021, 05, 18, 14, 00, 00), "Mecanica Ligera", 7, mechanic2, mechanic1);

            workShop = new WorkShop();
        }

        [Test]
        public void TaskClientIsNotNull()
        //Se prueba que el cliente de la task no sea null
        {
            //Assert
            Assert.IsNotNull(task1.Client);
        }

        [Test]
        public void AddRemplacementsToOrderForRepairs()
        //Se prueba que que el metodo para agregar repuestos a una task funcione correctamente
        {
            //Act
            task1.ReplacementNeededAdd(repuesto1);
            int cantidadRepuestosAUsarse = task1.replacementsToUse.Count;

            //Assert
            Assert.AreEqual(1, cantidadRepuestosAUsarse);
        }

        [Test]
        public void TotalCostReturnsAnInteger()
        //Se prueba que el método TotalCost() retorne un valor de tipo int
        {
            //Act
            workShop.AddTask(task1);
            //Assert
            Assert.IsInstanceOf(typeof(int), task1.TotalCost());
        }

        [Test]
        public void TotalCostExpectedCheck()
        //Se prueba que el método TotalCost() haga el cálculo correcto
        {
            //Act
            int costoTotalEsperado = 8080;
            task1.ReplacementNeededAdd(repuesto1);
            task1.ReplacementNeededAdd(repuesto2);
            int cant = task1.replacementsToUse.Count;
            int costoTotal = task1.TotalCost();
            //Assert
            Assert.AreEqual(costoTotalEsperado, costoTotal);
        }

        [Test]
        public void UniqueId()
        //Se prueba que cada task tenga un id única
        {
            //Assert
            Assert.AreNotEqual(task1.Identifier, task2.Identifier);
        }

        [Test]
        public void VehicleMustBeVehicle()
        //Se prueba que el vehiculo asignado a la task sea de tipo Vehiculo
        {
            //Assert
            Assert.IsInstanceOf(typeof(Vehicle), task1.Vehicle);
        }

        [Test]
        public void DateMustBeDateTime()
        //Se prueba que la fecha asignada a la task sea de tipo DateTime
        {
            //Assert
            Assert.IsInstanceOf(typeof(DateTime), task1.Date);
        }

        [Test]
        public void WorkTypeMustBeString()
        //Se prueba que el tipo de trabajo sea de tipo string
        {
            //Assert
            Assert.IsInstanceOf(typeof(string), task1.WorkType);
        }

        [Test]
        public void StatusMustBeString()
        //Se prueba que el estado sea de tipo string
        {
            //Assert
            Assert.IsInstanceOf(typeof(string), task1.Status);
        }

        [Test]
        //Se prueba que el mecanico auxiliar sea de tipo Employee
        public void AuxMechanicMustBeEmployee()
        {
            //Assert
            Assert.IsInstanceOf(typeof(Employee), task1.AuxMechanic);
        }

        [Test]
        //Se prueba que el mecanico supervisor sea de tipo Employee
        public void SupMechanicMustBeEmployee()
        {
            //Assert
            Assert.IsInstanceOf(typeof(Employee), task1.SupMechanic);
        }
    }
} */