using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M3A6
{
    class PessoaJuridica : Cliente
    {
        // atributos privados, são visualizados apenas na classe
        private string cnpj; 
        private string empresa;


        // métodos publicos, são visualizados em todas as classes do programa
        public string PessoaCnpj{ 
            set { cnpj = value; }
            get { return cnpj; }
        }

        public string PessoaEmpresa {
            set { empresa = value; }
            get { return empresa; }
        }
    }
}
