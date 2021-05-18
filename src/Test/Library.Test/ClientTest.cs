using NUnit.Framework;
using Library;

namespace Library.Test
{
  public class ClientTest
  {
    private Client client;
    private Vehicle vehicle;

    [SetUp]
    public void Setup()
    {
      //Arrange
      vehicle = new Vehicle(62542, "Chevrolet", "Onix", 2013, 154546);
      client = new Client(16384574, "Fernando Machado", 094632577, vehicle);
    }


    [Test]
    public void NameNotNull()
    //Se prueba que el nombre no sea nulo
    {
      //Assert
      Assert.IsNotNull(client.Name);
    }

    [Test]
    public void NameIsString()
    //Se prueba que el nombre sea de tipo string
    {
      //Assert
      Assert.IsInstanceOf(typeof(string), client.Name);
    }

    [Test]
    public void IdNotNull()
    //Se prueba que el ID no sea nulo
    {
      //Assert
      Assert.IsNotNull(client.Id);
    }

    [Test]
    public void IdIsInteger()
    //Se prueba que el ID sea de tipo int
    {
      //Assert
      Assert.IsInstanceOf(typeof(int), client.Id);
    }

    public void ContactNumberNotNull()
    //Se prueba que el numero de contacto no sea nulo
    {
      //Assert
      Assert.IsNotNull(client.ContactNumber);
    }

    [Test]
    public void ContactNumberIsInteger()
    //Se prueba que el numero de contacto sea de tipo int
    {
      //Assert
      Assert.IsInstanceOf(typeof(int), client.ContactNumber);
    }

    [Test]
    public void VehicleNotNull()
    //Se prueba que el vehiculo no sea null
    {
      //Assert
      Assert.IsNotNull(client.Vehicle);
    }

    [Test]
    public void VehicleIsWellInstanced()
    //Se prueba que el vehiculo sea instancia de Vehiculo
    {
      //Assert
      Assert.IsInstanceOf(typeof(Vehicle), client.Vehicle);
    }
  }
}