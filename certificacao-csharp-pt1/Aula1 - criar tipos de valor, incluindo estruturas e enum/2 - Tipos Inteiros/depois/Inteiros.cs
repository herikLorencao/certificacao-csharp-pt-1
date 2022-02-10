using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposInteiros : IAulaItem
    {
        public void Executar()
        {
            int idade = 15;

            char resposta = 'S';

            byte nivelDeAzul = 0xFF;
            short passageirosVoo = 300; // System.Int16
            passageirosVoo = -6;

            int populacao = 1500; // System.Int32
            populacao = -2300;

            long populacaoDoBrasil = 207_660_929; // System.Int64

            sbyte nivelDeBrilho = -127; // System.Sbyte
            ushort passageirosNavios = 230; // System.UInt16
            uint estoque = 1500; // System.UInt32
            ulong populacaoDoMundo = 7_000_000_000; // System.UInt64

            Console.WriteLine($"nivelDeAzul: {nivelDeAzul}");
            Console.WriteLine($"passageirosVoo: {passageirosVoo}");
            Console.WriteLine($"populacao: {populacao}");
            Console.WriteLine($"populacaoDoBrasil: {populacaoDoBrasil}");

            Console.WriteLine($"nivelDeBrilho: {nivelDeBrilho}");
            Console.WriteLine($"passageirosNavios: {passageirosNavios}");
            Console.WriteLine($"estoque: {estoque}");
            Console.WriteLine($"populacaoDoMundo: {populacaoDoMundo}");
        }
    }
}
