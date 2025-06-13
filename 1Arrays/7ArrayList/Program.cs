using System.Collections;

var lista = new ArrayList() { "Maria", 5, true, 4.5, null, DateTime.Now };


//verificar se um elemento existe na coleção
var rest1 = lista.Contains(5);
bool res2 = lista.Contains("Mari");

Console.WriteLine(rest1);
Console.WriteLine(res2);
Console.WriteLine(lista.Contains(null));



Console.ReadKey();
