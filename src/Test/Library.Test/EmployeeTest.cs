using NUnit.Framework;
using Library;

namespace Library.Test
{
  public class EmployeeTest
  {
    private Employee mechanic;

    [SetUp]
    public void Setup()
    {
      //Arrange
      this.mechanic = new Employee(1002,"Ernesto","Lopez","Mecanica Ligera","Auxiliar",80);
    }


    [Test]
    public void NameNotNull()
    //Se prueba que el nombre no sea nulo
    {
      //Assert
      Assert.IsNotNull(mechanic.Name);
    }

    [Test]
    public void NameIsString()
    //Se prueba que el nombre sea de tipo string
    {
      //Assert
      Assert.IsInstanceOf(typeof(string), mechanic.Name);
    }

    [Test]
    public void IdNotNull()
    //Se prueba que el ID no sea null
    {
      //Assert
      Assert.IsNotNull(mechanic.Id);
    }

    [Test]
    public void IdIsInteger()
    //Se prueba que el ID sea de tipo int
    {
      //Assert
      Assert.IsInstanceOf(typeof(int), mechanic.Id);
    }

    public void SurnameNotNull()
    //Se prueba que el apellido no sea null
    {
      //Assert
      Assert.IsNotNull(mechanic.SurName);
    }

    [Test]
    public void SurnameIsString()
    //Se prueba que el apellido sea string
    {
      //Assert
      Assert.IsInstanceOf(typeof(string), mechanic.SurName);
    }

    [Test]
    public void WorkTypeNotNull()
    //Se prueba que el tipo de trabajo no sea null
    {
      //Assert
      Assert.IsNotNull(mechanic.WorkType);
    }

    [Test]
    public void WorkTypeIsString()
    //Se prueba que el tipo de trabajo sea de tipo string
    {
      //Assert
      Assert.IsInstanceOf(typeof(string), mechanic.WorkType);
    }

    [Test]
    public void RoleNotNull()
    //Se prueba que el rol no sea null
    {
      //Assert
      Assert.IsNotNull(mechanic.Role);
    }

    [Test]
    public void RoleIsString()
    //Se prueba que el rol sea de tipo string
    {
      //Assert
      Assert.IsInstanceOf(typeof(string), mechanic.Role);
    }    

    [Test]
    public void HourValueNotNull()
    //Se prueba que el valor por hora no sea null
    {
      //Assert
      Assert.IsNotNull(mechanic.HourValue);
    }

    [Test]
    public void HourValueIsInteger()
    //Se prueba que el valor por hora sea de tipo int
    {
      //Assert
      Assert.IsInstanceOf(typeof(int), mechanic.HourValue);
    }    


  }
}