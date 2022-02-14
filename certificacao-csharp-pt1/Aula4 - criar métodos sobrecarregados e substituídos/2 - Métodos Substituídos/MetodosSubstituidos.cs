using System;

namespace certificacao_csharp_roteiro.Aula4___criar_métodos_sobrecarregados_e_substituídos._2___Métodos_Substituídos
{
    public class MetodosSubstituidos : IAulaItem
    {
        public void Executar()
        {
            Animal gato = new Gato();
            gato.Beber();
            gato.Comer();
            gato.Andar();

            Gato gata = new Gato();
            gata.Beber();
            gata.Comer();
            gata.Andar();
        }

        class Animal
        {
            public void Beber()
            {
                Console.WriteLine("Animal.Beber");
            }
            
            // Para sobescrever o comportamento é necessário adicionar o virtual/override
            public virtual void Comer()
            {
                Console.WriteLine("Animal.Comer");
            }

            public void Andar()
            {
                Console.WriteLine("Animal.Andar");
            }
        }

        class Gato : Animal
        {
            // O operador new explícita que o método não sobrescreverá a classe herdada
            public new void Beber()
            {
                Console.WriteLine("Gato.Beber");
            }
            
            public override void Comer()
            {
                Console.WriteLine("Gato.Comer");
            }

            public new void Andar()
            {
                Console.WriteLine("Gato.Andar");
            }
        } 
    }
}