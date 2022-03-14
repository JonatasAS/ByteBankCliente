using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank // nome da classe 
{
    public class Cliente
    {
       
        private string _cpf;
   
        public string Nome { get; set; }
        public string Profissao { get; set; }

        public string CPF
        {
            get
            {
                return _cpf;
            }

            set
            {
                // Escrevo minha logica de validação de CPF
                _cpf = value;
            }

        }       
        
      
       

    }
}
