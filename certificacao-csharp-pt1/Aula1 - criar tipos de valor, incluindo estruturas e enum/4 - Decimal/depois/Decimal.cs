﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Decimal : IAulaItem
    {
        public void Executar()
        {
            double valorProduto1 = 10;
            double valorProduto2 = 20;
            double valorProduto3 = 30;

            Console.WriteLine("Descobrindo se (10 + 20) == 30");
            Console.WriteLine((valorProduto1 + valorProduto2) == valorProduto3);

            valorProduto1 = 10.1;
            valorProduto2 = 20.2;
            valorProduto3 = 30.3;

            Console.WriteLine("Descobrindo se (10.1 + 20.2) == 30.3");
            Console.WriteLine((valorProduto1 + valorProduto2) == valorProduto3);

            Console.WriteLine(valorProduto1 + valorProduto2);

            Console.WriteLine("Descobrindo se (10.1 + 20.2) == 30.299999999999997");
            Console.WriteLine((valorProduto1 + valorProduto2) == 30.299999999999997);

            decimal materiaPrima = 10.1m;
            decimal maoObra = 20.2m;
            decimal custo = 30.3m;

            Console.WriteLine("Descobrindo se (10.1m + 20.2m) == 30.3m");
            Console.WriteLine((materiaPrima + maoObra) == custo);
        }
    }
}