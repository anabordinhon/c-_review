using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class EX09
    {
        /*09)Preencha uma matriz de 3 linhas e 4 colunas com "P" para as colunas pares e "I" para as colunas ímpares.
        Não se esqueça de apresentar os valores da melhor maneira possível para o usuário.*/
        public void Matriz()
        {

            int[,] matriz = new int[3, 4];

            for (int l = 0; l < 3; l++)
            {

                for (int c = 0; c < 4; c++)
                {
                    if (c % 2 == 0)

                    {
                        matriz[l, c] = 'P';
                        Console.WriteLine("P");
                    }

                    else
                    {
                        matriz[l, c] = 'I';
                        Console.WriteLine("I");
                    }
                }
            }

        }
    }
}
