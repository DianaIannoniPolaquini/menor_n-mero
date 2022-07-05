using System;
using System.Globalization;

namespace MENOR_NUMERO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, menor;

            String[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0], CultureInfo.InvariantCulture);
            b = int.Parse(vet[1], CultureInfo.InvariantCulture);
            c = int.Parse(vet[2], CultureInfo.InvariantCulture);

            if (a < b && a < c)
            {
                menor = a;
            }
            else if (b < c)
            {
                menor = b;
            }
            else
            {
                menor = c;
            }

            Console.WriteLine("Menor número: {0}", menor);

        }
    }
}
