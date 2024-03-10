using System;

class Program
{
    static void Main(string[] args)
    {
        const string USUARIOCORRETO = "admin";
        const string SENHACORRETA = "123senha";
        const int TENTATIVAS = 3;
        int contador = 0;

        do
        {
            System.Console.WriteLine("Digite o nome de usuario:");
            string usuarioInserido = Console.ReadLine();

            System.Console.WriteLine("Digite sua senha:");
            string senhaInserida = Console.ReadLine();

            if(usuarioInserido == USUARIOCORRETO && senhaInserida == SENHACORRETA)
            {
                System.Console.WriteLine("Login realizado com sucesso!!");
                break;
            }
            else
            {
                System.Console.WriteLine("Nome de usuario ou senha incorretos. Tente novamente");

                contador++;
                if(contador >= TENTATIVAS)
                {
                    System.Console.WriteLine("Sua conta foi bloqueada");
                    break;
                }
            }
        
        }
        while(contador <= TENTATIVAS);        
    }
}
