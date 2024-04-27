using System;

class Program
{
    static void Main(String[] args)
    {
        int numero = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine(NumeroVerificado(numero)); 
    }
    static bool NumeroVerificado(int numero)
    {
        return numero % 2 == 0;
    }
}
