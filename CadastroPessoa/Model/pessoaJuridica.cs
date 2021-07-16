using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa.Model
{
    class pessoaJuridica : Pessoa
    {
        public string Ie { get; set; }
        public string Cnpj { get; set; }
        public Endereco endereco { get; set; }



    }
}
