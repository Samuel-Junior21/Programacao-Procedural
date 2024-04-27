using System;
using System.Runtime.InteropServices;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        const int QTDE_VAGOES = 12;
        int[] vagoes = new int[QTDE_VAGOES];

        int vagaoPesoUltrapassado = 0;
        
        PesoVagoes(vagoes);
        
        VerificacaoVagoes(vagoes,vagaoPesoUltrapassado);
    }

    static void PesoVagoes(int[] vagoes)
    {
        for(int i = 0; i < vagoes.Length; i++)
        {
            vagoes[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    static void VerificacaoVagoes(int[] vagoes, int vagaoPesoUltrapassado)
    {
        for(int i = 0; i < vagoes.Length; i++)
        {
            if(vagoes[i] > 50)
            {
                vagaoPesoUltrapassado = i + 1;

                System.Console.WriteLine($"{vagaoPesoUltrapassado}° ultrapassou o limite de peso");
            }    
        }  
    }   
}
