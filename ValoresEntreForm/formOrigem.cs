using System;
using System.Windows.Forms;

namespace ValoresEntreForm
{
    public partial class frmOrigem : Form
    {
        public frmOrigem()
        {
            InitializeComponent();
        }

        private void btnPassar_Click(object sender, EventArgs e)
        {
            var value = txtOrigem1.Text;
      
            FormDestino form = new FormDestino(value);

            form.value2 = txtOrigem2.Text;
            form.Show();
            
        }

        private void btnBuscarOrigem_Click(object sender, EventArgs e)
        {
            formCep formCep = new formCep();

            formCep.Show();
        }
    }
}
