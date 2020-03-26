using MySql.Data.MySqlClient;
using System;


namespace ProjetoEscola.Dao
{
    public class Conexao
    {
        string connString = "server=localhost;database=escola;uid=root;pwd=root;";

        protected MySqlConnection myConn = null; //Aqui eu apenas faço uma declaração para uso de uma classe

        public void abrirConexao()
        {
            try
            {
                myConn = new MySqlConnection(connString); //Nessa parte é onde, de fato, crio um objeto da instancia em contexto
                myConn.Open();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                myConn.Close();
            }
        }

        public void fecharConexao()
        {
            try
            {
                myConn = new MySqlConnection(connString);
                myConn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
