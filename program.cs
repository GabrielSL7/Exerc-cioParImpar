using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine($"{numero} é par");
        }
        else
        {
            Console.WriteLine($"{numero} é ímpar");
        }
    }
}
