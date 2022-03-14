using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarregarContas();
                       
            Console.WriteLine("Para finalizar o programa tecle ENTER!");
            Console.ReadLine();
          
        }
        private static void CarregarContas()
        {
            LeitorDeArquivo leitor = null;
            try
            {
                leitor = new LeitorDeArquivo("contas.txt");
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();             
            }
            catch (IOException)
            {
                Console.WriteLine("Exceção do tipo IOException capturada e tratada!");
            }
            finally
            {
                if(leitor != null)
                {
                    leitor.Fechar();
                }              
            }
            
        }
        private static void TestaException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(7564, 7845965);
                ContaCorrente conta2 = new ContaCorrente(1245, 65489652);

                conta1.Transferir(10000, conta2);
                //conta1.Sacar(10000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

            }
        }
        // Teste com a cadeia de chamada:
        private static void Metodo()
        {
            TestaDivisao(0);
        }
        private static void TestaDivisao (int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }
        private static int Dividir (int numero, int divisor)
        {
            try
            {
                ContaCorrente conta = null;
                Console.WriteLine(conta.Saldo);

                return numero / divisor;

            }
            catch
            {
                Console.WriteLine("Exceção com numero=" + numero + " e divisor= " + divisor);
                throw;

            }            
        }
    }
}
