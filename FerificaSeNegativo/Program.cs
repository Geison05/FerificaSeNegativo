using System;

namespace Project
{
    class Program
    {
        static void Main(string [] args)
        {
            //Variavel 

            int A ;

            //Entrada

            A = int.Parse(Console.ReadLine());

            //Processamento / Saida

            if(A < 0)
                Console.WriteLine("NEGATIVO");
            else
                Console.WriteLine("NAO NEGATIVO");
        }
    }
}