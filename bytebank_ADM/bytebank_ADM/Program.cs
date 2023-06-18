using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro Malazartes";
pedro.Cpf = "524857525-78";
pedro.Salario = 2000.00;

//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());


Diretor roberta = new Diretor();
roberta.Nome = "Roberta Silva";
roberta.Cpf = "587584852-74";
roberta.Salario = 5000.00;

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());


GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);