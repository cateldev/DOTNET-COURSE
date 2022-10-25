 
namespace Csharp
{
    public class ContaCorrente
    {
        //public string? titular;
        //Transformamos essa propriedade pois criamos uma classe que sera responsavel por trazer essas informações
        public Cliente? titular;

        //Isso se chama principio da responsabilidade, onde uma classe nao deve ter tantas responsabilidades
        //separadas pelos seus temas, ou seja, uma classe deve tratar especificamente de somente um tema.

        public string? conta;
        public int agencia;
        public double saldo;


        //Metodos da classe ContaCorrente
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if(saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        public void Transferir(double valor, ContaCorrente destinatario)
        {
           this.Sacar(valor);
            destinatario.Depositar(valor);
        }
    }
}
