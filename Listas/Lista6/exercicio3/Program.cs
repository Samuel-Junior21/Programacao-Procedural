using System;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 3;

        int[,] matrix = new int[TAMANHO_MATRIZ,TAMANHO_MATRIZ];

        int somatorioMatriz = 0;

        for(int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for(int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                int resultados = int.Parse(Console.ReadLine());

                if(linha == coluna)
                {
                    somatorioMatriz = somatorioMatriz + resultados;
                }
            }
        }
        System.Console.WriteLine(somatorioMatriz);
    }
}
