
using _10_Ling_II;

var listaProdutos = Produtos.GetProdutos();

Console.WriteLine("\nFirst - Localiza o primeiro elemento");
var primeiroProduto = listaProdutos.First();
Console.WriteLine($"{primeiroProduto.Nome} \t{primeiroProduto.Preco:C2}");


Console.WriteLine("\nFirst - Localiza o primeiro elemento usando um critéro de Nome");

try
{
    var primeiraOcorrencia1 = listaProdutos.First(p => p.Nome == "Cadeira");
    Console.WriteLine($"{primeiraOcorrencia1.Nome} \t{primeiraOcorrencia1.Preco:C2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


Console.ReadKey();