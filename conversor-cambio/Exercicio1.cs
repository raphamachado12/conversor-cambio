using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace exercicio
{
    public class Exercicio
    {
        public static void Exercicio1()
        {
            double precoReal = 0;
            double taxa = 5.36d;
            double conversao = 0;

            Console.Write("Insira o valor em dolares: ");
            precoReal = double.Parse(Console.ReadLine());

            conversao = precoReal * taxa;

            Console.Write("Valor convertido em real: R$" + conversao + " reais ");

            Console.ReadKey();
        }
    }
}