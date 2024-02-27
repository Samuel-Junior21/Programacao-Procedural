using System;

class Program
{

    static void Main(string[] args)
    {

        Console.WriteLine("Gostaria de ver a ronita de qual das crianças?\nFilomena\nJoselito ");

        string criancaEscolhida = Console.ReadLine();

        if(criancaEscolhida == "Filomena")
        {
            Console.WriteLine("ROTINA DE FILOMENA: ");
            Console.WriteLine("1. Escola das 07h às 12h");
            Console.WriteLine("2. Almoço das 12h às 13h");
            Console.WriteLine("3. Futebol das 14h às 16h");
            Console.WriteLine("4. Dever de casa das 16h às 18h");

        }
        else if(criancaEscolhida == "Joselito")
        {
            Console.WriteLine("ROTINA DE JOSELITO: ");
            Console.WriteLine("1. Escola das 07h às 12:30");
            Console.WriteLine("2. Almoço das 13h às 14h");
            Console.WriteLine("3. Natação das 14h às 16h");
            Console.WriteLine("4. Reforço Escolar das 16h às 19h");

        }
        else
        {
            Console.WriteLine("Criança não identificada!");
        }
    }
}
