using System;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 3;
        
        int[,] matriz = new int[TAMANHO_MATRIZ,TAMANHO_MATRIZ];

        int valores = 0;
        
        for(int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for(int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                valores = int.Parse(Console.ReadLine());

                matriz[linha,coluna] = valores;
            }
        }
        System.Console.WriteLine();
        
        for(int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for(int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                if(coluna + linha == 2)
                {
                    matriz[linha,coluna] *= 2;
                }
                System.Console.Write($"{matriz[linha,coluna]}|");
            }
            System.Console.WriteLine();
        }
    }
}
