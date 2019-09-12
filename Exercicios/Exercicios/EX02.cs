using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class EX02
    {

        public void Litros()
        {
            int tempoGasto, velocidadeMedia,distancia,litros_usados;

            Console.WriteLine("Por gentileza, informe o tempo gasto na viagem:");
            tempoGasto = int.Parse(Console.ReadLine());
            Console.WriteLine("Por gentileza, informe a velocidade media:");
            velocidadeMedia = int.Parse(Console.ReadLine());

            distancia = (tempoGasto * velocidadeMedia);

            litros_usados = distancia / 12;

            Console.WriteLine($"Sua velocidade media foi: {velocidadeMedia}; Tempo gasto {tempoGasto} ; Distancia Percorrida {distancia}; Litros Utilizados {litros_usados}.");

            Console.ReadLine();


        }
    }
}
