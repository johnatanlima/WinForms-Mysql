using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
      
            formDestino form = new formDestino(value);

            form.value2 = txtOrigem2.Text;
            form.Show();
            
        }
    }
}
