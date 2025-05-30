
//declaração de array
int[] numeros;


//aloquei memoria
numeros = new int[10] { 1,2,3,4,5,6,7,8,9,10};

string[] nomes = new string[5] { "Ana", "Italo", "Rachel", "Gabriel", "Bete" };

// simplificada
//string[] nomes1 = { "Ana", "Italo", "Rachel", "Gabriel", "Bete" };
//Console.WriteLine(nomes[2]);


for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Elemento de índice {i} : {nomes[i]}");
}


