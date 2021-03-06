﻿using System;
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

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            mkTel.Clear();
            cbSexo.SelectedIndex = -1;
            txtRua.Clear();
            txtNum.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            cbUf.SelectedIndex = -1;
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

            MessageBox.Show("Registrado com Sucesso", "Alerta", MessageBoxButtons.OK);

            BuscarPessoas();
            LimparCampos();
        }

        //Listar pessoas Cadastradas
        private void BuscarPessoas()
        {
            PessoaBll pessoaParametro = new PessoaBll();

            dgPessoas.DataSource = pessoaParametro.BuscarPessoa();

            //Renomear o cabeçalho do meu Datagrid View
            dgPessoas.Columns[0].HeaderText = "Cód";
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

            pessoaBll.EditarPessoa(pessoa);

            MessageBox.Show("Editado com Sucesso", "Alerta", MessageBoxButtons.OK);

            BuscarPessoas();
            LimparCampos();

        }

        //Exclur pessoa
        private void ExcluirPessoa(Pessoa pessoa)
        {
            PessoaBll pessoaBll = new PessoaBll();

            if (txtCodigo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Selecione a pessoa para ser excluída.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCodigo.Focus();

            }
            else if(MessageBox.Show("Deseja realmente excluir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

            }
            else
            {

                    pessoa.Codigo = Convert.ToInt32(txtCodigo.Text);

                    pessoaBll.ExcluirPessoa(pessoa);

                    MessageBox.Show("Pessoa excluida com Sucesso", "Alerta", MessageBoxButtons.OK);

                    BuscarPessoas();
                    LimparCampos();
               
            }
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

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();

            ExcluirPessoa(pessoa);
        }
    }
}
