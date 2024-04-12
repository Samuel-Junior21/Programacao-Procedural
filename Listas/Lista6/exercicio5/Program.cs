using System;

class Program
{
    static void Main(string[] args)
    {
        const int LIMITE_DADOS = 10;

        int[] vetor = new int[LIMITE_DADOS];


        int dadosInseridos = 0;

        int contador = 0;


        while(contador < LIMITE_DADOS)
        {
            dadosInseridos = int.Parse(Console.ReadLine());

            if(dadosInseridos >= 10 && dadosInseridos <= 50)
            {
                 vetor[contador] = dadosInseridos;
                contador++;
            }
        }
        System.Console.WriteLine();
        
        for(int i = 0; i < vetor.Length; i++)
        {
            System.Console.WriteLine(vetor[i]);
        }
        
         

    }
}
