using System;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 5;
            int resultado;

            resultado = Calcular(numero);

            Console.WriteLine("Resultado: {0}", resultado);
            Console.ReadKey();
        }

        static int Calcular(int numero)
        {
            int resultado;
            if (numero <= 1)
            {
                return (1);
            }
            else
            {
                /*Não é possivel, chamar uma função dentro da própria função dessa maneiro.
                 Isso faz com que o programa não execute devidamento por um problema de loop infinito
                */

                //Solução
                //resultado = numero * (numero -= 1);
                resultado = numero * Calcular(numero--);
                return (resultado);
            }
        }
    }
}
