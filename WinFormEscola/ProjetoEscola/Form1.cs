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
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PessoasBLL pessoas = new PessoasBLL();

            try
            {
                dgPessoas.DataSource = pessoas.ExibirDadosDal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exibir dados.. " + ex);
            }
        }
    }
}
