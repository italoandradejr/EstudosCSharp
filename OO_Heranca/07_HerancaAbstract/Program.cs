
using _07_HerancaAbstract;

Quadrado q = new Quadrado();
Console.WriteLine(q.Descricao());

Console.WriteLine("\nInforme a cor da Figura");
q.Cor = Console.ReadLine();

Console.WriteLine("\nInforme o valor do lado do quadrado");
q.Lado = Convert.ToInt32(Console.ReadLine());

q.CalcularArea();
q.CalcularPerimetro();

Console.WriteLine($"\nArea do Quadrado: { q.Area } m2");
Console.WriteLine($"\nPerímetro do Quadrado: {q.Perimetro} m2");

Console.WriteLine($"\nO quadrado tem a cor : {q.Cor}");


Console.ReadKey();