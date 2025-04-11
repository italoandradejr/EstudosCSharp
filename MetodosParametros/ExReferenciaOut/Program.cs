Console.WriteLine("##Ex Argumento com Referencia Out##");

Metodo metodo = new Metodo();

Console.WriteLine("Informe a potencia do motor");
int potencia = Convert.ToInt32(Console.ReadLine());

double novaPotencia = metodo.AumentaPotenciaVelocidade(potencia, out double velocidade);

Console.WriteLine($"POTENCIA: " + potencia);
Console.WriteLine($"velocidade: " + velocidade);

Console.ReadKey();



public class Metodo()
{
    public double AumentaPotenciaVelocidade(int potencia, out double velocidade)
    {
        velocidade = (potencia + 7) * 1.75;
        return potencia;
    }
}