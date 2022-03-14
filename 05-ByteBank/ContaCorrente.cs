//using _04_ByteBank; //Utilizando a classe desse namespace
                    // caso for usar uma classe varias vezes e necessario declarar no inicio utilizando a palavra reservada (using)
                    //Quando de um projeto diferente no qual foi criado 

namespace _05_ByteBank // boas praticas em uma classe sempre conter um namespace, para ser mais facil encontrado no projeto no qual pertence
                        // É em outros projetos utilizando: _04_ByteBank.Cliente, ou se for muito utilizado nesse outro projeto pode incluir ele no inicio com o using
{
    public class ContaCorrente
    {
        //atribrutos
        //tipo de classe, titular referencia da classe cliente
        public Cliente Titular { get; set; } //Propriedade, já que essa propriedade não tem nenhuma logica somente atruição de campos 
                                             //pode ser feita desta forma simplificada
        public string Agencia { get; set; }
        public string Conta { get; set; }
      
        private double _saldo = 100;// default
        public double Saldo //propriedade toda primeira letra maiuscula
        {                   // Fara que o computador crie por baixo dos panos metodos do tipo get e set. saldo
           
            get // palavra reservada precisa retornar algo, Obter
            {
                return _saldo; // Campo privado
            }
            set // palavra reserrva não precisar retornar algo obrigatoriamente, Definir 
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value; // value palavra reservada referente ao valor que o set esta recebendo de fora, argumento
            }
        }
        //função
        public bool Sacar(double valor) // Função bool retorna algo
                                        //Função boleana Sacar com o argumento double Valor 
                                        //Toda a função e em maiuscula e uma convensão da linguagem (Sacar)
                                        //Toda função representa uma ação, verbos infinitivos  
        {
            if (this._saldo < valor) //Palavra reservada this usada para buscar um campo em especifico no objeto um atributo, argumento/parametro valor serve como a quantia a ser sacada 
            {
                return false; // return palavra reservada para retornar um valor dentro de uma função
            }

            else
            {
                this._saldo -= valor; // Sempre quando for informando uma função boleana e visto como necessario pelo programa apresentar um return como afirmação
                return true;            // Quando não a colisão de nomes no escopo não e obrigatorio a palavra reservada this
            }


        }
        //metodo
        public void Depositar(double valor) // Metodo void não retorna nada, palavra reservada (Void) para metodos que não retonam nada
                                            // Metodos não precisam necessariamente ter um parametro
        {
            this._saldo += valor; //Usamos o this dentro de um método para acessar um atributo
        }

        //função
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            //É uma boa prática manter as condições que dizem que a função não deve continuar seu processamento, no início do código do método.
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            contaDestino._saldo += valor;
            return true;

        }
    }
}




