using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEscola
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            BuscarPessoas();
        }

        private void Salvar(Pessoa pessoa)
        {
            PessoaBll pessoaBll = new PessoaBll();

            pessoa.Nome = txtNome.Text;
            pessoa.Sexo = cbSexo.Text;
            pessoa.Telefone = mkTel.Text;
            pessoa.Rua = txtRua.Text;
            pessoa.Bairro = txtBairro.Text;
            pessoa.Numero = txtNum.Text;
            pessoa.Cidade = txtCidade.Text;
            pessoa.Estado = cbUf.Text;

            pessoaBll.AdicionarPessoa(pessoa);

            MessageBox.Show("Registrado com Sucesso", "Salvo com sucesso", MessageBoxButtons.OK);

            BuscarPessoas();
        }

        //Listar pessoas Cadastradas
        private void BuscarPessoas()
        {
            PessoaBll pessoaParametro = new PessoaBll();

            dgPessoas.DataSource = pessoaParametro.Buscar();
        }

        //Editar pessoa
        private void EditarPessoa(Pessoa pessoa)
        {
            PessoaBll pessoaBll = new PessoaBll();

            pessoa.Codigo = Convert.ToInt32(txtCodigo.Text);
            pessoa.Nome = txtNome.Text;
            pessoa.Sexo = cbSexo.Text;
            pessoa.Telefone = mkTel.Text;
            pessoa.Rua = txtRua.Text;
            pessoa.Bairro = txtBairro.Text;
            pessoa.Numero = txtNum.Text;
            pessoa.Cidade = txtCidade.Text;
            pessoa.Estado = cbUf.Text;

            pessoaBll.Editar(pessoa);

            MessageBox.Show("Editado com Sucesso", "Editando pessoa", MessageBoxButtons.OK);

            BuscarPessoas();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pessoa pessoaParametro = new Pessoa();

            Salvar(pessoaParametro);
        }

        private void dgPessoas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgPessoas.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgPessoas.CurrentRow.Cells[1].Value.ToString();
            cbSexo.Text = dgPessoas.CurrentRow.Cells[2].Value.ToString();
            mkTel.Text = dgPessoas.CurrentRow.Cells[3].Value.ToString();
            //txtRua.Text = ru, num bairro cida
            txtRua.Text = dgPessoas.CurrentRow.Cells[4].Value.ToString();
            txtNum.Text = dgPessoas.CurrentRow.Cells[5].Value.ToString();
            txtBairro.Text = dgPessoas.CurrentRow.Cells[6].Value.ToString();
            txtCidade.Text = dgPessoas.CurrentRow.Cells[7].Value.ToString();
            cbUf.Text = dgPessoas.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();

            EditarPessoa(pessoa); 

        }
    }
}
