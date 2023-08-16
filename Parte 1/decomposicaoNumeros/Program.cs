using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace decomposicaoNumeros{
    class Decomposicao{
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                int numero;
                Console.WriteLine("Digite um número");
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Não é permitido letras/caracter, digite um número valido");
                }


                List<int> divisores = calcularDivisores(numero);
                List<int> divisoresPrimos = calcularDivisoresPrimos(divisores);

                Console.WriteLine($"Divisores de {numero}: {string.Join(", ", divisores)}");
                Console.WriteLine($"Divisores primos de {numero}: {string.Join(", ", divisoresPrimos)}");

                Console.WriteLine("Deseja calcular outro número? (S/N)");
                string resposta = Console.ReadLine().ToUpper();
                if (resposta != "S")
                {
                    continuar = false;
                }
            }
        }

        static List<int> calcularDivisores(int numero)
        {
            List<int> divisores = new List<int>();
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    divisores.Add(i);
                }
            }
            return divisores;
        }

        static List<int> calcularDivisoresPrimos(List<int> divisores)
        {
            List<int> divisoresPrimos = new List<int>();
            foreach (int divisor in divisores)
            {
                if(primo(divisor))
                {
                    divisoresPrimos.Add(divisor);
                }
            }
            return divisoresPrimos;
        }

        static bool primo(int numero)
        {
            if (numero <=1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}