using bytebank.Contas;
using bytebank.Titular;

//ContaCorrente contadoandre = new ContaCorrente();
//contadoandre.titular = "andré silva";
//contadoandre.numero_agencia = 15;
//contadoandre.conta = "1010-x";
//contadoandre.saldo = 100;
//Console.WriteLine("saldo da conta do andré = " + contadoandre.saldo);

//ContaCorrente contadoandre2 = new ContaCorrente();
//contadoandre2.titular = "andré silva";
//contadoandre2.numero_agencia = 15;
//contadoandre2.conta = "1010-x";
//contadoandre2.saldo = 100;
//Console.WriteLine("saldo da conta do andré = " + contadoandre.saldo);

//Console.WriteLine(contadoandre==contadoandre2);

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria Souza";
//contaDaMaria.numero_agencia = 17;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo = 350;

//Console.WriteLine("Saldo da conta da Maria =" + contaDaMaria.saldo);

//contaDoAndre.Transferir(50, contaDaMaria);
//Console.WriteLine("Saldo do André = "+ contaDoAndre.saldo);
//Console.WriteLine("Saldo da Maria = "+ contaDaMaria.saldo);

//ContaCorrente contaDoPedro = new ContaCorrente();
//Console.WriteLine(contaDoPedro.titular);
//Console.WriteLine(contaDoPedro.saldo);
//Console.WriteLine(contaDoPedro.numero_agencia);
//Console.WriteLine(contaDoPedro.conta);

//Cliente cliente = new Cliente();
//cliente.nome = "André Silva";
//cliente.cpf = "123456789";
//cliente.profissao = "Analista";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numero_agencia = 15;
//conta.saldo = 100;

//Console.WriteLine("Titular = " + conta.titular.nome);
//Console.WriteLine("Cpf = " + conta.titular.cpf);
//Console.WriteLine("Profissão = " + conta.titular.profissao);
//Console.WriteLine("N° Conta = " + conta.conta);
//Console.WriteLine("Saldo = " + conta.conta);
//Console.WriteLine("N° Agência = " + conta.numero_agencia);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "Jóse Souza";
//conta2.titular.profissao = "Tester";
//conta2.titular.cpf = "423523523";
//conta2.conta = "9999-x";
//conta2.numero_agencia = 18;
//conta2.saldo = 500;

//Console.WriteLine(conta2.titular.nome);

//ContaCorrente conta3 = new ContaCorrente();
//conta3.Numero_agenccia = 18;
//conta3.Conta = "1011-H";
//conta3.SetSaldo (200);
//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.Numero_agenccia);
//Console.WriteLine(conta3.Conta);

//ContaCorrente conta4 = new ContaCorrente(18, "1010-X");
//conta4.SetSaldo(500);
//conta4.titular = new Cliente();
//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_agenccia);

ContaCorrente conta5 = new ContaCorrente(288, "1234-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta6 = new ContaCorrente(284, "9874-Z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);