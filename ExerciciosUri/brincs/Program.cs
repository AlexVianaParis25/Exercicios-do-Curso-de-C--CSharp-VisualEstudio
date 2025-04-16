namespace brincs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] vet = Console.ReadLine().Split(' ');
            int inicio = int.Parse(vet[0]);
            int final = int.Parse(vet[1]);



            int horario;
            if (inicio < final)
            {
                horario = final - inicio;
                Console.WriteLine(horario);
            }
            else
            {
                horario = 24 - inicio + final;
                Console.WriteLine(horario);
            }


           
        }
    }
}