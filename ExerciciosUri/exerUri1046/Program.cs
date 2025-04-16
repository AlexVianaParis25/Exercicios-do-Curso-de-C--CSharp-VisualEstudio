namespace exerUri1046
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string [] vet = Console.ReadLine().Split(' ');
            int inicio = int.Parse(vet[0]);
            int final = int.Parse(vet[1]);

            int  duracao;
            if(inicio < final)
            {
                duracao = final - inicio;
            }
            else
            {
                duracao = 24 - inicio + final;
            }
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}