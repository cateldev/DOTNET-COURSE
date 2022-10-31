 
namespace Csharp
{
    public class ContaCorrente
    {
        //public string? titular;
        //Transformamos essa propriedade pois criamos uma classe que sera responsavel por trazer essas informações
        //public Cliente? titular; => Vamos transforma também usando as autoimplementadas:
        public Cliente? Titular { get; set; }
 
        //Isso se chama principio da responsabilidade, onde uma classe nao deve ter tantas responsabilidades
        //separadas pelos seus temas, ou seja, uma classe deve tratar especificamente de somente um tema.

        //public string? conta; => Para a propriedade conta, usaremos o chamado de 'Propriedades Autoimplementadas'
        //Deixando nossa propriedade da seguinte forma:
        public string? Conta { get; set; }

        //As 'Propriedades Autoimplementadas' servem para deixar o código mais enxuto.

        private int _agencia;
        //public int agencia; -> Essa propriedade, para nossa segurança, deve ser privada também porém podemos fazer o encapsulamento
        //pois fica inviavel criar metodos de Get e Set para todas as propriedades privadas.
        //Dessa forma, com o encapsulamento podemos até fazer validações dentro dessas propriedades.
        //A propriedade agencia ficará da seguinte forma:

        public int Agencia
        {
            get
            {
                return this._agencia;
            }
            set
            {
                if (value > 0)
                {
                    this._agencia = value;
                }
            }
        }

        //Vamos adotar esses encapsulamentos como padrão da nossa aplicação. Usaremos dessa forma ou por metodos.
        //Para os campos internal e private usamos o prefixo _ (underscore).
        //Exemplos: private bool _status; internal string _descricao;
        //Por essa razão, vamos mudar nosso private int agencia; => private string _agencia;
        //Faremos a mesma coisa para o private double saldo; => private double _saldo;
        
        
        private double _saldo;

        //Vamos criar uma propriedade para nos trazer o total de contas correntes criadas no sistema:
        //Porém precisamos que essa propriedade seja tenha relação com a Classe ContaCorrente e não um objeto
        //Para isso precisamos incluir antes do tipo de dado, "static".
        //Isso significa que agora "TotalContas" pertecem a Classe ContaCorrente e não os objetos criados dela.
        
        public static int TotalContas { get; private set; }


        //Metodos da classe ContaCorrente
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if(_saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }

        public void Transferir(double valor, ContaCorrente destinatario)
        {
           this.Sacar(valor);
            destinatario.Depositar(valor);
        }

        public void SetSaldo(double valor)
        {
            if(valor < 0)
            {
                return;
            }
            else
            {
                this._saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this._saldo;
        }

        //Vamos criar nosso metodo construtor dos objetos ContaCorrente

        public ContaCorrente(int Agencia, string Conta)
        {
            this.Agencia = Agencia;
            this.Conta = Conta;
            //Vamos adicionar no construtor, a soma que fara conta corrente +1, toda vez que uma conta for criada:
            TotalContas ++;
            //Podemos observar que no "TotalContas" não foi usado o "this". Isso ocorre pois o this serve para instanciar a
            //propriedade do objeto e aqui não estamos tratando de uma propriedade de um objeto mas sim de uma propriedade
            //da Classe ContaCorrente.
        }
    }
}
