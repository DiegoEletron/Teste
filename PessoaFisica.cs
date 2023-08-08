using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M3A6
{
    class PessoaFisica : Cliente
    {
        private string cpf; // atributo privado, visualizado apenas na classe

        // método publico, visualizado em todas as classes do programa
        public string PessoaCpf { 

            set { cpf = value; } 
            get { return cpf; }
        }

    }
}
