namespace exerUri1048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, novoSalario, percentual;


            salario = double.Parse(Console.ReadLine());
            percentual= double.Parse(Console.ReadLine());


            novoSalario = salario + (percentual / 100 * salario);


            Console.WriteLine(novoSalario);

        }
    }
}