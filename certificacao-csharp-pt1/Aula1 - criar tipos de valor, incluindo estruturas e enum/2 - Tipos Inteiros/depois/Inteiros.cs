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
            // idade = 15.5;

            char resposta = 'S'; // System.Char

            byte nivelDeAzul = 0xFF; // = 255 em decimal

            short passageirosVoo = 230; // System.Int16
            passageirosVoo = -7;

            int populacao = 1500; // System.int32
            populacao = -2300;

            long populacaoDoBrasil = 207_660_929; // +/- 207mi

            sbyte nivelDeBrilho = -127; // System.SByte
            ushort passageirosNavio = 230; // System.UInt16
            uint estoque = 1500; // System.UInt32
            ulong populacaoDoMundo = 7_000_000_000; // 7 bi System.UInt64

            Console.WriteLine($"resposta: {resposta}");

            Console.WriteLine($"nivelDeAzul: {nivelDeAzul}");
            Console.WriteLine($"passageirosVoo: {passageirosVoo}");
            Console.WriteLine($"populacao: {populacao}");
            Console.WriteLine($"populacaoDoBrasil: {populacaoDoBrasil}");
            
            Console.WriteLine($"nivelDeBrilho: {nivelDeBrilho}");
            Console.WriteLine($"passageirosNavio: {passageirosNavio}");
            Console.WriteLine($"estoque: {estoque}");
            Console.WriteLine($"populacaoDoMundo: {populacaoDoMundo}");

            // nivelDeAzul = 0xFFFF; // = 65535 em decimal
            // passageirosVoo = 230000; // System.Int16
            // populacao = 15000000000; // System.Int32
            // passageirosNavio = -15; // System.UInt16
            // estoque = -2300; // System.UInt32
            // populacaoDoBrasil = 207_660_929.345;


        }
    }
}
