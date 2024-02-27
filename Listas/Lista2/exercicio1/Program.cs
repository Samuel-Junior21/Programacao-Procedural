using System;


class Program
{

    public static void Main (string[] args)
    {

        Console.WriteLine("Digite seu login: ");
        string login = Console.ReadLine();

        Console.WriteLine("Digite sua senha: ");
        string senha = Console.ReadLine();

        if(login == "admin" && senha == "123senha")
        {

            Console.WriteLine("Login realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Credenciais Inválidas!");
        }
    }
}

