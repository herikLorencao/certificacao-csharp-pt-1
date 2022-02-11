using System;

namespace certificacao_csharp_roteiro.Aula2___criar_tipos_de_referência._4___Delegates
{
    public class Delegates : IAulaItem
    {
        static double Duplicar(double input)
        {
            return input * 2;
        }

        static double Triplicar(double input)
        {
            return input * 3;
        }

        delegate double MetodoMultiplicacao(double input);
        
        public void Executar()
        {
            Console.WriteLine($"Duplicar(7.5): {Duplicar(7.5)}");
            Console.WriteLine($"Duplicar(7.5): {Triplicar(7.5)}");

            MetodoMultiplicacao metodoMultiplicacao = Duplicar;
            Console.WriteLine($"metodoMultiplicacao (Duplicar) : {metodoMultiplicacao(7.5)}");

            metodoMultiplicacao = Triplicar;
            Console.WriteLine($"metodoMultiplicacao (Triplicar) : {metodoMultiplicacao(7.5)}");

            MetodoMultiplicacao metodoQuadrado = delegate(double input)
            {
                return Math.Pow(input, 2);
            };

            double quadrado = metodoQuadrado(3);
            Console.WriteLine($"Quadrado: {quadrado}");

            MetodoMultiplicacao metodoCubo = valor => Math.Pow(valor, 3);
            Console.WriteLine($"Cubo: {metodoCubo(5)}");
        }
    }
}