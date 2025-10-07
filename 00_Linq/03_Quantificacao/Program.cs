

int[] numeros = { 10, 22, 32, 44, 56, 64, 78 };

var resultado = numeros.All(n=> n % 2 == 0);

var resultado2 = (from n in numeros
                 select n).All(n=> n%2==0);

Console.WriteLine($"{(resultado ? "Todos são pares" : "Nem todos são pares") }");



Console.ReadKey();