using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Jonatas";
            cliente.CPF = "457.562.953.65";
            cliente.Profissao = "Desenvolvedor";

            conta.Saldo = -10;// Set/ Definir 
                              //Propriedade
            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Titular.CPF);
            Console.WriteLine(conta.Titular.Profissao);
            Console.WriteLine(conta.Saldo); // Get/Obter
                                    //Propriedade
            Console.ReadLine();
        }
    }
}
