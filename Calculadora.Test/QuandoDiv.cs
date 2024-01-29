using CalculadoraApp;
using Xunit;
using System;

namespace CalculadoraApp.Test 
{
    public class QuandoDiv 
    {
        [Fact]
        public void Deve_Dividir_Dois_Numeros()
        {
            var n1 = 4;
            var n2 = 2;
            var esperado = n1 / n2;
            var resultado = Calculadora.Dividir(n1, n2);

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void Por_Zero_Deve_Lancar_Excecao()
        {
            var n1 = 10;
            var n2 = 0;
            var excecao = Assert.Throws<ArgumentException>(() => Calculadora.Dividir(n1, n2));
            Assert.Equal("Não é possível dividir por zero", excecao.Message);
        }
    }
} 