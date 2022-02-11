using System;

namespace certificacao_csharp_roteiro.Aula3___classes__métodos__métodos_de_extensão._2___Métodos
{
    public class Metodos : IAulaItem
    {
        public void Executar()
        {
            var retangulo = new Retangulo(12, 10);
            var outroRetangulo = new Retangulo(10, 10);

            Console.WriteLine($"Área do retângulo: {retangulo.getArea()}");

            Console.WriteLine(
                $"Semelhante(outroRetanguloAltura, outroRetanguloLargura): {retangulo.Semelhante(outroRetangulo.Altura, outroRetangulo.Largura)}");
            Console.WriteLine($"Semelhante(outroRetangulo): {retangulo.Semelhante(outroRetangulo)}");
            Console.WriteLine(
                $"Semelhante(retangulo, outroRetangulo): {Retangulo.Semelhante(retangulo, outroRetangulo)}");
        }

        class Retangulo
        {
            public double Altura { get; set; }
            public double Largura { get; set; }

            public Retangulo(double altura, double largura)
            {
                Altura = altura;
                Largura = largura;
            }

            internal double getArea()
            {
                return Altura * Largura;
            }

            internal bool Semelhante(double outroRetanguloAltura, double outroRetanguloLargura)
            {
                var razaoRetangulo = Altura / Largura;
                var razaoOutroRetangulo = outroRetanguloAltura / outroRetanguloLargura;
                return razaoRetangulo == razaoOutroRetangulo;
            }

            internal bool Semelhante(Retangulo outroRetangulo)
            {
                var razaoRetangulo = Altura / Largura;
                var razaoOutroRetangulo = outroRetangulo.Altura / outroRetangulo.Largura;
                return razaoRetangulo == razaoOutroRetangulo;
            }

            internal static bool Semelhante(Retangulo retangulo, Retangulo outroRetangulo)
            {
                var razaoRetangulo = retangulo.Altura / retangulo.Largura;
                var razaoOutroRetangulo = outroRetangulo.Altura / outroRetangulo.Largura;
                return razaoRetangulo == razaoOutroRetangulo;
            }
        }
    }
}