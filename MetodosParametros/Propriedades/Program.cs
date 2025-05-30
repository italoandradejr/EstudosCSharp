﻿Console.WriteLine("## Propriedades ##\n");

Produto p1 = new Produto();

p1.Nome = "Caderno";
p1.Preco = 4.99;
p1.EstoqueMinimo = 10;

p1.Exibir();


Console.ReadKey();


public class Produto
{
    private string? nome; // campo de apoio
    public string? Nome
    {
        get { return nome.ToUpper(); }
        set { nome = value; }
    }


    private double preco; // campo de apoio
    public double Preco
    {
        get { return preco; }
        set
        {
            if (value < 5.00) preco = 5.00;
            else preco = value;
        }

    }

    private double desconto = 0.05;
    public double Desconto
    {
        get { return desconto; }
    }


    public double PrecoFinal 
    { 
        get { return Preco - (Preco * Desconto); }
    }


    private int minimo; // campo de apoio
    public int EstoqueMinimo 
    {
        set { minimo = value; }
    }

    public void Exibir()
    {
        Console.WriteLine($"{Nome} \n{Preco.ToString("c")} \n{Desconto} \n{PrecoFinal.ToString("c")} \n{minimo}");
    }
}