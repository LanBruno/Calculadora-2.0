using CalculadoraApp;

namespace CalculadoraApp.Test;

public class QuandoMult
{
    [Fact]
    public void Deve_Multiplicar_Dois_Numeros()
    {
        var n1 = 3;
        var n2 = 3;
        var esperado = n1 * n2;
        var resultado = Calculadora.Multiplicar(n1, n2);

        Assert.Equal(esperado, resultado);
        
    }


}