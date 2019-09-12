using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class EX06
    {
        public void Boate()
        {

            int idade=1,cont =0;


            while (idade != 0)
            {
                Console.WriteLine("Por gentileza, informe sua idade (Caso deseje sair, informe 0):");
                idade = int.Parse(Console.ReadLine());
                cont++;
                


                if (idade < 18 && idade!=0)
                {
                    Console.WriteLine("Entrada Proibida!");
                    break;
                }

                if(idade ==0)
                {
                    Console.WriteLine("Sistema encerrado!");
                    break;
                    
                }
                
                else
                {
                    Console.WriteLine("Entrada Permitida");
                    Console.WriteLine($"Quantidade de Clientes atual:{cont}");

                }
            }
        }
    }
}
