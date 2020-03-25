using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola
{
    class PessoasBLL
    {
        PessoaDAL pessoDal = null;

        public DataTable ExibirDadosDal()
        {
            try
            {
                DataTable data = new DataTable();
                pessoDal = new PessoaDAL();

                data = pessoDal.ExibirDados();

                return data;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
