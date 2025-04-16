using System.Globalization;

namespace exerUri1038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int quant = int.Parse(valores[1]);


            double total;
            if(codigo == 1)
            {
                total = quant * 4.0;
            }
            else if (codigo == 2)
            {
                total = quant * 4.5;
            }
            else if (codigo == 3)
            {
                total = quant * 5.0;
            }
            else if (codigo == 4)
            {
                total = quant * 2.0;
            }
            else
            {
                total = quant * 1.5;
            }
            Console.WriteLine("Total: R$ " + total.ToString("F2",CultureInfo.InvariantCulture));

        }

    }
}