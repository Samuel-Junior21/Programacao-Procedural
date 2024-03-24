class Tabuleiro
{
    const int TAMANHO_TABULEIRO = 8;
    private static string[,] tabuleiro = new string[TAMANHO_TABULEIRO,TAMANHO_TABULEIRO];
    public static void Adicionar(int coordenadaX, int coordenadaY, string dado)
    {
        if ((coordenadaX < 0 || coordenadaX >= TAMANHO_TABULEIRO)
            || (coordenadaY < 0 || coordenadaY >= TAMANHO_TABULEIRO))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("você só pode inserir coordenadas entre 0 e 7");
            Console.ResetColor();
            Environment.Exit(0);
        } 

        tabuleiro[coordenadaX, coordenadaY] = dado;
    }

    public static void ImprimeTabuleiro()
    {
        System.Console.WriteLine("    0   1   2   3   4   5   6   7");
        System.Console.WriteLine("  ---------------------------------");
        for (int linha = 0; linha < TAMANHO_TABULEIRO; linha++)
        {
            System.Console.Write(linha + " ");
            for (int coluna = 0; coluna < TAMANHO_TABULEIRO; coluna++)
            {
                System.Console.Write($"| {tabuleiro[linha, coluna]} ");
            }
            System.Console.WriteLine("|");
            System.Console.Write("  ---------------------------------");
            System.Console.WriteLine();
        }
    }

    public static void InicializaTabuleiro()
    {
        for (int linha = 0; linha < TAMANHO_TABULEIRO; linha++)
        {
            for (int coluna = 0; coluna < TAMANHO_TABULEIRO; coluna++)
            {
                tabuleiro[linha, coluna] = " ";
            }
        }
    }
}