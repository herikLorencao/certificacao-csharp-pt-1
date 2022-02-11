using System;

namespace certificacao_csharp_roteiro.Aula2___criar_tipos_de_referência._5___Objetos
{
    public class Objetos : IAulaItem
    {
        public void Executar()
        {
            int pontuacao = 10;
            Console.WriteLine($"pontuacao: {pontuacao}");

            Console.WriteLine("OBJECT COM VALOR PRIMITIVO");
            object meuObjeto;
            meuObjeto = pontuacao;
            Console.WriteLine($"meuObjeto: {meuObjeto}");
            Console.WriteLine($"meuObjeto.GetType(): {meuObjeto.GetType()}");

            Console.WriteLine();
            Console.WriteLine("OBJECT COM REFERÊNCIA DE OBJETO");

            meuObjeto = new Jogador();
            Jogador classRef;
            classRef = meuObjeto as Jogador;

            Console.WriteLine($"classRef.Pontuacao: {classRef.Pontuacao}");
        }
    }

    class Jogador
    {
        public int Pontuacao { get; set; } = 10;
    }
}