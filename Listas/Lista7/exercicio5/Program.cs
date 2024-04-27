using System;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 4;
        int[,] matriz = new int [TAMANHO_MATRIZ,TAMANHO_MATRIZ];
    
        PreencherMatriz(matriz);
        ImprimirTabuleiro(matriz);

        VerificarBalistaExistente(matriz);
    }

    static void PreencherMatriz(int[,] matriz)
    {
        for(int i = 0; i < 4; i++)
        {
            for(int k = 0; k < 4; k++)
            {
                matriz[i,k] = Convert.ToInt32(Console.ReadLine()); 
            }
        }
    }

    static void ImprimirTabuleiro(int[,] matriz)
    {
        for(int i = 0; i < 4; i++)
        {
            for(int k = 0; k < 4; k++)
            {
                System.Console.Write($"|{matriz[i,k]}|");
            }
            System.Console.WriteLine();
        }
    }
    
    
    static void VerificarBalistaExistente(int[,] matriz)
    {
        bool temBalista = false;
        
        for(int i = 0; i < 4; i++)
        {
            for(int k = 0; k < 4; k++)
            {
                if(matriz[i,k] == 0)
                {
                    temBalista = true;
                } 
            }
        }
        if(temBalista)
        {
            System.Console.WriteLine("Fique atento! Existem balistas no tabuleiro");
        } 
        else
        {
            System.Console.WriteLine("Não ha balistas no tabuleiro");
        }
    }
}