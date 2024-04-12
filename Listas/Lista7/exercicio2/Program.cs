using System;

class Program
{
    static void Main(string[] args)
    {
        const int QTDE_NUMEROS = 3;
        int[] numeros = new int[QTDE_NUMEROS];

        NumerosArmazenados(numeros);
        
        System.Console.WriteLine(MaiorNumero(numeros));

    }
    static void NumerosArmazenados(int[] numeros)
    {
        for(int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }
        System.Console.WriteLine();
    }
    
    
    static int MaiorNumero(int[] numeros)
    {
        int maiorNumeroRecebido = 0;
        
        for(int i = 0; i < numeros.Length; i++)
        {
            if(numeros[i] > maiorNumeroRecebido)
            {
                maiorNumeroRecebido = numeros[i];
            }
        }
         return maiorNumeroRecebido;
    }
}
