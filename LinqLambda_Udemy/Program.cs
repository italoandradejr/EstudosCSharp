using LinqLambda_Udemy.Entities;
using System;
using System.Linq;
using System.Runtime.InteropServices;


namespace LinqLambda_Udemy;

class Program
{
    static void Imprimir<T>(string msg, IEnumerable<T> colecao)
    {
        Console.WriteLine(msg);
        foreach (T obj in colecao)
        {
            Console.WriteLine(obj);
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Categoria c1 = new Categoria() { Id = 1, Nome = "Ferramentas", nivel = 2 };
        Categoria c2 = new Categoria() { Id = 2, Nome = "Computadores", nivel = 1 };
        Categoria c3 = new Categoria() { Id = 3, Nome = "Eletronicos", nivel = 1 };

        List<Produto> produtos = new List<Produto>()
        {
            new Produto() { Id = 1, Nome = "Computer", Preco = 1100.0, CategoriasP = c2 },
            new Produto() { Id = 2, Nome = "Hammer", Preco = 90.0, CategoriasP = c1 },
            new Produto() { Id = 3, Nome = "TV", Preco = 1700.0, CategoriasP = c3 },
            new Produto() { Id = 4, Nome = "Notebook", Preco = 1300.0, CategoriasP = c2 },
            new Produto() { Id = 5, Nome = "Saw", Preco = 80.0, CategoriasP = c1 },
            new Produto() { Id = 6, Nome = "Tablet", Preco = 700.0, CategoriasP = c2 },
            new Produto() { Id = 7, Nome = "Camera", Preco = 700.0, CategoriasP = c3 },
            new Produto() { Id = 8, Nome = "Printer", Preco = 350.0, CategoriasP = c3 },
            new Produto() { Id = 9, Nome = "MacBook", Preco = 1800.0, CategoriasP = c2 },
            new Produto() { Id = 10, Nome = "Sound Bar", Preco = 700.0, CategoriasP = c3 },
            new Produto() { Id = 11, Nome = "Level", Preco = 70.0, CategoriasP = c1 }

        };

        // nivel 1 com preço menor que 900.00
        //var r1 = produtos.Where(p => p.CategoriasP.nivel == 1 && p.Preco < 900.0); //filtra itens de uma lista
        var r1 =
            from p in produtos
            where p.CategoriasP.nivel == 1 && p.Preco < 900.00
            select p;
        Imprimir("Nivel 1 e preco menor que 900", r1);



        //var r2 = produtos.Where(p => p.CategoriasP.Nome == "Ferramentas").Select(p => p.Nome);
        var r2 = 
            from p in produtos
            where p.CategoriasP.Nome == "Ferramentas"
            select p;
        Imprimir("Nomes dos produtos descritos como Ferramentas", r2);

        //var r3 = produtos.Where(p => p.Nome[0] == 'C').Select(p => new { p.Nome, p.Preco, CategoriaNome = p.CategoriasP.Nome });
        var r3 =
            from p in produtos
            where p.Nome[0] == 'C'
            select new
            {
                p.Nome,
                p.Preco,
                CategoriaNome = p.CategoriasP.Nome
            };


        Imprimir("Nomes começados com a letra C e obj anonimos", r3);

        var r4 = produtos.Where(p => p.CategoriasP.nivel == 1).OrderBy(p => p.Preco).ThenBy(p => p.Nome);
        Imprimir("Ordenado por preço e depois por nome", r4);

        var r5 = r4.Skip(2).Take(4);
        Imprimir("Ordenado por preço, pular os 2 primeiros e pegar os 4 proximos", r5);

        var r6 = produtos.First();
        Console.WriteLine("Primeiro produto: ", r6);

        var r7 = produtos.Where(p => p.Preco > 3000.0).FirstOrDefault();
        Console.WriteLine("Primeiro ou padrão teste2:", r7);
        Console.WriteLine();

        var r8 = produtos.Where(p => p.Id == 3).SingleOrDefault();
        Console.WriteLine("único ou padrão teste3: ", r8);

        var r9 = produtos.Where(p => p.Id == 30).SingleOrDefault();
        Console.WriteLine("único ou padrão teste4: ", r9);

        var r10 = produtos.Max(p => p.Preco);
        Console.WriteLine("Preço máximo: " + r10);

        var r11 = produtos.Min(p => p.Preco);
        Console.WriteLine("Preço minimo: " + r11);

        var r12 = produtos.Where(p => p.CategoriasP.Id == 1).Sum(p => p.Preco);
        Console.WriteLine("Soma de preços da categoria 1: " + r12);

        Console.WriteLine();

        var r16 = produtos.GroupBy(p => p.CategoriasP);
        foreach (IGrouping<Categoria, Produto> grupo in r16)
        {
            Console.WriteLine("categoria " + grupo.Key.Nome + ":");
            foreach(Produto p in grupo)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
        }
    }
}
