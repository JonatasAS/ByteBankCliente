using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaBruno = new ContaCorrente();

            contaBruno.titular = "Bruno";
            Console.WriteLine(contaBruno.titular);
            Console.WriteLine(contaBruno.saldo);

            Console.ReadLine();
        }
    }
}
