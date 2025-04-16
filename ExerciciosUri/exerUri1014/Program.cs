using System;
using System.Globalization;

namespace exerUri1014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y, kmPorHora;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            kmPorHora = (double)X / Y;

            Console.WriteLine(kmPorHora.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}