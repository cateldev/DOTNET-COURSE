/* Uma propriedade(Property) é um membro de uma classe que fornece um mecanismo flexível para ler, gravar ou calcular o valor de um dado em particular.
    As propriedades permitem que uma classe exponha de uma maneira pública a obtenção e definição destes valores.

    Por ex. Temos um Carro, uma propriedade de carro é sua cor, ou seja, Cor é um atributo(propriedade) de Carro.

    Uma propriedade pode obter um valor de uma classe e também pode defini-lo, sendo assim temos propriedades Read/Write ou apenas Readonly.

Um exemplo:*/

// Essa é sua variável interna (privada)
private string _cor;

// Essa é sua propriedade pública.
public string Cor
{
    get { return _cor; }
    set { _cor = value ;}
} 

// Fazendo Get
string CorCarro = CorCarro.Cor;

// Fazendo Set
CorCarro.Cor = "Preto";