using System;

class Program
{
    static void Main(string[] args)
    {
        const int NUMERO_HABITANTES = 3;

        double salarioAtual = 0;

        int numeroDeFilhos = 0;

        double maiorSalario = 0;
        
        double somatorioSalarial = 0;
        
        int somatorioNumeroFilhos = 0;
        
        for(int i = 1 ; i <=NUMERO_HABITANTES; i++)
        {
            System.Console.WriteLine($"Qual é o salario do {i}º habitante?");
            salarioAtual = int.Parse(Console.ReadLine());

            somatorioSalarial = somatorioSalarial + salarioAtual;
            
            System.Console.WriteLine($"o número de filhos do {i}º habitante: ");
            numeroDeFilhos = int.Parse(Console.ReadLine());

            somatorioNumeroFilhos = somatorioNumeroFilhos + numeroDeFilhos;

            if (salarioAtual > maiorSalario)
            {
                maiorSalario = salarioAtual;
            }



        }
        
            double mediaSalarial = somatorioSalarial / NUMERO_HABITANTES;

            double mediaDeFilhos = somatorioNumeroFilhos / NUMERO_HABITANTES;

            System.Console.WriteLine($"Media salarial: {Math.Round(mediaSalarial,2)}");
            System.Console.WriteLine($"Media do numero de filhos por habitante: {mediaDeFilhos}");
            System.Console.WriteLine($"Maior Salario: {maiorSalario}");




    }
}