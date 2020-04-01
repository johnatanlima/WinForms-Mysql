using ProjetoEscola.Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola
{
    public class PessoaBll
    {
        PessoaDAO daoPessoa = new PessoaDAO();

        public void AdicionarPessoa(Pessoa pessoa)
        {
            try
            {
                daoPessoa.Salvar(pessoa);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable Buscar()
        {
            try
            {
                DataTable data = new DataTable();

                data = daoPessoa.Buscar();

                return data;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //public DataTable ExibirDadosDal()
        //{
        //    try
        //    {
        //        DataTable data = new DataTable();
        //        pessoDal = new PessoaDAL();

        //        data = pessoDal.ExibirDados();

        //        return data;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}
    }
}
