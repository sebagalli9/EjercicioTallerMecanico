/* using NUnit.Framework;
using Library;
using System;

namespace Library.Test
{
  public class WorkshopTest
  {
    private Client client1;
    private Vehicle vehicle1;
    private Employee mechanic1;
    private Employee mechanic2;
    private Replacement repuesto1;
    private Replacement repuesto2;
    private Task task1;
    private WorkShop workShop;

    [SetUp]
    public void Setup()
    {
        //Arrange
        repuesto1 = new Replacement("Porsche",2001,"Motor",6000);
        repuesto2 = new Replacement("Pirelli",2002,"Ruedas",1000);

        mechanic1 = new Employee(1001,"Brian","Torres","Pintura","Auxiliar",100);
        mechanic2 = new Employee(1002,"Ernesto","Lopez","Mecanica Ligera","Supervisor",80);

        vehicle1 = new Vehicle(62542, "Chevrolet", "Onix", 2013, 154546);
        client1 = new Client(16384574, "Fernando Machado", 094632577, vehicle1);

        task1 = new Task(client1,vehicle1, new DateTime(2021,05,14,17,00,00),"Pintura",6, mechanic2, mechanic1);
        
        workShop = new WorkShop();
    }

    [Test]
    public void AddTaskCheck()
    //Se prueba que el método para agregar tareas funcione correctamente
    {
        //Act
        int cantidadEsperadaTareas = 1;
        workShop.AddTask(task1);
        int cantidadTareasLista = workShop.tasksListRunning.Count;
        //Assert
        Assert.AreEqual(cantidadEsperadaTareas, cantidadTareasLista);
    }

    [Test]
    public void RemoveTaskCheck()
    //Se prueba que el método para remover tareas funcione correctamente
    {
        int cantidadEsperadaTareas = 0;
        workShop.AddTask(task1);
        workShop.RemoveTask(task1);
        int cantidadTareasLista = workShop.tasksListRunning.Count;
        //Assert
        Assert.AreEqual(cantidadEsperadaTareas, cantidadTareasLista);
    }

    [Test]
    public void SupervisorChangeStatusCheck()
    //Se prueba que la actualización de tarea del supervisor funcione correctamente
    {
        //Act
        string statusEsperado = "Finalizado";
        workShop.AddTask(task1);
        workShop.SupervisorUpdateTask(mechanic2,task1);
      
        //Assert
        Assert.AreEqual(statusEsperado, task1.Status);
    }

    [Test]
    public void MechanicCannotUpdateTasks()
    //Se prueba que un mecánico no puede actualizar una tarea
    {
      //Act
      workShop.AddTask(task1);
      workShop.SupervisorUpdateTask(mechanic1,task1);
      //Assert
      Assert.IsFalse(task1.Status == "Finalizado");
    }

    [Test]
    public void ReviewTaskCheckIsNotNull()
    //Se prueba que el método para revisar tareas no retorne null
    {
        //Act
        workShop.AddTask(task1);
        string orderReview = workShop.ReviewTask(workShop.tasksListRunning);

        //Assert
        Assert.IsNotNull(orderReview);
      
    } 

    [Test]
    public void ReviewTaskIsString()
    //Se prueba que el método para revisar tareas retorne un valor de tipo string
    {
        workShop.AddTask(task1);
        string orderReview = workShop.ReviewTask(workShop.tasksListRunning);
        //Assert
        Assert.IsInstanceOf(typeof(string),orderReview);
    }

    [Test]
    public void AddRemplacementCheck()
    //Se prueba que se agregue correctamente un repuesto al inventario del workshop
    {
      //Act
        int cantidadRepuestosActualizado = 1;
        workShop.AddReplacementToWorkShopInventory(repuesto1);
        int cantidadRepuestosLista = workShop.workShopInventory.Count;
        //Assert
        Assert.AreEqual(cantidadRepuestosActualizado, cantidadRepuestosLista);
      
    }

    [Test]
    public void RemoveRemplacementCheck()
    //Se prueba que se remueva correctamente un repuesto del inventario del workshop
    {
      //Act
        int cantidadRepuestosActualizado = 0;
        workShop.AddReplacementToWorkShopInventory(repuesto1);
        workShop.RemoveReplacementFromWorkShopInventory(repuesto1);
        int cantidadRepuestosLista = workShop.workShopInventory.Count;
        //Assert
        Assert.AreEqual(cantidadRepuestosActualizado, cantidadRepuestosLista);
      
    }

    [Test]
    public void NotOverstackMoreThanTwoTasksInRunningListCheck()
    //Se prueba que no pueda haber más de dos tareas en proceso al mismo tiempo
    {
      //Act
        workShop.AddTask(task1);
        workShop.AddTask(task1);
        workShop.AddTask(task1);

        int cantidadTareasRunningList = workShop.tasksListRunning.Count;
        int maximaCatidadTareas = 2;

        //Assert
        Assert.AreEqual(cantidadTareasRunningList, maximaCatidadTareas);
    }
  }
}  */