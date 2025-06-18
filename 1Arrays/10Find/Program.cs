﻿

List<string> frutas = new()
{
    "Uva", "Banana", "Pera", "Maça", "Abacate", "Laranja", "Morango"
};


// usando predicado como uma função
var fruta1 = frutas.Find(Procura);
Console.WriteLine($"\nPRedicado : {fruta1}");

//usando a expressão lambda
var fruta2 = frutas.Find(i => i.Contains('n'));
Console.WriteLine($"\nFind : {fruta2}");


var fruta3 = frutas.FindLast(i => i.Contains('n'));
Console.WriteLine($"\nFindLast : {fruta3}");


var fruta4 = frutas.FindIndex(i => i.Contains('n'));
Console.WriteLine($"\nFindIndex : indice={fruta4} item={frutas[fruta4]}");

var fruta5 = frutas.FindLastIndex(i => i.Contains('n'));
Console.WriteLine($"\nFindLastIndex : indice={fruta5} item={frutas[fruta5]}");

var frutas6 = frutas.FindAll(i => i.Contains('n'));

Console.Write("\nFindAll :");
foreach (var item in frutas6)
{
    Console.Write($"{item}");
}



Console.ReadKey();

static bool Procura(string item)
{
    return item.Contains('n');
}