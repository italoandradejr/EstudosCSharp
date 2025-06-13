

//declarar uma coleção de tipo List<T>

List<int> lista2 = new List<int>();
var lista1 = new List<int>();
List<double> lista3 = new();

List<string> nomes = new();
nomes.Add("Paulo");
nomes.Add("Maria");

var lista4 = new List<string>()
{
    "Paulo", "Maria", "Bia", "Pedro", "Carlos", "Zé"
};

lista4.Add("Marta"); // acrescenta o item ao final da lista 

lista4.Insert(2, "Bia"); // acrescenta o item de acordo com o paramêtro



//---------------------------------------------------------------------------------------


var lista5 = new List<string>()
{
    "Paulo", "Maria", "Bia", "Pedro"
};

//acessar um elemento da lista usando indice

var primeiro = lista5[0];
var quarto = lista5[3];


for (int i = 0; i<lista5.Count; i++)
{
    Console.WriteLine(lista5[i]);
}





Console.ReadKey();