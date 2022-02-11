using System;

namespace certificacao_csharp_roteiro.Aula3___classes__métodos__métodos_de_extensão.Métodos_de_Extensão
{
    public class MetodosDeExtensao : IAulaItem
    {
        public void Executar()
        {
            Impressora impressora = new Impressora("teste.docx");
            impressora.Imprimir();
            impressora.ImprimirHTML();
        }
    }

    static class ImpressoraExtensions
    {
        public static void ImprimirHTML(this Impressora impressora)
        {
            Console.WriteLine($@"
                <html>
                    <body>
                        {impressora.Nome}
                    </body>
                </html>
            ");
        }
    }

    class Impressora
    {
        public string Nome { get; set; }

        public Impressora(string nomeDocumento)
        {
            Nome = nomeDocumento;
        }

        public void Imprimir()
        {
            Console.WriteLine(Nome);
        }
    }
}