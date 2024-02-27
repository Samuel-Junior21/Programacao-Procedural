using System;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Digite a nota do primeiro bimestre: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota do segundo bimestre: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota do terceiro bimestre: ");
        double nota3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota do quarto bimestre: ");
        double nota4 = double.Parse(Console.ReadLine());

        double media = (nota1 + nota2 + nota3 + nota4) / 4;

        if(media >= 5)
        {
            Console.WriteLine("Aluno Aprovado!");
        }
        else if (media < 5 && media >= 3)
        {
            Console.WriteLine("ALuno em recuperação!");
        }
        else if (media < 3)
        {
            Console.WriteLine("Aluno reprovado!");
        }


    }
}
