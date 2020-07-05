using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int numero=Convert.ToInt32(Console.ReadLine());

            int f1=0;
            int f2=1;
            int soma=f1 + f2;

            Console.Write(0 + " " + 1 +" ");
            
            for (int i = 3; i <=numero; i++)
            {
                Console.Write(soma + " ");
                f1=f2;
                f2=soma;
                soma=f1 + f2;
            }
        }
    }
}
