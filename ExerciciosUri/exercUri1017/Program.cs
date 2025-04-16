using System;
using System.Globalization;

namespace exercUri1017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horas, velocidade, dist;
            double litros;

            horas = int.Parse(Console.ReadLine());
            velocidade= int.Parse(Console.ReadLine());

            dist = horas * velocidade;

            litros = (double) dist / 12;

            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));




        }
    }
}