using System;

class Program
{
    static void Main(string [] args)
    {
        System.Console.WriteLine("Itens no carrinho: ");        
        int itensComprados = int.Parse(Console.ReadLine());       
        
        double precoTotal = 0;

        int contador = 1;
        
        const double FRETE_GRATIS = 150;
        
        while(contador <= itensComprados)
        {
            System.Console.WriteLine($"Preço do {contador}º produto: ");
            double preco = double.Parse(Console.ReadLine());

            precoTotal = precoTotal + preco;
            contador++;
        }   
        if(precoTotal >= FRETE_GRATIS)
            {
                System.Console.WriteLine($"Parabéns! Você ganhou frete grátis em sua compra de valor total: {precoTotal}");
            }
            else
            {
                System.Console.WriteLine($"O valor da sua compra ficou de: {precoTotal}");
            }
    
    
    }
}
