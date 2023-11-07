using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int resultado = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSubtrair10Com10ERetornar0()
    {
        // Arrange
        int num1 = 10;
        int num2 = 10;

        // Act
        int resultado = _calc.Subtrair(num1, num2);

        // Assert
        Assert.Equal(0, resultado);
    }

    [Fact]
    public void DeveMultiplicar5Com5ERetornar25()
    {
        // Arrange
        int num1 = 5;
        int num2 = 5;

        // Act
        int resultado = _calc.Multiplicar(num1, num2);

        // Assert
        Assert.Equal(25, resultado);
    }

    [Fact]
    public void DeveDividir15Por3ERetornar5()
    {
        // Arrange
        int num1 = 15;
        int num2 = 3;

        // Act
        int resultado = _calc.Dividir(num1, num2);

        // Assert
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarTrue()
    {
        // Arrange
        int numero = 4;

        // Act
        bool resultado = _calc.EhPar(numero);

        // Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(12)]    
    public void DeveVerificarSeOsNumerosSaoParesERetornarTrue(int numero)
    {
        // Act
        bool resultado = _calc.EhPar(numero);

        // Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] { 2, 4 })] 
    [InlineData(new int[] { 6, 8, 10 })]
    public void DeveVerificarSeOsNumerosSaoParesERetornarRefatorado(int[] numeros)
    {
        // Act / Assert
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }
}