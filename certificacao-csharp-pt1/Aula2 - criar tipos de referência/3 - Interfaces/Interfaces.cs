using System;

namespace certificacao_csharp_roteiro.Aula2___criar_tipos_de_referência._3___Interfaces
{
    public class Interfaces : IAulaItem
    {
        public void Executar()
        {
            IEletrodomestico eletrodomestico = new Televisao();
            eletrodomestico.Ligar();

            eletrodomestico = new Abajur();
            eletrodomestico.Ligar();
        }

        interface IEletrodomestico
        {
            void Ligar();
            void Desligar();
        }

        // Em C# interfaces aceitam atributos
        interface IIluminacao
        {
            int PotenciaIluminacao { get; set; }
        }

        class Televisao : IEletrodomestico
        {
            public void Ligar()
            {
                Console.WriteLine("Ligando Televisão ...");
            }

            public void Desligar()
            {
            }
        }

        class Abajur : IEletrodomestico, IIluminacao
        {
            public int PotenciaIluminacao { get; set; }

            public void Ligar()
            {
                Console.WriteLine("Ligando Abajur ...");
            }

            public void Desligar()
            {
            }
        }

        class Lanterna : IEletrodomestico, IIluminacao
        {
            public int PotenciaIluminacao { get; set; }

            public void Ligar()
            {
            }

            public void Desligar()
            {
            }
        }

        class Radio : IEletrodomestico
        {
            public void Ligar()
            {
            }

            public void Desligar()
            {
            }
        }
    }
}