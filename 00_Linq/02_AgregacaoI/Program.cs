Console.WriteLine("## Operadores de Agregação ##\n");


string[] cursos = { "C#", "Java", "Phyton", "PHP", "JavaScript", "Go" };

string resultados = cursos.Aggregate((s1,s2)=> s1 + "," + s2);

Console.WriteLine(resultados);

Console.ReadKey();