using System.Globalization;
namespace extremamenteBasico
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um numero: ");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Digite outro numero: ");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int X = A + B;
            Console.WriteLine("A soma dos numeros " + A + " e " + B + " é: " + X);

        }
    }
}