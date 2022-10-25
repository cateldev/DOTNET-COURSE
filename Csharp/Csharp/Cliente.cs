
namespace Csharp
{
    //Aqui detalharemos o titular, dessa forma retiramos a variavel da classe ContaCorrente
    //Criamos um classe Cliente onde haverá os detalhes sobre o titular 

    public class Cliente
    {
        //Vamos implementar as propriedades autoimplementadas nas propriedades abaixo:
        /*  
            public string? nome;
            public string? profissao;
            public string? cpf; 
        */
        //Deixará de ser como está acima e ficará assim:

        public string? Nome { get; set; }
        public string? Profissao { get; set; }   
        public string? Cpf { get; set; }


        public static implicit operator Cliente(string v)
        {
            throw new NotImplementedException();
        }
    }
}
