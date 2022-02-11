using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace certificacao_csharp_roteiro.Aula3___classes__métodos__métodos_de_extensão.Propriedades_Indexadas
{
    public class PropriedadesIndexadas : IAulaItem
    {
        public void Executar()
        {
            var sala = new Sala();

            sala["A0"] = new ClienteCinema("Ana");
            sala["B1"] = new ClienteCinema("Jorge");
            
            sala.MostrarAcentosOcupados();
        }

        class Sala
        {
            private readonly IDictionary<string, ClienteCinema> reservas = new Dictionary<string, ClienteCinema>();
            
            public ClienteCinema this[string codigoAssento] {
                get
                {
                    return reservas[codigoAssento];
                }
                set
                {
                    reservas[codigoAssento] = value;
                }
            }

            public void MostrarAcentosOcupados()
            {
                Console.WriteLine("---- ASSENTOS OCUPADOS ----");

                reservas.ToList().ForEach(reserva =>
                {
                    Console.WriteLine($"Assento: {reserva.Key} | Cliente: {reserva.Value}");
                });
            }
        }

        class ClienteCinema
        {
            public string Nome { get; set; }

            public ClienteCinema(string nome)
            {
                Nome = nome;
            }

            public override string ToString()
            {
                return Nome;
            }
        }
    }
}