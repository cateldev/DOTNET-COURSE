 
namespace Csharp
{
    public class ContaCorrente
    {
        public string? titular;
        public string? conta;
        public int agencia;
        public double saldo;


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
