using System.Globalization;

namespace exerUri1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cod1, quant1, preco1, cod2, quant2, preco2, total;

            string [] vet = Console.ReadLine().Split(' ');
            cod1 = double.Parse(vet[0]);
            quant1= double.Parse(vet[1]);
            preco1= double.Parse(vet[2], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            cod2= double.Parse(vet[0]);
            quant2= double.Parse(vet[1]);
            preco2= double.Parse(vet[2], CultureInfo.InvariantCulture);

            total = (preco1*quant1) + (preco2*quant2);
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));


            




        }
    }
}