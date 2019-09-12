using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class EX03
    {
        public void AreaTriangulo()
        {
            int baseTri, alturaTri, calculo=0;

            Console.WriteLine("Informe o valor da base:");
            baseTri = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da altura:");
            alturaTri = int.Parse(Console.ReadLine());

            if(baseTri == 0)
            {
                Console.WriteLine($"Base não pode ser zerada {baseTri}");
            }

            if (alturaTri == 0)
            {
                Console.WriteLine($"Altura não pode ser zerada {alturaTri}");
            }
            else
            {
                calculo = ((baseTri * alturaTri) / 2);
            }
            Console.WriteLine($"Area {calculo}");

        }
    }
}
