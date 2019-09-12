using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class EX04
    {
        public void InteiroPositivo()
        {
            int valor, resultado;

            Console.WriteLine("Informe um valor inteiro:");
            valor = int.Parse(Console.ReadLine());

            resultado = valor % 2;

            if (resultado < 0)
            {
                Console.WriteLine("Não são permitidos valores negativos!");

            }
            else
            {
                if (resultado == 0)
                {
                    Console.WriteLine($"Valor {valor} é Par!");
                }

                else
                {
                    Console.WriteLine($"Valor {valor} é Impar!");
                }
            }

        }

    }
}
