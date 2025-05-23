using Enumerador;


Console.WriteLine("## Enum ##");

//Console.WriteLine(DiasDaSemana.Domingo);
//Console.WriteLine(DiasDaSemana.Terca);
//int dia1 = (int)DiasDaSemana.Domingo;
//int dia2 = (int)DiasDaSemana.Terca;
//Console.WriteLine($"\n{DiasDaSemana.Domingo} vale: {dia1}");
//Console.WriteLine($"\n{DiasDaSemana.Terca} vale: {dia2}");


Console.WriteLine($"{Categorias.Moda} - {(int)Categorias.Moda}");
Console.WriteLine($"{Categorias.Automotivo} - {(int)Categorias.Automotivo}");
Console.WriteLine($"{Categorias.Artes} - {(int)Categorias.Artes}");
Console.WriteLine($"{Categorias.Bebidas} - {(int)Categorias.Bebidas}");
Console.WriteLine($"{Categorias.Livros} - {(int)Categorias.Livros}");
Console.WriteLine($"{Categorias.Brinquedos} - {(int)Categorias.Brinquedos}");

Console.WriteLine("\nSelecione a categoria teclando o seu valor");
int valor = Convert.ToInt32(Console.ReadLine());

var nomeMembroEnum = (Categorias)valor;
Console.WriteLine($"\n Você selecionou a categoria: {nomeMembroEnum.ToString()}");

Console.ReadKey();

