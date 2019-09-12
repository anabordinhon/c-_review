using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class EX01
    {
        enum Dia { Domingo = 1, Segunda, Terça, Quarta, Quinta, Sexta, Sábado };
        enum Mes { Janeiro = 1, Fevereiro, Março, Abril, Maio, Junho, Julho, Agosto, Setembro, Outubro, Novembro, Dezembro };
        struct aluno
        {
            public String nome, ra;
            public int idade;

        }

        public void Struct()
        {
            aluno estudante;
            estudante.nome = "Nathan Cirillo";
            estudante.ra = "091442";
            estudante.idade = 27;
            Console.WriteLine($"Nome: {estudante.nome}");
            Console.WriteLine($"Ra: {estudante.ra}");
            Console.WriteLine($"Idade : {estudante.idade}");

        }

        public void Enumeracao()
        {
            Dia hoje = Dia.Quinta;
            int numdia = (int)hoje;
            Console.WriteLine($"{hoje} é o dia número #{numdia}.");

            Mes mesatual = Mes.Agosto;
            int nummes = (int)mesatual;
            Console.WriteLine($"{mesatual} é o mês número #{nummes}.");

        }


        public void Tamanho()
        {
            Console.WriteLine("Informe uma palavra:");
            string aux = Console.ReadLine();
            Console.WriteLine($"Palavra Informada: {aux}");
            Console.WriteLine($"Seu Tamanho: {aux.Length}");

        }

        public void Posicao()
        {
            string mensagem = "Revisando em C#!";

            char pc = mensagem[0];
            char sc = mensagem[4];
            char tc = mensagem[8];

            Console.WriteLine($"{pc} - {sc} - {tc}");
        }

        public void Vetor()
        {
            double[] nota = new double[4];

            nota[0] = 5;
            nota[1] = 9;
            nota[2] = 9.5;
            nota[3] = 7;

            double media = (nota[0] + nota[1] + nota[2] + nota[3]) / 4;
            Console.WriteLine($"A media foi {media}.");

        }


        public void Matriz()
        {
            int[,] idade = new int[3, 3];

            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.WriteLine($"Linha {l} Coluna {c}");
                    string val = Console.ReadLine();
                    idade[l, c] = Convert.ToInt32(val);
                }
            }
        }

        public void ArrayDinamico()
        {
            Console.WriteLine("Qual o numero de dimensoes:");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arrayDinamico = new int[num];

            for(int x=1; x<= num; x++)
            {
                Console.WriteLine($"Forneça o valor {x}");
                arrayDinamico[x - 1] = Convert.ToInt32(Console.ReadLine());

            }

            for (int y =0; y<num; y++)
            {
                Console.WriteLine($"Item [{y + 1}] = {arrayDinamico[y]}");
            }
        }

        public void Maior()
        {
            Console.WriteLine("Informe o Primeiro Numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o Segundo Numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2)
            {
                Console.WriteLine($"{num1} > {num2}");
            }

            else
            {
                Console.WriteLine($"{num1} < {num2}");
            }
        }


        public void Repeticao()
        {
            Console.WriteLine("Informe um número de 1 a 7: ");
            int num = int.Parse(Console.ReadLine());

            switch(num)
            {
                case 1:
                    Console.WriteLine("Você escolheu DOMINGO!"); break;
                case 2:
                    Console.WriteLine("Você escolheu SEGUNDA!"); break;
                case 3:
                    Console.WriteLine("Você escolheu TERÇA!"); break;
                case 4:
                    Console.WriteLine("Você escolheu QUARTA!"); break;
                case 5:
                    Console.WriteLine("Você escolheu QUINTA!"); break;
                case 6:
                    Console.WriteLine("Você escolheu SEXTA!"); break;
                case 7:
                    Console.WriteLine("Você escolheu SABADO!"); break;

                default:
                    Console.WriteLine("Valor Inválido!"); break;

            }
        }

        public void Para()
        {
            Console.WriteLine("Número" + "\t" + "Quadrado" + "\t" + "Cubo");
            for(int i =1; i<=10; i++)
            {
                Console.WriteLine(i + "\t" + i * i + "\t\t" + i * i * i);
            }
        }

        public void SomaNumeros()
        {
            Console.WriteLine("Informe um numero:");
            int num = Convert.ToInt32(Console.ReadLine());

            int x = 0, soma = 0;

            while (x <= num)
            {
                soma += x;
                x += 1;
            }

            Console.WriteLine($"O valor total foi: {soma}");
        }

        public void FacaEnquanto()
        {
            int op;

            do
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("[1] - Cadastrar ");
                Console.WriteLine("[2] - Alterar ");
                Console.WriteLine("[3] - Excluir ");
                Console.WriteLine("[4] - Sair ");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Cadastro Realizado com Sucesso!");
                        break;

                    case 2:
                        Console.WriteLine("Alteração Efetuada com Sucesso!");
                        break;

                    case 3:
                        Console.WriteLine("Exclusão Realizada com Sucesso!");
                        break;

                    case 4:
                        Console.WriteLine("Fechamento do Sistema!");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            } while (op != 4);
        }


        public void Colecao()
        {
            string[] nomes = { "João", "Nathan", "Matheus", "Fernando" };

            foreach (string nm in nomes)
                Console.WriteLine($"Nome:{nm}");
        }
    }
}

