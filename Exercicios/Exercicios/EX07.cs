using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class EX07
    {
        public void MatrizS()
        {
            int[,] a = new int[5, 3];
            int[,] b = new int[5, 3];
            int[,] s = new int[5, 3];

            for (int l = 0; l < 3; l++)
            {
                for (int c=0; c<5; c++)
                {
                    Console.WriteLine($"Linha {l} Coluna {c}");
                    string valA = Console.ReadLine();
                    a[l, c] = Convert.ToInt32(valA);
                    string valB = Console.ReadLine();
                    b[l, c] = Convert.ToInt32(valB);
                   
                    

                }
            }



            //// int[,] idade = new int[3, 3];

            //            for (int l = 0; l< 3; l++)
            //            {
            //                for (int c = 0; c< 3; c++)
            //                {
            //                    Console.WriteLine($"Linha {l} Coluna {c}");
            //                    string val = Console.ReadLine();
            //idade[l, c] = Convert.ToInt32(val);
            //                }
        }
    }
}




