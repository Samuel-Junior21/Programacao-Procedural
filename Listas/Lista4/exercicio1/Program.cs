<<<<<<< HEAD
﻿using System;

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
=======
﻿using System;

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
>>>>>>> 9c3e60fafef1fb3a89120b29da5b9d28bbbcdf32
