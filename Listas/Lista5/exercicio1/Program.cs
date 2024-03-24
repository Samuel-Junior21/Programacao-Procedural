using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        const int MAXIMO = 100;
        const int MINIMO = 0;

        int i = 0;
        int k = 204;

        while(i <= MAXIMO && k >= MINIMO)
        {
            k -= 4;

            System.Console.WriteLine($"{i} - {k}");

            i += 2;
        }
    }
}
