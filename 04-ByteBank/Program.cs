using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente Gabriela = new Cliente();//Criando um objeto/instancia da classe cliente 

            Gabriela.nome = "Gabriela";
            Gabriela.profissao = "Desenvolvedora C#";
            Gabriela.CPF = "435.568.247.89";



            ContaCorrente conta = new ContaCorrente(); // conta e uma referencia para o objeto do tipo conta ContaCorrente armazenado na memoria da CPU

            conta.titular = Gabriela; //titular referencia da classe cliente 
            conta.saldo = 500;
            conta.agencia = 563;
            conta.conta = 5634527;

            conta.titular.nome = "Gabriela Costa";

            Console.WriteLine(Gabriela.nome);
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.CPF);

            //Outra forma de acessar a classe cliente, atrinuindo uma nova instância ao campo (titular), uma forma mais direta
            //conta.titular = new Cliente();
            //conta.titular.nome = "";
            //conta.titular.CPF = "";
            //conta.titular.profissao = "";

            //if (conta.titular == null) exemplo da palavra reservado tipo null, quando uma referência não tem para onde apontar 

            //Console.WriteLine("Ops, a referência em conta.titular é NULL");



            Console.ReadLine();
        }
    }
}

