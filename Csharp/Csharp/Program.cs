
using Csharp;

//Criando os novos objetos de Conta Corrente.

ContaCorrente contaMatheus = new ContaCorrente();
contaMatheus.titular = "Matheus Catel";
contaMatheus.agencia = 15;
contaMatheus.conta = "1022-5";
contaMatheus.saldo = 200;

ContaCorrente contaIsabela = new ContaCorrente();
contaIsabela.titular = "Isabela Mendes";
contaIsabela.agencia = 22;
contaIsabela.conta = "10044-33";
contaIsabela.saldo = 250;

//Chamando os métodos criados.

Console.WriteLine("Saldo da conta do Matheus Catel = " + contaMatheus.saldo);
Console.WriteLine("Saldo da conta da Isabela Mendes = " + contaIsabela.saldo);


contaMatheus.Sacar(50);
Console.WriteLine("Saque de 50 reais");
Console.WriteLine("Saldo da conta do Matheus Catel = " + contaMatheus.saldo);

contaMatheus.Depositar(300);
Console.WriteLine("Deposito de 300 reais");
Console.WriteLine("Saldo da conta do Matheus Catel = " + contaMatheus.saldo);

contaMatheus.Transferir(100, contaIsabela);
Console.WriteLine("Trasnferencia de 100 reais");
Console.WriteLine("Saldo da conta do Matheus Catel = " + contaMatheus.saldo);
Console.WriteLine("Saldo da conta da Isabela Mendes = " + contaIsabela.saldo);



