
namespace Csharp
{
    //Aqui detalharemos o titular, dessa forma retiramos a variavel da classe ContaCorrente
    //Criamos um classe Cliente onde haverá os detalhes sobre o titular 

    public class Cliente
    {
        public string? nome;
        public string? profissao;
        public string? cpf;

        public static implicit operator Cliente(string v)
        {
            throw new NotImplementedException();
        }
    }
}
