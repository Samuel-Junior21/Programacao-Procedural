using System;

class Program
{
    static void Main(string[] args)
    {
        int idadeInserida = Convert.ToInt32(Console.ReadLine());

        ClassificarNadador(idadeInserida);
    }

    static void ClassificarNadador(int idadeInserida)
    {
        if(NadadorInfantil(idadeInserida))
        {
            System.Console.WriteLine("Infantil");
        }
        else if(NadadorJuvenilA(idadeInserida))
        {
            System.Console.WriteLine("Juvenil A");
        }
        else if(NadadorJuvenilB(idadeInserida))
        {
            System.Console.WriteLine("Juvenil B");
        }
        else if(Adulto(idadeInserida))
        {
            System.Console.WriteLine("Adulto");
        }
    }
    
    static bool NadadorInfantil(int idadeInserida)
    {
        return idadeInserida < 12;
    }
    static bool NadadorJuvenilA(int idadeInserida)
    {
        return idadeInserida >= 12 && idadeInserida < 15;
    }
    static bool NadadorJuvenilB(int idadeInserida)
    {
        return idadeInserida >= 15 && idadeInserida < 18;
    }
    static bool Adulto(int idadeInserida)
    {
        return idadeInserida >= 18;
    }
}
