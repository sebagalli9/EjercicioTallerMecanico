using NUnit.Framework;
using Library;

namespace Library.Test
{
  public class VehicleTest
  {
    private Vehicle vehicle;

    [SetUp]
    public void Setup()
    {
      //Arrange
      vehicle = new Vehicle(62542, "Chevrolet", "Onix", 2013, 154546);
    }

    [Test]
    public void VinNotNull()
    //Prueba que el atributo "vin" del vehiculo no sea nulo.
    {
      //Assert
      Assert.IsNotNull(vehicle.Vin);
    }

    [Test]
    public void VinIsInteger()
    //Prueba que el atributo "Vin" sea un integer.
    {
      //Assert
      Assert.IsInstanceOf(typeof(int), vehicle.Vin);
    }

    [Test]
    public void BrandNotNull()
    //Prueba que el atributo "marca" del vechiculo no sea nulo.
    {
      //Assert
      Assert.IsNotNull(vehicle.Brand);
    }

    [Test]
    public void BrandIsString()
    //Prueba que el atributo "brand" sea un string.
    {
      //Assert
      Assert.IsInstanceOf(typeof(string), vehicle.Brand);
    }

    [Test]
    public void ModelNotNull()
    //Prueba que el atributo "modelo" del vechiculo no sea nulo.
    {
      //Assert
      Assert.IsNotNull(vehicle.Model);
    }

    [Test]
    public void ModelIsString()
    //Prueba que el atributo "model" sea un string.
    {
      //Assert
      Assert.IsInstanceOf(typeof(string), vehicle.Model);
    }

    [Test]
    public void AgeNotNull()
    //Prueba que el atributo "aÃ±o" del vechiculo no sea nulo.
    { 
      //Assert
      Assert.IsNotNull(vehicle.Age);
    }

    [Test]
    public void AgeIsInteger()
    //Prueba que el atributo "Age" sea un integer.

    {
      //Assert
      Assert.IsInstanceOf(typeof(int), vehicle.Age);
    }

    public void IdRegisterNotNull()
    //Prueba que el atributo idRegister del vechiculo no sea nulo.
    {
      //Assert
      Assert.IsNotNull(vehicle.IdRegister);
    }

    [Test]
    public void IdRegisterIsInteger()
    //Prueba que el atributo "idRegister" sea un integer.

    {
      //Assert
      Assert.IsInstanceOf(typeof(int), vehicle.IdRegister);
    }

    [Test]
    public void VehicleNotNull()
    //Prueba que el objeto vehiculo que se creo no sea nulo.
    {
      //Assert
      Assert.IsNotNull(vehicle);
    }

    [Test]
    public void VehicleIsWellInstanced()
    //Prueba el objeto se instancie correctamente.
    {
      //Assert
      Assert.IsInstanceOf(typeof(Vehicle), vehicle);
    }
  }
}