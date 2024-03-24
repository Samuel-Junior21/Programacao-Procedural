using System;

class Program
{
    static void Main(string[] args)
    {
        for(int i = 1; i <= 10; i++)
        {
            for(int j = 1; j <= 10; j++)
            {

                int multiplicacao = i*j;
                System.Console.WriteLine($"{i} X {j} = {multiplicacao}");

                if(j == 10)
                {
                    System.Console.WriteLine();
                }
            }
        }
    }
}
