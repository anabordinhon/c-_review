using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class EX05
    {

        public void Matricula()
        {
            int ra,n1=0,n2=0, media;

            Console.WriteLine("Informe seu RA (Caso deseje sair, informe 0) :");
            ra = int.Parse(Console.ReadLine());

            while (ra != 0)
            {
                Console.WriteLine("Informe sua NP1:");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe sua NP2:");
                n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe seu RA (Caso deseje sair, informe 0) :");
                ra = int.Parse(Console.ReadLine());
            }

            media = ((n1 + n2) / 2);
            Console.WriteLine($"Sua média foi: {media}");

            if (media >=5)
            {
                Console.WriteLine("Aprovado!");
            }
            
            else
            {
                Console.WriteLine("Reprovado!");
            }



        }
    }
}
