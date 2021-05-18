using NUnit.Framework;
using Library;

namespace Library.Test
{
  public class ReplacementTest
  {
    private Replacement replacement;

    [SetUp]
    public void Setup()
    {
      //Arrange
      replacement = new Replacement("Fiat", 2016, "Luces", 500);
    }


    [Test]
    public void BrandNotNull()
    //Se prueba que la marca no sea null
    {
      //Assert
      Assert.IsNotNull(replacement.Brand);
    }

    [Test]
    public void BrandIsString()
    //Se prueba que la marca sea de tipo string
    {
      //Assert
      Assert.IsInstanceOf(typeof(string), replacement.Brand);
    }

    [Test]
    public void IdPartNotNull()
    //Se prueba que el id del parte no sea null
    {
      //Assert
      Assert.IsNotNull(replacement.IdPart);
    }

    [Test]
    public void IdPartIsInteger()
    //Se prueba que el id del parte sea de tipo int
    {
      //Assert
      Assert.IsInstanceOf(typeof(int), replacement.IdPart);
    }

    [Test]
    public void DescriptionNotNull()
    //Se prueba que la descripcion no sea null
    {
      //Assert
      Assert.IsNotNull(replacement.Description);
    }

    [Test]
    public void DescriptionIsString()
    //Se prueba que la descripcion sea de tipo string
    {
      //Assert
      Assert.IsInstanceOf(typeof(string), replacement.Description);
    }

    [Test]
    public void ReplacementCostNotNull()
    //Se prueba que el costo del repuesto no sea null
    {
      //Assert
      Assert.IsNotNull(replacement.ReplacementCost);
    }

    [Test]
    public void ReplacementCostIsInteger()
    //Se prueba que el costo del repuesto sea de tipo int
    {
      //Assert
      Assert.IsInstanceOf(typeof(int), replacement.ReplacementCost);
    }
  }
}