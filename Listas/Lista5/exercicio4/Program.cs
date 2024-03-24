using System;

class Program
{
    static void Main(string[] args)
    {
        int numero = 0;

        for(int i = 1; i > 0; i++)
        {
            int numeroInserido = int.Parse(Console.ReadLine());

            if(numeroInserido % 2 == 1)
            {
                numero += numeroInserido;
            }
            else if(numeroInserido < 0)
            {
                break;
            }
        }
        System.Console.WriteLine($"O somatorio de impares é: {numero}");
    }
}
