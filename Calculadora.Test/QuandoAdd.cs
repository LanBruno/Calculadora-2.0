using CalculadoraApp;

namespace CalculadoraApp.Test;

public class QuandoAdd
{
    [Fact]
    public void Deve_Somar_Dois_Numeros()
    {
        var n1 = 1;
        var n2 = 3;
        var esperado = n1 + n2;
        var resultado = Calculadora.Somar(n1, n2);

        Assert.Equal(esperado, resultado);
        
    }
}