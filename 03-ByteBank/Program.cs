using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Função sacar
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine("Saldo atual em conta " + contaDoBruno.saldo);
            bool resultadoSaque = contaDoBruno.Sacar(150);  // visto como necessario respeitar o tipo da variavel, neste caso a função (Sacar) e um tipo boleando
                                                            //então caso tenha que transferir para outra variavel tera que ser feita no mesmo tipo (boleana)
                                                            //Chamando um metodo (contaDoBruno.Sacar(150);)
                                                            //                nomeDaReferencia.NomeDoMetodo();
                                                            //              Variavel/instancia . Função/metodo                   
            Console.WriteLine("Saque " + resultadoSaque);   
            Console.WriteLine("Saldo atual em conta " + contaDoBruno.saldo);
            Console.WriteLine();

            //Metodo Deposito
            contaDoBruno.Depositar(200);
            Console.WriteLine("Saldo do Bruno " + contaDoBruno.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.Depositar(500);
            Console.WriteLine("Saldo da Gabriela " + contaDaGabriela.saldo);
            Console.WriteLine();

            //Função Transferir
            bool resultadoTransferir = contaDaGabriela.Transferir(150, contaDoBruno);

            Console.WriteLine("Saldo conta da Gabriela " + contaDaGabriela.saldo);
            Console.WriteLine("Saldo conta do Bruno " + contaDoBruno.saldo);
            Console.WriteLine("Resultado da transferência " + resultadoTransferir);

            Console.ReadLine();

    
        }
    }
}
