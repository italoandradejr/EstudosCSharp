Console.WriteLine("## Argumento por Referência - out ##");

Console.WriteLine("Informe o raio do círculo");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new Circulo();

double perimetro = circulo.CalculaAreaPerimetro(raio, out double area);


Console.WriteLine("Perímetro da Circunferencia " + perimetro);
Console.WriteLine("Área da Circunferencia: " + area);


Console.ReadKey();


public class Circulo
{
    public double CalculaAreaPerimetro (double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}