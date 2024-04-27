using System;

struct Pizza
{
    public int id;
    public string sabor;
    public double preco;

}

class Program
{
    static void Main(string[] args)
    {
        Pizza pizza;

        pizza.id = Convert.ToInt32(Console.ReadLine());
        pizza.sabor = Console.ReadLine();
        pizza.preco = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine();

        ImprimirDados(pizza);
    }
    static void ImprimirDados(Pizza pizza)
    {
      System.Console.WriteLine(pizza.id);

      System.Console.WriteLine(pizza.sabor);

      System.Console.WriteLine(pizza.preco);




    }
}

