
using Csharp;

//Criando os novos objetos de Conta Corrente.

//ContaCorrente contaMatheus = new ContaCorrente();
//contaMatheus.titular = "Matheus Catel"; => Ajustando também a propriedade titular:
//contaMatheus.Titular = "Matheus Catel";
//contaMatheus.agencia = 15; -> Como fizemos um encapsulamento da propriedade agencia, não chamamos mais ela dessa.
//A nova forma correta fica:
//contaMatheus.Agencia = 15;
//Agora iremos corrigir os outros "agencia" presente nos objetos.
//contaMatheus.conta = "1022-5"; => Temos que arrumar o "conta" também:
//contaMatheus.Conta = "1022-5";
// contaMatheus.saldo = 200; -> Se fizermos dessa forma não irá compilar pois o saldo está como private, então temos que chamar o metodo
// inves da propriedade. Faremos isso abaixo:
//contaMatheus.SetSaldo(200);

//ContaCorrente contaIsabela = new ContaCorrente();
//contaIsabela.Titular = "Isabela Mendes";
//contaIsabela.Agencia = 22;
//contaIsabela.Conta = "10044-33";
// contaIsabela.saldo = 250; -> Se fizermos dessa forma não irá compilar pois o saldo está como private, então temos que chamar o metodo
// inves da propriedade. Faremos isso abaixo:
//contaIsabela.SetSaldo(250);

//Criando os novos objetos de Cliente
//Cliente clienteAlexandre = new Cliente();
/*
    clienteAlexandre.nome = "Alenxadre Catel";
    clienteAlexandre.cpf = "12312344";
    clienteAlexandre.profissao = "Gerente";
*/
//Como usamos as propriedades autoimplementadas nas propriedades da classe Cliente, temos que atualizar no objeto aqui
//Então ficará da seguinte forma:

//clienteAlexandre.Nome = "Alexandre Catel";
//clienteAlexandre.Cpf = "12312344";
//clienteAlexandre.Profissao = "Gerente";

//Chamando os métodos criados.

/*Console.WriteLine("Saldo da conta do Matheus Catel = " + contaMatheus.saldo);*/
/*Console.WriteLine("Saldo da conta da Isabela Mendes = " + contaIsabela.saldo);*/

// No trecho comentado acima também não funcionará devido a propriedade estar como privada. Vamos ajustar conforme abaixo:

//Console.WriteLine("Saldo da conta do Matheus Catel = " + contaMatheus.GetSaldo());
//Console.WriteLine("Saldo da conta da Isabela Mendes = " + contaIsabela.GetSaldo());


//contaMatheus.Sacar(50);
//Console.WriteLine("Saque de 50 reais");
//Console.WriteLine("Saldo da conta do Matheus Catel = " + contaMatheus.GetSaldo());

//contaMatheus.Depositar(300);
//Console.WriteLine("Deposito de 300 reais");
//Console.WriteLine("Saldo da conta do Matheus Catel = " + contaMatheus.GetSaldo());

//contaMatheus.Transferir(100, contaIsabela);
//Console.WriteLine("Trasnferencia de 100 reais");
//Console.WriteLine("Saldo da conta do Matheus Catel = " + contaMatheus.GetSaldo());
//Console.WriteLine("Saldo da conta da Isabela Mendes = " + contaIsabela.GetSaldo());

//Vamos criar uma nova conta corrente, desta vez com o construtor criado por nós na Classe ContaCorrente

ContaCorrente contaTesteMatheus = new ContaCorrente(10, "1010-x");

//Dessa vez foi necessario passarmos parametros para nossa ContaCorrente, pois lá na Classe definimos isso
Console.WriteLine(contaTesteMatheus.Agencia);
Console.WriteLine(contaTesteMatheus.Conta);
