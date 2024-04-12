using System;

class Program
{

    static void Main(string[] args)
    {

        for(int i = 1; i <= 10; i++)
        {
            for(int m = 1; m <= 10; m++)
            {
                int multiplicacao = i*m;
                System.Console.WriteLine($"{i} X {m} = {multiplicacao} "); 

                if (m == 10)
                {
                    System.Console.WriteLine("\n");
                }
            }
        }
    }
}
