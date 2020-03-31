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
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pessoa pessoaParametro = new Pessoa();

            Salvar(pessoaParametro);
        }
    }
}
