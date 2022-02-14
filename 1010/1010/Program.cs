using System;
using System.Globalization;

namespace _1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigoP1, quantidadeP1;
            double valorP1;
            int codigoP2, quantidadeP2;
            double valorP2;


            String linha1, linha2;
            linha1 = Console.ReadLine();
            linha2 = Console.ReadLine();

            string[] valoresLinha1 = new string[3];
            valoresLinha1 = linha1.Split(' ');

            codigoP1 = int.Parse(valoresLinha1[0]);
            quantidadeP1 = int.Parse(valoresLinha1[1]);
            valorP1 = double.Parse(valoresLinha1[2], CultureInfo.InvariantCulture);

            string[] valoresLinha2 = new string[3];
            valoresLinha2 = linha2.Split(' ');

            codigoP2 = int.Parse(valoresLinha2[0]);
            quantidadeP2 = int.Parse(valoresLinha2[1]);
            valorP2 = double.Parse(valoresLinha2[2], CultureInfo.InvariantCulture);


            double VALORAPAGAR = (quantidadeP1 * valorP1) + (quantidadeP2 * valorP2);


            Console.WriteLine("VALOR A PAGAR: R$ " + VALORAPAGAR.ToString("F2", CultureInfo.InvariantCulture));

            //Console.ReadLine();

        }
    }
}