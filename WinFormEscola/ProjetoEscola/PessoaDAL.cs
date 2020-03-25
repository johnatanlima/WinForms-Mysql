using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola
{
    class PessoaDAL
    {
        string connString = "server=localhost;database=escola;uid=root;pwd=root;";

        MySqlConnection myConn =null;
        MySqlCommand myCmd;

        public DataTable ExibirDados()
        {
            try
            {
                myConn = new MySqlConnection(connString);
                
                myCmd = new MySqlCommand("select * from pessoas", myConn);

                MySqlDataAdapter da = new MySqlDataAdapter(myCmd);

                da.SelectCommand = myCmd;

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
