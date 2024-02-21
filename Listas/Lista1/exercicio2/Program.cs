using System;

class Program 
{
  public static void Main (string[] args)
  {
    Console.WriteLine ("Digite o valor da base do triângulo: ");
   double baseTriangulo = double.Parse(Console.ReadLine());

   Console.WriteLine ("Digite o valor da altura do triângulo: ");
   double alturaTriangulo = double.Parse(Console.ReadLine());

   double valortotal = (baseTriangulo * alturaTriangulo) / 2;

   bool analista = (valortotal > 20);



    Console.WriteLine($"A área do triângulo é maior que 20? {analista}.");
    

 
    

    
    








    
  }
}

