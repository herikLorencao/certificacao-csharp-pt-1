using System;

namespace certificacao_csharp_roteiro.Aula4___criar_métodos_sobrecarregados_e_substituídos
{
    public class Sobrecargas : IAulaItem
    {
        public void Executar()
        {
            // Volume do Cubo
            Console.WriteLine(Volume(3));

            // Volume do Cilindro
            Console.WriteLine(Volume(2, 4));

            // Volume do prisma
            Console.WriteLine(Volume(2, 3, 4));
        }

        public double Volume(double lado)
        {
            return Math.Pow(lado, 3);
        }

        public double Volume(double raio, double altura)
        {
            return altura * Math.PI * Math.Pow(raio, 2);
        }

        public double Volume(double altura, double largura, double profundidade)
        {
            return altura * largura * profundidade;
        }
    }
}