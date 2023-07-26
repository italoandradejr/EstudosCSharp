using bytebank_ADM.Funcionarios;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;

#region
//Funcionario pedro = new Funcionario("524857525-78", 2000);
//pedro.Nome = "Pedro Malazartes";

//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());


//Diretor roberta = new Diretor("587584852-74");
//roberta.Nome = "Roberta Silva";


//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());


//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
//Console.WriteLine("Total de Funcionarios: " + Funcionario.TotalDeFuncionarios);

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine("Novo salário do Pedro: " + pedro.Salario);
//Console.WriteLine("Novo salário Roberta " + roberta.Salario);
#endregion

//CalcularBonificacao();

UsarSistema();

void CalcularBonificacao ()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao ();

    Designer ulisses = new Designer ("1254879");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("4658561");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("16486856456");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("415656156816");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(ulisses);

    Console.WriteLine("Total de Bonificação = " + gerenciador.TotalDeBonificacao);
}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("852741");
    ingrid.Nome = "Ingrid Novais";
    ingrid.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("645456");
    ursula.Nome = "Ursula Alcantara";
    ursula.Senha = "321";

    Auxiliar herique = new Auxiliar("235235");
    herique.Nome = "Herique Silva";
    herique.Senha = "963";


    sistema.logar(ingrid, "123");
    sistema.logar(ursula, "963");
    sistema.logar(herique, "963");
}