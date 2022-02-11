using System;

namespace certificacao_csharp_roteiro.Aula2___criar_tipos_de_referência._2___Classes
{
    public class Classes : IAulaItem
    {
        public void Executar()
        {
            PosicaoGPS posicao1 = new PosicaoGPS() {Latitude = 13.78, Longitude = 29.51};
            posicao1 = new PosicaoGPS(13.78, 29.51);

            Console.WriteLine(posicao1);

            PosicaoGPSComLeitura posicao2 = new PosicaoGPSComLeitura(13.78, 29.51, DateTime.Now);
            Console.WriteLine(posicao2);
        }

        interface IGPS
        {
            bool EstaNoHisferioNorte();
        }

        class PosicaoGPS : IGPS
        {
            public double Latitude;
            public double Longitude;

            public PosicaoGPS()
            {
            }

            public PosicaoGPS(double latitude, double longitude)
            {
                Latitude = latitude;
                Longitude = longitude;
            }

            public override string ToString()
            {
                return $"Latitude {Latitude} | Longitude: {Longitude}";
            }

            public bool EstaNoHisferioNorte()
            {
                return Latitude > 0;
            }
        }

        class PosicaoGPSComLeitura : PosicaoGPS
        {
            private readonly DateTime _dataLeitura;

            public PosicaoGPSComLeitura(double latitude, double longitude, DateTime dataLeitura) : base(latitude,
                longitude)
            {
                _dataLeitura = dataLeitura;
            }

            public override string ToString()
            {
                return base.ToString() + $" | Data Leitura: {_dataLeitura}";
            }
        }
    }
}