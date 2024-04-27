using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        string[] nomes = new string[10];

        for(int contador = 0; contador < 10; contador++)
        {
            nomes[contador] = Console.ReadLine();
        }

        string nomeSelecionado = Console.ReadLine();


        bool nomeEncontrado = false;


        for(int contador = 0; contador < 10; contador++)
        {
             if(nomes[contador] == nomeSelecionado)
             {
                nomeEncontrado = true;
             }
        }
        if(nomeEncontrado == true)
        {
             System.Console.WriteLine("ACHEI");
        }
        else
        {
            System.Console.WriteLine("NAO ACHEI");
        }
    }
}
