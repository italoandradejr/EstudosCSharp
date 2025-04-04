Console.WriteLine("## Passando argumento por valor ##\n");

int x = 20;

Console.WriteLine("\nValor do argumento x antes de passar por valor " + x);

Calculo calculo = new Calculo();

calculo.Dobrar(x); // ref para criar uma referencia
Console.WriteLine("\nValor do argumento x depois de passar por valor " + x);



Console.ReadKey();


public class Calculo // classe
{
    public void Dobrar(int y) // metodo (colocar ref na frente do int para criar uma referencia)
    {
        y *= 2; // y=y*2;
        Console.WriteLine("\nValor do parâmetro y no método Dobrar " + y);
    }
}