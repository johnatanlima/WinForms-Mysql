using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Dao
{
    public class PessoaDAO : Conexao
    {
		MySqlCommand cmd = null; 

		//Metodo para salvar no banco
		public void Salvar(Pessoa pessoaParam)
        {
			
			try
			{
				//Metodo para fazer abertura da conexao
				abrirConexao();
				//crio a minha instrucao sql
				cmd = new MySqlCommand("insert into pessoas(Nome, Sexo, Telefone, Rua, Numero, Bairro, Cidade, Estado) values (@nome, @sexo, @telefone, @rua, @numero, @bairro, @cidade, @estado);", myConn);

				//Passo os valores que vierem do form, para criar a minha instrucao sql, atraves de parametro
				cmd.Parameters.AddWithValue("@nome", pessoaParam.Nome);
				cmd.Parameters.AddWithValue("@sexo", pessoaParam.Sexo);
				cmd.Parameters.AddWithValue("@telefone", pessoaParam.Telefone);
				cmd.Parameters.AddWithValue("@rua", pessoaParam.Rua);
				cmd.Parameters.AddWithValue("@numero", pessoaParam.Numero);
				cmd.Parameters.AddWithValue("@bairro", pessoaParam.Bairro);
				cmd.Parameters.AddWithValue("@cidade", pessoaParam.Cidade);
				cmd.Parameters.AddWithValue("@estado", pessoaParam.Estado);

				//Como será um insert 
				cmd.ExecuteNonQuery();		

			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				fecharConexao();
			}
        }

		public DataTable Buscar()
		{		
			try
			{
				abrirConexao();

				DataTable dataTable = new DataTable();
				MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

				cmd = new MySqlCommand("select * from pessoas order by nome;", myConn);

				dataAdapter.SelectCommand = cmd;

				dataAdapter.Fill(dataTable);

				return dataTable;

			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				fecharConexao();
			}
		}
		
		public void EditarPessoa(Pessoa pessoaParam)
		{
			try
			{
				abrirConexao();

				cmd = new MySqlCommand("update pessoas set Nome = @nome, Sexo= @sexo, Telefone = @telefone, Rua = @rua, Numero = @numero, Bairro = @bairro, Cidade = @cidade, Estado = @estado where Codigo = @codigo;", myConn);
				//Passo os valores que vierem do form, para criar a minha instrucao sql, atraves de parametro
				cmd.Parameters.AddWithValue("@codigo", pessoaParam.Codigo);
				cmd.Parameters.AddWithValue("@nome", pessoaParam.Nome);
				cmd.Parameters.AddWithValue("@sexo", pessoaParam.Sexo);
				cmd.Parameters.AddWithValue("@telefone", pessoaParam.Telefone);
				cmd.Parameters.AddWithValue("@rua", pessoaParam.Rua);
				cmd.Parameters.AddWithValue("@numero", pessoaParam.Numero);
				cmd.Parameters.AddWithValue("@bairro", pessoaParam.Bairro);
				cmd.Parameters.AddWithValue("@cidade", pessoaParam.Cidade);
				cmd.Parameters.AddWithValue("@estado", pessoaParam.Estado);

				//Como será um insert 
				cmd.ExecuteNonQuery();

			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				fecharConexao();
			}
		}
    }
}
