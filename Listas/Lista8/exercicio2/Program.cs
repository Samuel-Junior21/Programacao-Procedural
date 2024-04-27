using System;

struct Produto
{
    public int id;
    public string nome;
    public double preco;
    public bool disponivelNoEstoque;
}

class Program
{
    static void Main(string[] args)
    {
        const int QTDE_PRODUTOS = 4;
        
        Produto[] produtos = new Produto[QTDE_PRODUTOS];

        InserirDados(produtos);

        System.Console.WriteLine();

        ImprimirProdutosNoEstoque(produtos);
    }

    static void InserirDados(Produto[] produtos)
    {
        for(int i = 0; i < produtos.Length; i++)
        {
            produtos[i].id = Convert.ToInt32(Console.ReadLine());
            produtos[i].nome = Convert.ToString(Console.ReadLine());
            produtos[i].preco = Convert.ToDouble(Console.ReadLine());
            produtos[i].disponivelNoEstoque = Convert.ToBoolean(Console.ReadLine());
        }
    }
    static  void ImprimirProdutosNoEstoque(Produto[] produtos)
    {
        for(int i = 0; i < produtos.Length; i++)
        {
            if(produtos[i].disponivelNoEstoque == true)
            {
                System.Console.WriteLine(produtos[i].nome);
                System.Console.WriteLine(produtos[i].preco.ToString("0.00"));
            }
        }
    }
}