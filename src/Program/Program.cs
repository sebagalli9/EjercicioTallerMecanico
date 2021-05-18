using System;
using Library;

namespace Taller
{
    class Program
    {
        static void Main(string[] args)
        {   
            WorkShop workShop = new WorkShop();

            //Mecanicos del taller.
            Employee mechanic1 = new Employee(1001,"Brian","Torres","Pintura","Auxiliar",100);
            Employee mechanic2 = new Employee(1002,"Ernesto","Lopez","Mecanica Ligera","Auxiliar",80);
            Employee mechanic3 = new Employee(1003,"Marcelo","Gonzalez","Gomeria","Auxiliar",90);
            Employee mechanic4 = new Employee(1004,"Guzman","Lopez","Electricista","Supervisor",160);
            Employee mechanic5 = new Employee(1005,"Gonzalo","Roballo","Diseño","Supervisor",190);
            Employee mechanic6 = new Employee(1006,"Pedro","Hernandez","Carrocería","Supervisor",250);

            //Repuestos añadidos a la lista respuestos.
            Replacement repuesto1 = new Replacement("Porsche",2001,"Motor",6000);
            workShop.AddReplacementToWorkShopInventory(repuesto1);
            Replacement repuesto2 = new Replacement("Pirelli",2002,"Ruedas",1000);
            workShop.AddReplacementToWorkShopInventory(repuesto2);
            Replacement repuesto3 = new Replacement("Chevrolet",2003,"Suspension",1500);
            workShop.AddReplacementToWorkShopInventory(repuesto3);
            Replacement repuesto4 = new Replacement("Chevrolet",2004,"Radiador",600);
            workShop.AddReplacementToWorkShopInventory(repuesto4);
            Replacement repuesto5 = new Replacement("Ancap",2005,"Lubricante",300);
            workShop.AddReplacementToWorkShopInventory(repuesto5);
            Replacement repuesto6 = new Replacement("Chevrolet",2006,"Correa Disribucion",800);
            workShop.AddReplacementToWorkShopInventory(repuesto6);
            Replacement repuesto7 = new Replacement("LaClinica",2007,"Tapizado",200);
            workShop.AddReplacementToWorkShopInventory(repuesto7);
            Replacement repuesto8 = new Replacement("GMC",2008,"Transmision Manual",3000);
            workShop.AddReplacementToWorkShopInventory(repuesto8);
            Replacement repuesto9 = new Replacement("Porsche",2009,"Transmision Automatica",4000);
            workShop.AddReplacementToWorkShopInventory(repuesto9);
            Replacement repuesto10 = new Replacement("Boss",2010,"Parlantes",600);
            workShop.AddReplacementToWorkShopInventory(repuesto10);
            Replacement repuesto11 = new Replacement("Chevrolet",2011,"Motor",5000);
            workShop.AddReplacementToWorkShopInventory(repuesto11);
            Replacement repuesto12= new Replacement("Porsche",2012,"Frenos",3000);
            workShop.AddReplacementToWorkShopInventory(repuesto12);
            Replacement repuesto13 = new Replacement("Porsche",2013,"Suspension",1800);
            workShop.AddReplacementToWorkShopInventory(repuesto13);
            Replacement repuesto14 = new Replacement("Fiat",2014,"Ejes con transmision",6000);
            workShop.AddReplacementToWorkShopInventory(repuesto14);
            Replacement repuesto15 = new Replacement("Fiat",2015,"Electronica",4000);
            workShop.AddReplacementToWorkShopInventory(repuesto15);
            Replacement repuesto16 = new Replacement("Fiat",2016,"Luces",500);
            workShop.AddReplacementToWorkShopInventory(repuesto16);

            Console.WriteLine("");
            Console.WriteLine("");
            //Remover Repuesto.
            workShop.RemoveReplacementFromWorkShopInventory(repuesto16);

            //Clientes
            Client client1 = new Client(16384574,"Fernando Machado",094632577, new Vehicle(62542,"Chevrolet","Onix",2013,154546));
            Client client2 = new Client(14523688,"Eduardo Lopez",099563214, new Vehicle(55265,"Porsche","911 Turbo S",2021,154546));
            Client client3 = new Client(28783562,"Bruno Hiriat",0939658474, new Vehicle(64897,"Porsche","Cayenne GTS",2021,154546));
            Client client4 = new Client(57274983,"Federico Martino ",099548752, new Vehicle(98874,"Fiat","147",1976,154546));
            Console.WriteLine("");
            Console.WriteLine("");

            //Añadir Tareas.
            Task task1 = new Task(client1,client1.Vehicle, new DateTime(2021,05,14,17,00,00),"Pintura",6, mechanic4, mechanic1);
            workShop.AddTask(task1);
            task1.ReplacementNeededAdd(repuesto11);
            task1.ReplacementNeededAdd(repuesto4);
            Task task2 = new Task(client2,client2.Vehicle,new DateTime(2021,05,15,12,00,00),"Mecanica Ligera",4, mechanic5, mechanic2);
            workShop.AddTask(task2);
            task2.ReplacementNeededAdd(repuesto6);
            task2.ReplacementNeededAdd(repuesto12);
            task2.ReplacementNeededAdd(repuesto13);
            Task task3 = new Task(client3,client3.Vehicle,new DateTime(2021,05,16,16,00,00),"Gomería",9, mechanic6, mechanic3);
            workShop.AddTask(task3);
            task3.ReplacementNeededAdd(repuesto2);
            Task task4 = new Task(client4,client4.Vehicle,new DateTime(2021,05,17,11,00,00),"Mecánica Ligera",7, mechanic6, mechanic2);
            workShop.AddTask(task4);
            task4.ReplacementNeededAdd(repuesto14);
            task4.ReplacementNeededAdd(repuesto15);
            Console.WriteLine("");
            Console.WriteLine("");
            //Supervisores inician tareas
            workShop.SupervisorUpdateTask(mechanic4,task1);
            workShop.SupervisorUpdateTask(mechanic5,task2);
            workShop.SupervisorUpdateTask(mechanic6,task3);
            workShop.SupervisorUpdateTask(mechanic6,task4);
            Console.WriteLine("");
            Console.WriteLine("");
            //Ver todas las tareas del taller.
            Console.WriteLine(workShop.ReviewAllTask());
           
        }
    }
}