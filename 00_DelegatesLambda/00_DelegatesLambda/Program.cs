
using _00_DelegatesLambda;

var resultado = Calculadora.Somar(10, 40);

Console.WriteLine(resultado);


DelegateCalculadora calc = new DelegateCalculadora(Calculadora.Somar);
var resultado1 = calc.Invoke(20, 30);
Console.WriteLine($"Somar = {resultado1}");


DelegateCalculadora calc2 = Calculadora.Somar;
var resultado2 = calc2.Invoke(20, 30);
Console.WriteLine($"Somar = {resultado2}");

DelegateCalculadora calc3 = (float x, float y) => Calculadora.Somar(x, y);
var resultado3 = calc3.Invoke(20, 30);
Console.WriteLine($"Somar = {resultado3}");

Console.ReadKey();

public delegate float DelegateCalculadora(float x,  float y);