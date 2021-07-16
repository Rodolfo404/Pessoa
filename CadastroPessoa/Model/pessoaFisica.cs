using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa.Endereco

{
    class PessoaFisica : Pessoa
    {
        public string Rg { get; set; }
        public string Cpf { get; set; }

        public Endereco endereco { get; set; }



    }
}
