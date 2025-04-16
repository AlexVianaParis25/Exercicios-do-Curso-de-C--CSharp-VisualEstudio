using System.Globalization;

namespace exerUri1051
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double imposto;
            double resto;
            if (salario <= 2000.00)
            {
                Console.WriteLine("Isento");
            }

            if (salario >= 2000.01 && salario <= 3000.00)
            {
                salario = salario - 2000;
                imposto = salario * 0.08;
                Console.WriteLine("8%");
            }

            if (salario >= 3000.01 && salario <= 4500)
            {

                salario = salario - 2000;
                imposto = 1000 * 0.08;
                salario = salario - 1000;
                imposto = salario * 0.18;
               //resto = salario - 1000;


                Console.WriteLine("8%");



                salario = salario - 2000;
               
                Console.WriteLine(imposto);


            }

            if (salario > 4500)
            {
                salario = salario - 2000;
                imposto = 1000 * 0.08;
                Console.WriteLine(imposto);
                resto = salario - 1000;

                
                imposto = 1500 * 0.18;
                Console.WriteLine(imposto);
                imposto = resto * 28;
                Console.WriteLine("28%");
            }
        }
    }
}
