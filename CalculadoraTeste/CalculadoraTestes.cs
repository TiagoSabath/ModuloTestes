using Calculadora.Services;

namespace CalculadoraTeste;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;

    public CalculadoraTestes()
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
        int resultado = _calc.Somar(num1,num2);

        // Assert
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeverVerificarSe4EhParERetornarVerdadeiro()
    {
        // Arrange
        int num1 = 4;

        // Act
        bool resultado = _calc.EhPar(num1);

        // Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] { 2, 4, 6})]
    [InlineData(new int[] { 8, 10, 12})]

    public void DeverVerificarSeOsNumerosSaoVerdadeiro(int[] numeros)
    {
        // Act / Assert
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
        
    }
}