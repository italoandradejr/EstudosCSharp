using byteBank.Contas;
using byteBank.Titular;

//ContaCorrente contaItalo = new ContaCorrente();
//contaItalo.titular = "Italo de Andrade";
//contaItalo.numero_agencia = 15;
//contaItalo.conta = "1010-X";
//contaItalo.saldo = 100;

//Console.WriteLine("Saldo da Conta do Italo inicial = " + contaItalo.saldo);


//ContaCorrente contaMaria = new ContaCorrente();
//contaMaria.titular = "Maria da Silva";
//contaMaria.numero_agencia = 17;
//contaMaria.conta = "1010-5";
//contaMaria.saldo = 350;

//Console.WriteLine("Saldo da Conta da Maria inicial = " + contaMaria.saldo);


//contaItalo.Transferir(50, contaMaria);

//Console.WriteLine("Saldo da conta do Italo após transferência = " + contaItalo.saldo);
//Console.WriteLine("Saldo da conta da Maria após transferência = " + contaMaria.saldo);

//Cliente cliente = new Cliente();
//cliente.nome = "Italo Andrade";
//cliente.cpf = "36519350476";
//cliente.profissao = "Engenheiro";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-x";
//conta.numero_agencia = 15;
//conta.saldo = 100;

//Console.WriteLine("Titular = " + conta.titular.nome);
//Console.WriteLine("CPF = " + conta.titular.cpf);
//Console.WriteLine("Profissão = " + conta.titular.profissao);
//Console.WriteLine("N° Conta = " + conta.conta);
//Console.WriteLine("Saldo = " + conta.saldo);
//Console.WriteLine("N° Agência = " + conta.numero_agencia);



//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "José Souza";
//conta2.titular.profissao = "Dev";
//conta2.titular.cpf = "36512445225";
//conta2.conta = "9999-X";
//conta2.numero_agencia = 18;
//conta2.saldo = 500;

//Console.WriteLine(conta2.titular.nome);

//ContaCorrente conta3 = new ContaCorrente();
//conta3.Numero_agencia = 18;
//conta3.Conta = "1001-G";
//conta3.SetSaldo(200);
//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.Numero_agencia);
//Console.WriteLine(conta3.Conta);

//ContaCorrente conta4 = new ContaCorrente(18, "1010-X");
//conta4.SetSaldo(500);
//conta4.Titular = new Cliente();
//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_agencia); 

ContaCorrente conta5 = new ContaCorrente(283, "1234-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta6 = new ContaCorrente(284, "7854-D");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta7 = new ContaCorrente(984, "7824-D");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);