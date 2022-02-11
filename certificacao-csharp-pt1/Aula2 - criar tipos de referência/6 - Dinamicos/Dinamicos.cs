using System;

namespace certificacao_csharp_roteiro.Aula2___criar_tipos_de_referência._6___Dinamicos
{
    public class Dinamicos : IAulaItem
    {
        public void Executar()
        {
            object objeto = 1;

            dynamic dinamico = 1;
            dinamico = dinamico + 3;
            Console.WriteLine(dinamico);
            
            // Se chamar não dará erro de compilação mas dará de execução
            //dinamico.teste()
        }
    }
}