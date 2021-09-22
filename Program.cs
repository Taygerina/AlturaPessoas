using System;
using System.Globalization;

namespace AlturaPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            //valor a ser adicionado pelo usuario
            Console.WriteLine("Informe a quantidade de pessoas: ");
            int n = int.Parse(Console.ReadLine());

            //tamanho do vetor 
            Console.WriteLine("Informe o tamanho das pessoas: ");
            double[] vect = new double[n];

            //Criação de um vetor conforme o tamanho indicado pelo usuario
            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
        double sum = 0.0;

            //somando todas as alturas das pessoas

        for (int i = 0;i < n; i ++)
            {
            sum += vect [ i ];
            }

            double media = sum / n;
            Console.WriteLine("Valor da media das 3 pessoas: " + media);
        }

    }
}

