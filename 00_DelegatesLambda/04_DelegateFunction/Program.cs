
Console.Write("Digite um número: ");
double numero = Convert.ToDouble(Console.ReadLine());

Func<double, double> raizQuadrada = x => Math.Sqrt(x);

var resultado = raizQuadrada(numero);

Console.WriteLine("\nA raiz quadrada de " + numero + "é: " + resultado);


Console.ReadKey();
