using CalculadoraApp;

namespace CalculadoraApp.Test;

public class QuandoSub
{
    [Fact]
    public void Deve_Subtrair_Dois_Numeros()
    {
        var n1 = 4;
        var n2 = 3;
        var esperado = n1 - n2;
        var resultado = Calculadora.Subtrair(n1, n2);

        Assert.Equal(esperado, resultado);
        
    }
}