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
    public partial class formDestino : Form
    {
        public formDestino()
        {
            InitializeComponent();
        }

        public formDestino(string valor1) //Uma maneira de passar o valor
        {
            InitializeComponent();
            txtDestino1.Text = valor1;
        }

        public string value2 { get; set; } //2° maneira de passar o valor

        private void formDestino_Load(object sender, EventArgs e)
        {
            if (!this.value2.Equals(""))
            {
                txtDestino2.Text = this.value2; // 2° maneira
            }
        }
    }
}
