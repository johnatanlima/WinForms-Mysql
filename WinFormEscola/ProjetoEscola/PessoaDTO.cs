using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola
{
    class PessoaDTO
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Nacionalidade { get; set; }

        public DateTime DataNascimento { get; set; }

        public double Peso { get; set; }
    }
}
