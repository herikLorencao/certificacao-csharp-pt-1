using System;

namespace certificacao_csharp_roteiro.Aula3___classes__métodos__métodos_de_extensão.Parâmetros_Nomeados
{
    public class ParametrosNomeados: IAulaItem
    {
        public void Executar()
        {
            ImprimirDetalhesDoPedido("Maria de Fátima", 31, "Caneca Vermelha");
            // parâmetros nomeados
            ImprimirDetalhesDoPedido(numeroPedido: 10, nomeProduto: "Caneca Vermelha", vendedor: "José da Silva");
            
            // pode ter só alguns nomeados, mas o resto deve seguir a ordem padrão da função
            // Dependendo da versão do C# (< 7.2) pode dar problema de compilação
            // ImprimirDetalhesDoPedido(nomeProduto: "Caneca Vermelha", "João das Neves", 10);
        }
        
        void ImprimirDetalhesDoPedido(string vendedor, int numeroPedido, string nomeProduto)
        {
            if (string.IsNullOrWhiteSpace(vendedor))
                throw new ArgumentException("Nome do vendedor deve ser informado");

            if (string.IsNullOrWhiteSpace(nomeProduto))
                throw new ArgumentException("Nome do produto deve ser informado");
            
            Console.WriteLine($"Pedido número {numeroPedido} | Produto: {nomeProduto} | Vendedor: {vendedor}");
        }
    }
}