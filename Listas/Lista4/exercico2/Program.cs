using System;
using System.Reflection;

class Program
{

    static void Main(string[] args)
    {

        const int TOTAL = 9;

        System.Console.WriteLine("Insira um número: ");
        int valor = int.Parse(Console.ReadLine());

        if(valor <= TOTAL)
        {
            System.Console.WriteLine();
            for(int y = 1; y <= valor; y++)
        {
            for(int x = 1; x <= y; x++)
            {
                System.Console.WriteLine(x);
            }
            System.Console.WriteLine();
        }
        }
        else
        {
            System.Console.WriteLine("Altura inválida, insira uma altura entre 1 e 9! ");
        }

    }
}
