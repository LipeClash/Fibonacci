using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro (>=2): ");
            int numero=Convert.ToInt32(Console.ReadLine());

            int f1=0;
            int f2=1;
            int soma=0;

            if (numero < 2)
            {
                Console.WriteLine("Favor digitar um número maior ou igual a 2");
                Environment.Exit(-1);
            }
            
            for (int i = 0; i < numero; i++)
            {
                Console.Write(soma + " ");
                soma=f1 + f2;
                f2=f1;
                f1=soma;
            }
        }
    }
}
