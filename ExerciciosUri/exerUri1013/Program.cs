﻿namespace exerUri1013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, maiorab, maior;
            


            string [] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);
            
          
         

            maiorab = (a+b+Math.Abs(a-b)) / 2;

            maior = (maiorab + c + Math.Abs(maiorab - c)) / 2;


            Console.WriteLine(maior + " eh o maior");


        }
    }
}