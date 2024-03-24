using System;

class Program
{
    static void Main(string[] args)
    {

        const int MINIMO = 1;

        const int maximo = 10;

        for(int i = 10; i >= MINIMO; i--)
        {
            for(int j = 0; j <= 10; j++)
            {
                System.Console.WriteLine($"{i} X {j} = {i*j}");
            }
            System.Console.WriteLine();
        }
    }
}