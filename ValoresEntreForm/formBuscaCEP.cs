using Correios.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValoresEntreForm
{
    public partial class formCep : Form
    {
        public formCep()
        {
            InitializeComponent();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                HttpClient http = new HttpClient();
                
                var response = http.GetAsync("https://viacep.com.br/ws/55345000/json/");

                var result = response.Result.StatusCode.ToString();
                
                if (response == null)
                {
                    MessageBox.Show("erro", "alerta");
                }
                else
                {
                    MessageBox.Show("Deu certo", "alerta");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Deu um erro locao aii", "alerta");
            }
        }
    }
}
