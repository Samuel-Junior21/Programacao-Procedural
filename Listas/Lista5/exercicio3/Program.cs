using System;

class Program
{
    static void Main(string[] args)
    {
        int altura = int.Parse(Console.ReadLine());
        

        int largura = int.Parse(Console.ReadLine());

        System.Console.WriteLine();
        for(int i = 1; i <= altura; i++)
        {
            for(int j = 1; j <= largura; j++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
    }
}