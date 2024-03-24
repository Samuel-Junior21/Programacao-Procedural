using System;

class Program
{
    static void Main(string[] args)
    {
        const int ALTURA = 9;

        System.Console.WriteLine("Digite a altura: ");
        int entrada = int.Parse(Console.ReadLine());

       if(entrada <= ALTURA)
        {
            System.Console.WriteLine();
            for(int i = 1; i <= entrada; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    System.Console.Write(j);
                }
                System.Console.WriteLine();
            }
        }
        else
        {
            System.Console.WriteLine("Altura inválida, insira uma altura entre 1 e 9");
           
        }
    }
}
