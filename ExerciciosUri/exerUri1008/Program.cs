using System;
using System.Globalization;
namespace exerUri1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeFunc, horaTrab;
            double porHora, salario;


            numeFunc = int.Parse(Console.ReadLine());
            horaTrab = int.Parse(Console.ReadLine());
            porHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = (double) porHora * horaTrab;

            Console.WriteLine("NUMBER = " + numeFunc);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }

}