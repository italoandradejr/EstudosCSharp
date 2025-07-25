
var timeSP = new HashSet<string>() { "Santos", "Palmeras", "São Paulo" };

var timeRJ = new HashSet<string>() { "Vasco", "Flamengo", "Fluminense" };

var timeBA = new HashSet<string>() { "Bahia", "Vitória", "Juazeiro" };

var timesMundiais = new HashSet<string>() { "Santos", "Palmeras", "São Paulo", "Flamengo" };

//if (!timeSP.Contains("Corinthians"))
//{
//    timeSP.Add("Corinthians");
//    timeSP.Add("Santos");
//}

//if (timeSP.IsSubsetOf(timesMundiais))
//{
//    Console.WriteLine("timeSP é um subconjunto de timesMndiais\n");
//}

//if (timesMundiais.IsSupersetOf(timeSP))
//{
//    Console.WriteLine("timeMundiais é um superconjunto de timesSP\n");
//}

//var resultado = timeBA.Remove("Juazeiro");


Console.WriteLine("\nJuntando os HashSet<T>: SP, RJ e BA");
timeSP.UnionWith(timeRJ);
timeSP.UnionWith(timeBA);

ExibirColecao(timeSP);

Console.ReadKey();

static void ExibirColecao<T>(IEnumerable<T> Colecao)
{
    Console.WriteLine();
    foreach (var item in Colecao)
    {
        Console.WriteLine($"{item}");
    }
}