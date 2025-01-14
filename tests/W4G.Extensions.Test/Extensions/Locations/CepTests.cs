namespace W4G.Extensions.Locations;

[TestClass]
public class CepTest
{
    [TestMethod]
    public void Validate_ValidCep_ReturnsTrue()
    {
        // Arrange
        var cep = "01010010";

        // Act
        var isValid = cep.CepIsValid();

        // Assert
        Assert.IsTrue(isValid);
    }

    [TestMethod]
    public void Validate_InvalidCep_ReturnsFalse()
    {
        // Arrange
        var cep = "12345-678";

        // Act
        var isValid = cep.CepIsValid();

        // Assert
        Assert.IsFalse(isValid);
    }

    [TestMethod]
    public void DadosEndereco_ValidCep_ReturnsEndereco()
    {
        // Arrange
        var cep = "01.010-010";

        // Act
        var endereco = cep.CepInfo();

        // Assert
        Assert.IsNotNull(endereco);
        Assert.AreEqual("01010-010", endereco.Cep);
    }

    [TestMethod]
    public void DadosEndereco_InvalidCep_ReturnsNull()
    {
        // Arrange
        var cep = "123456789";

        // Act
        var endereco = cep.CepInfo();

        // Assert
        Assert.IsNull(endereco);
    }

    [TestMethod]
    public void Formatar_ValidCep_ReturnsFormattedCep()
    {
        // Arrange
        var cep = "01010010";

        // Act
        var formattedCep = cep.CepFormat();

        // Assert
        Assert.AreEqual("01010-010", formattedCep);
    }
}