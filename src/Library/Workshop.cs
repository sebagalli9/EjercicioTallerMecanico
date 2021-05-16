/* using System;
using System.Collections.Generic;

namespace Library
{
    public class WorkShop
    {

        //La clase WorkShop cumple con el patrón Expert ya que es experto en conocer la información necesaria 
        //para cumplir con la responsabilidad de agregar, remover, actualizar y revisar tareas. 
        //Además, de conocer el inventario de repuestos disponibles.
        
        //La clase WorkShop no cumple con el principio SRP ya que tiene más de una razón de cambio, algunas de las cuales pueden ser:
        //- Cambiar el modo en que se agregan nuevas tareas.
        //- Cambiar el modo en que se actualizan las tareas.
        //- Cambiar el modo en que se revisan las tareas.

        public List<Task> tasksListRunning = new List<Task>();
        public List<Task> tasksListDone = new List<Task>();
        public List<Task> tasksListWaiting = new List<Task>();
        public List<Replacement> workShopInventory = new List<Replacement>();

        private string allLines;
        private string allTasks;
        private int maxTaskAvailable = 2;
        
        public void AddTask(Task task)
        {    
                if(tasksListRunning.Count == 0)
                {
                    task.Status = "En curso.";
                    tasksListRunning.Add(task);
                    Console.WriteLine($"Se ha añadido la tarea ´{task.Identifier}`. Ha ingresado al taller.");
                    
                }
                else if(tasksListRunning.Count == 1)
                {
                    task.Status = "En curso.";
                    tasksListRunning.Add(task);
                    Console.WriteLine($"Se ha añadido la tarea ´{task.Identifier}`. Ha ingresado al taller.");
                }
                else if(tasksListRunning.Count >= maxTaskAvailable)
                {   
                    task.Status = "Planificada.";
                    tasksListWaiting.Add(task);
                    Console.WriteLine($"Se ha añadido la tarea ´{task.Identifier}`. Ha ingresado a la lista de espera del taller. Espere.");
                }
        }
        public void RemoveTask(Task task)
        {   
            if(tasksListWaiting.Count != 0)
            {
                tasksListRunning.Remove(task);
                tasksListRunning.Add(tasksListWaiting[0]);
                Console.WriteLine($"Se ha removido la tarea {task.Identifier} y se ha agregado desde la lista de espera a la tarea {tasksListWaiting[0].Identifier}");
                tasksListWaiting.RemoveAt(0);
            }
            else 
            {
               tasksListRunning.Remove(task); 
               Console.WriteLine($"Se ha removido la tarea {task.Identifier}.");
            }
        }
        public void SupervisorUpdateTask(Employee mechanic, Task task)
        {  

            if(mechanic.Role == "Supervisor")
            {
                if(tasksListRunning.Contains(task))
                {
                    string status = "Finalizado";
                    task.Status = status;
                    string mechanicNameSurName = mechanic.Name + " " + mechanic.SurName;

                    Console.WriteLine($"El status de la tarea ´{task.Identifier}` ha sido modificado a ´{status}` por el supervisor ´{mechanicNameSurName}`.");
                
                    tasksListDone.Add(task);
                    RemoveTask(task);
                
                }
                else if(tasksListWaiting.Contains(task))
                {
                    Console.WriteLine($"El status de ´{task.Identifier}` no ha sido modificado ya que se encuentra en la lista de espera en la posicion ´{tasksListWaiting.IndexOf(task)}`.");
                }
            }
            else
            {
               Console.WriteLine("Solamente un Supervisor puede actualizar una tarea"); 
            } 
        }
        
        public string ReviewTask(List<Task> taskList)
        {
            foreach (Task task in taskList)
            {
                string line1 = "";
                string line2 = "";
                string line3 = "";
                string clientData = "";

                line1 += " Nro. Identificador: " + task.Identifier.ToString() + " Fecha: " + task.Date.ToString() + " Tipo de Trabajo: " + task.WorkType + " Repuestos requeridos: ";

                foreach (Replacement repuesto in task.replacementsToUse)
                {
                    line2 += repuesto.IdPart + " - " + repuesto.Description + "; ";
                }

                line3 += " Status: " + task.Status + " Mecanico Superior: " + task.SupMechanic.Name + " " + task.SupMechanic.SurName + "; " + task.AuxMechanic.Name + " " + task.AuxMechanic.SurName + " " + "Costo total: " + task.TotalCost().ToString();

                clientData = "Cliente : " + task.Client.Name + " Vehiculo: Marca: " + task.Client.Vehicle.Brand + " - Modelo: " + task.Client.Vehicle.Model + " - VIN: " + task.Client.Vehicle.Vin;

                allLines += clientData + line1 + line2 + line3 + "\n";
            }
            return allLines + "\n";
        }
        
        public string ReviewAllTask()
        {   
            allTasks = ReviewTask(tasksListRunning) + ReviewTask(tasksListWaiting) + ReviewTask(tasksListDone);
            
            return allTasks;
        }

        public void AddReplacementToWorkShopInventory(Replacement replacement)
        {
            workShopInventory.Add(replacement);
            Console.WriteLine($"Se ha añadido el repuesto {replacement.IdPart} al inventario.");
        }
        public void RemoveReplacementFromWorkShopInventory(Replacement replacement)
        {
            workShopInventory.Remove(replacement);
            Console.WriteLine($"Se ha removido el repuesto {replacement.IdPart} del inventario.");
        }

    }
} */