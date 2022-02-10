using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposDeValor : IAulaItem
    {
        public void Executar()
        {
            int idade;
            idade = 30;
            Console.WriteLine(idade);

            System.Int32 copiaIdade = idade;

            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Cópia Idade: {copiaIdade}");

            idade = 23;
            
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Cópia Idade: {copiaIdade}");

            // por padrão o tipo int não aceita nulo
            //int idade2 = null;

            int? idade2 = null;
            System.Nullable<int> idade3 = null;
        }
    }
}
