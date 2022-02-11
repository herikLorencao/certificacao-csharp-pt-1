using System;

namespace certificacao_csharp_roteiro.Aula3___classes__métodos__métodos_de_extensão.Parâmetros_Nomeados
{
    public class ParametrosOpcionais : IAulaItem
    {
        public void Executar()
        {
            ClienteEspecial clienteEspecial = new ClienteEspecial("Lucas Skywalker");
            clienteEspecial.FazerPedido(1, "Vitória", 10);

            clienteEspecial = new ClienteEspecial();
            clienteEspecial.FazerPedido(1, "Vitória", 10);
            
            clienteEspecial.FazerPedido(1);
            clienteEspecial.FazerPedido(1, "Vila Velha");
            
            clienteEspecial.FazerPedido(1, quantidade: 20);
        }
    }

    class ClienteEspecial
    {
        private readonly string nome;

        public ClienteEspecial(string nome = "Anônimo")
        {
            this.nome = nome;
        }

        public void FazerPedido(int produtoId, string endereco = "Vitória", int quantidade = 10)
        {
            Console.WriteLine("cliente: {0}, produto: {1}, endereco: {2}, quantidade: {3}.", nome, produtoId, endereco,
                quantidade);
        }
    }
}