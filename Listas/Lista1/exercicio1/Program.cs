 using System;

class Program 
{
  public static void Main (string[] args)
  {
    Console.WriteLine ("Digite a nota do 1° BIMESTRE: ");
    double nota1 = double.Parse(Console.ReadLine());


    Console.WriteLine ("Digite a nota do 2° BIMESTRE: ");
    double nota2 = double.Parse(Console.ReadLine());


    Console.WriteLine ("Digite a nota do 3° BIMESTRE: ");
    double nota3 = double.Parse(Console.ReadLine());


    Console.WriteLine ("Digite a nota do 4° BIMESTRE: ");
    double nota4 = double.Parse(Console.ReadLine());


    double media = (nota1 + nota2 + nota3 + nota4) / 4;




    Console.WriteLine($"Sua média é de: {media}. ");
    

 
    

    
    








    
  }
}
