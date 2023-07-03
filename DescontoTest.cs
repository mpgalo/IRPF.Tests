namespace IRPF.Tests;
using IRPF.Console;

public class DescontoTest
{
    [Theory]
    [InlineData(1500, 0)]
    [InlineData(2500, 44.70)]
    [InlineData(3500, 170.20)]
    [InlineData(4500, 376.37)]
    [InlineData(5500, 643.14)]
    public void CalcularDescontoTest(decimal salarioBruto, decimal resultado)
    {
        decimal desconto = Program.CalcularDesconto(salarioBruto);
        Assert.Equal(resultado, desconto);
    }
}