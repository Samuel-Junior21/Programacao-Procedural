using System;

class Program
{
    static void Main(string[] args)
    {
        Tabuleiro.InicializaTabuleiro();

        const int LIMITE_TABULEIRO = 8;

        for(int linha = 0; linha < LIMITE_TABULEIRO; linha++)
        {
            for(int coluna = 0; coluna < LIMITE_TABULEIRO; coluna++)
            {
                if(coluna == 0 || coluna == LIMITE_TABULEIRO -1 || linha == 0 || linha == LIMITE_TABULEIRO -1)
                {
                    Tabuleiro.Adicionar(linha,coluna,"s");
                } 
            }
        }
        Tabuleiro.ImprimeTabuleiro();
    }
}