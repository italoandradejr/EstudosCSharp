using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Util;
using System.Threading.Channels;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

//TestaArrayInt();

//TestaBuscarPalavra();



void TestaArrayInt ()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine($"Tamanho do Array {idades.Length}");

    int acumulador = 0;
    for ( int i = 0; i < idades.Length; i++ )
    {
        int idade = idades[i];
        Console.WriteLine($"indice [{i}] = {idade}");
        acumulador += idade;
    }

    int media = acumulador / idades.Length;

    Console.WriteLine($"\nsomatória = {acumulador}");
    Console.WriteLine($"\n A Média das idade é: {media}");
}

void TestaBuscarPalavra ()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++ )
    {
        Console.Write($"Digite {i + 1} ° Palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write("Digite palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}");
            break;
        }
    }
}

Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

//TestaMediana(amostra);
void TestaMediana(Array array)
{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para cáculo da mediana está vazio ou nulo");
    }

    double[] numerosOrdenados = (double []) array.Clone();
    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
        (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;

    Console.WriteLine($"Mediana: {mediana}");
}

void TestaArrayDeContasCorrentes ()
{

    ContaCorrente[] listaDeContas = new ContaCorrente[]
    {
        new ContaCorrente(874, "5679787-A"),
        new ContaCorrente(874, "5679787-B"),
        new ContaCorrente(874, "5679787-C"),
    };

    for (int i = 0; i < listaDeContas.Length; i++)
    {
        ContaCorrente contaAtual = listaDeContas[i];
        Console.WriteLine($"Índice {i} - Conta: {contaAtual.Conta}");
    }
}


//TestaArrayDeContasCorrentes();

void TestaArrayDeContasCorrentes2 ()
{

    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();

        listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
        listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
        listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));


    /*
    ContaCorrente[] listaDeContas = new ContaCorrente[]
    {
        new ContaCorrente(874, "5679787-A"),
        new ContaCorrente(874, "4456668-B"),
        new ContaCorrente(874, "7781438-C")
    };

    
    for (int i = 0; i < listaDeContas.Length; i++)
    {
        ContaCorrente contaAtual = listaDeContas[i];
        Console.WriteLine($"Índice {i} - Conta: {contaAtual.Conta}");
    }
    */
}

TestaArrayDeContasCorrentes2();
