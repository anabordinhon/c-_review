using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class DVD
    {
        /*10) Crie um programa para controlar um estoque pessoal de 50 DVDs de um usuário.
        Cada DVD terá um nome e um preço que deverão ser cadastrados. 
        Ao final do cadastro, deverá ser apresentado quanto o usuário gastou com os 50 DVDs e ainda todos os DVDs cadastrados 
        (registro completo - nome e preço) dos que possuem valor maior que R$20,00 */


        double contadorTotais = 0; //acumula os totais dos valores dos livros

        int[] array = new int[2]; //array de valores

        string[] arrayNome = new string[2]; //array de nomes

        public void CadastroDvd()
        { 
            for (int i = 0; i< 2; i++) //laço para gravar nome/valor
            {
                Console.WriteLine("Cadastro de DVDs:");
                Console.WriteLine("Insira o nome do DVD:");
                arrayNome[i] = Console.ReadLine();
                Console.WriteLine("Insira o valor do DVD:");
                array[i] = int.Parse(Console.ReadLine());
                contadorTotais += array[i];
            }


            for (int j = 0; j< 2; j++) //laço pra aprensetar os valores >20
            {
                if (array[j] > 20)
                {
                    Console.WriteLine("Controle de DVDs:");
                    Console.WriteLine("Nome : " + arrayNome[j]);
                    Console.WriteLine("Valor : " + array[j]);
                }
                else
                {
                    Console.WriteLine("Não existem mais livros com valores > 20");
                    break;
                }

            }


            Console.WriteLine("\n Valor Patrimonial:");
            Console.WriteLine($"Valor total do Patrimonio:{contadorTotais}");

            Console.ReadLine();
     }
   }
}

