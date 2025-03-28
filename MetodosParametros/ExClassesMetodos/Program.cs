Console.WriteLine("## EX ##");


Carros chevrolet = new Carros("Sedan", "Chevrolet", "Onix", 2016, 110);
Carros ford = new Carros("SUV", "Ford", "EcoSport", 2018, 120);


Console.WriteLine($"\n{chevrolet.Modelo}, {chevrolet.Montadora}, {chevrolet.Marca}, {chevrolet.Ano}, {chevrolet.Potencia} CV");
chevrolet.Acelerar(chevrolet.Marca);

Console.WriteLine($"{ford.Modelo}, {ford.Montadora}, {ford.Marca}, {ford.Ano}, {ford.Potencia} CV");
ford.Acelerar(ford.Marca);



Console.ReadKey();

public class Carros
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

    public Carros(string? modelo, string? montadora, string? marca, int ano, int potencia)
    {
        this.Modelo = modelo;
        this.Montadora = montadora;
        this.Marca = marca;
        this.Ano = ano;
        this.Potencia = potencia;
    }

    public void Acelerar(string carro)
    {
        Console.WriteLine($"Acelerando meu {carro}");
    }
}