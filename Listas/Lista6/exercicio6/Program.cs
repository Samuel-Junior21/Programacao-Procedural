using System;
using System.Xml;

class Program
{
    static void PreencherMatriz(int [,] matriz)
    {
        for(int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for(int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                matriz[linha,coluna] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    static void ImprimirMatriz(int[,] matriz)
    {
        for(int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for(int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                System.Console.Write($"|{matriz[linha, coluna]}|");
            }
            System.Console.WriteLine();
        }
    }
    
    static void ExecutarAcao(int[,] matriz)
    {
        System.Console.WriteLine("Selecione a acao que deseja realizar:");
        System.Console.WriteLine("[1] - Imprimir todos os elementos da Matriz");
        System.Console.WriteLine("[2] - Somar todos os elementos e exibir o resultado");
        System.Console.WriteLine("[3] - Somar todos os elementos da terceira linha (linha de índice 2) e exibir o resultado");
        System.Console.WriteLine("[4] - Somar os elementos da diagonal principal");
        System.Console.WriteLine("[5] - Somar todos os elementos de índice par da segunda linha");

        int acaoEscolhida = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine();
        
        if(acaoEscolhida == 1)
        {
            ImprimirMatriz(matriz);
        }
        else if(acaoEscolhida == 2)
        {
            SomarElementosMatriz(matriz);
        }
        else if(acaoEscolhida == 3)
        {
            SomarElementosTerceiraLinha(matriz);
        }
        else if(acaoEscolhida == 4)
        {
            SomarElementosDiagonal(matriz);
        }
        else if(acaoEscolhida == 5)
        {
            SomarIndicePar(matriz);
        }   
    }
    
    static void SomarElementosMatriz(int[,] matriz)
    {
        int somatorio = 0;

        for(int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for(int coluna = 0; coluna <matriz.GetLength(1); coluna++)
            {
                somatorio += matriz[linha, coluna];
            }
        }
        System.Console.WriteLine($"{somatorio}");
    }

    static void SomarElementosTerceiraLinha(int[,] matriz)
    {
        int somatorioTerceiraLinha = 0;
        
        for(int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for(int coluna = 0; coluna <matriz.GetLength(1); coluna++)
            {
                if(linha == 2)
                {
                    somatorioTerceiraLinha += matriz[linha, coluna];
                }
            }
        }
        System.Console.WriteLine($"{somatorioTerceiraLinha}");
    }

    static void SomarElementosDiagonal(int[,] matriz)
    {
        int somatorioDiagonal = 0;
        
        for(int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for(int coluna = 0; coluna <matriz.GetLength(1); coluna++)
            {
                if(linha == coluna)
                {
                    somatorioDiagonal += matriz[linha, coluna];
                }
            }
        }
        System.Console.WriteLine($"{somatorioDiagonal}");
    }

    static void SomarIndicePar(int[,] matriz)
    {
        int somatorioPar = 0;
        for(int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for(int coluna = 0; coluna <matriz.GetLength(1); coluna++)
            {
                if(linha == 1 && coluna < 4 && coluna % 2 == 0)
                {
                    somatorioPar += matriz[linha, coluna];
                }
            }
        }
        System.Console.WriteLine(somatorioPar);
    }
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 4;

        int[,] matriz = new int[TAMANHO_MATRIZ,TAMANHO_MATRIZ];

        PreencherMatriz(matriz);

        ExecutarAcao(matriz);

    }
}

