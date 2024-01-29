using System;

namespace CalculadoraApp
{
    public class Program 
    {
        static void Main(string[] args)
        {
            char operacao; // Declaração da variável que armazenará a operação escolhida
            bool operacaoValida; // Variável para verificar se a operação é válida

            // Loop do-while para solicitar a operação até que uma operação válida seja digitada
            do
            {
                // Solicita a operação desejada
                Console.WriteLine("Digite a operação (+ para soma, - para subtração, * para multiplicação, / para divisão):");
                operacao = Console.ReadKey().KeyChar; // Lê a tecla pressionada pelo usuário
                Console.WriteLine();

                // Verifica se a operação é válida (se é +, -, * ou /)
                operacaoValida = operacao == '+' || operacao == '-' || operacao == '*' || operacao == '/';
                if (!operacaoValida)
                {
                    Console.Clear();
                    Console.WriteLine("Operação inválida! Por favor, digite uma operação válida.");
                }
            } while (!operacaoValida); // Continua o loop enquanto a operação não for válida

            int n1 = 0, n2 = 0; // Inicializa as variáveis n1 e n2 com valores padrão pq deu muito erro essa bosta antes de iniciar com valor padrão na verificação de um número válido

            bool numerosValidos; // Variável booleana para verificar se os números são válidos

            // Loop do-while para solicitar os números até que números válidos sejam digitados
            do
            {
                // Solicita os números para a operação
                Console.Write("Digite o primeiro número: ");
                string num1 = Console.ReadLine(); // Lê o número digitado

                // Verifica se o primeiro número é válido (se é um número inteiro)
                numerosValidos = int.TryParse(num1, out n1);
                if (!numerosValidos)
                {
                    Console.Clear(); 
                    Console.WriteLine("Número inválido! Por favor, digite apenas números.");
                    continue; // Retorna ao início do loop e solicita novamente os números
                }

                Console.Write("Digite o segundo número: ");
                string num2 = Console.ReadLine(); // Lê o número digitado

                // Verifica se o segundo número é válido (se é um número inteiro)
                numerosValidos = int.TryParse(num2, out n2);
                if (!numerosValidos)
                {
                    Console.Clear(); 
                    Console.WriteLine("Número inválido! Por favor, digite apenas números.");
                }
            } while (!numerosValidos); // Continua o loop enquanto os números não forem válidos

            // Realiza a operação escolhida e imprime o resultado
            switch (operacao)
            {
                case '+':
                    Console.WriteLine("Resultado da Soma: " + Calculadora.Somar(n1, n2)); // Chama a função de soma
                    break;
                case '-':
                    Console.WriteLine("Resultado da Subtração: " + Calculadora.Subtrair(n1, n2)); // Chama a função de subtração
                    break;
                case '*':
                    Console.WriteLine("Resultado da Multiplicação: " + Calculadora.Multiplicar(n1, n2)); // Chama a função de multiplicação
                    break;
                case '/':
                    try
                    {
                        Console.WriteLine("Resultado da Divisão: " + Calculadora.Dividir(n1, n2)); // Chama a função de divisão
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message); // Imprime a mensagem de erro se a divisão for feita por zero
                    }
                    break;
            }
        }
    }

    public static class Calculadora
    {
        public static int Somar(int n1, int n2) // soma dois números
        {
            return n1 + n2;
        }

        public static int Subtrair(int n1, int n2) // subtrai dois números
        {
            return n1 - n2;
        }

        public static int Multiplicar(int n1, int n2) // multiplica dois números
        {
            return n1 * n2;
        }

        public static double Dividir(double n1, double n2) // divide dois números
        {
            if (n2 == 0)
            {
                throw new ArgumentException("Não é possível dividir por zero"); // Lança exceção se for divido por zero
            }

            return n1 / n2;
        }
    }
}
