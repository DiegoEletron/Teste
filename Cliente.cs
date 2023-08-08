using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M3A6
{
   public class Cliente
    {
        // atributos privados, são visualizados apenas na classe
        private string nome; 
        private string telefone;

        // métodos publicos, são visualizados em todas as classes do programa
        public string NomeCliente
        { 
            set
            {
                nome = value;
            }
            get
            {
                return nome;
            }
        }

        public string TelefoneCliente
        {
            set
            {
                telefone = value;
            }
            get
            {
                return telefone;
            }
        }


     
    }
}
