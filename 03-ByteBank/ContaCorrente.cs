

public class ContaCorrente
{
    //atribrutos
    public string titular; 
    public int agencia;
    public int conta;
    public double saldo = 100;


    //função
    public bool Sacar(double valor) // Função bool retorna algo
    //Função boleana Sacar com o argumento double Valor 
    //Toda a função e em maiuscula e uma convensão da linguagem (Sacar)
    //Toda função representa uma ação, verbos infinitivos  
    {
        if (this.saldo < valor) //Palavra reservada this usada para buscar um campo em especifico no objeto um atributo, argumento/parametro valor serve como a quantia a ser sacada 
        {
            return false; // return palavra reservada para retornar um valor dentro de uma função
        }

        else
        {
            this.saldo -= valor; // Sempre quando for informando uma função boleana e visto como necessario pelo programa apresentar um return como afirmação
            return true;
        }


    }
    //metodo
    public void Depositar(double valor) // Metodo void não retorna nada, palavra reservada (Void) para metodos que não retonam nada
                          // Metodos não precisam necessariamente ter um parametro
    {
        this.saldo += valor; //Usamos o this dentro de um método para acessar um atributo
    }

    //função
    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        //É uma boa prática manter as condições que dizem que a função não deve continuar seu processamento, no início do código do método.
        if (this.saldo < valor)
        {
            return false;
        }
 
        this.saldo -= valor;
        contaDestino.saldo += valor;
        return true;

    }



}


