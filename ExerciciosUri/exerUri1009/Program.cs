using System.Globalization;

namespace exerUri1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string nome;
            double salariofixo, venda, salarioTotal;

            nome = Console.ReadLine();
            salariofixo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            venda= double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            salarioTotal =  salariofixo + (venda / 100 * 15.0);
            //salarioTotal = venda * 15.0 / 100 + salariofixo;

            Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2",CultureInfo.InvariantCulture));
            



        }
    }
}