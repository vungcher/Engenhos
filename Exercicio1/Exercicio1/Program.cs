using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            var valorD = Console.ReadLine();

            if (Regex.IsMatch(valorD, @"^\d+$"))
            {
                int soma = 0;
                int x = Convert.ToInt32(valorD);
                for (int numero = 0; numero <= x; numero++)
                {
                    if (numero % 3 == 0 || numero % 5 == 0)
                    {
                        soma += numero;
                    }
                }

                Console.WriteLine(string.Format("Este resultado é a soma de todos números naturais que são multiplos de 3 e 5: {0}\n", soma));
                Console.Write("Pressione alguma tecla!");
                Console.ReadKey();
            }
            else
            {
                Console.Write("Número digitado fora dos parâmetros permitidos");
                Console.ReadKey();
            }

            

        }
    }
}
