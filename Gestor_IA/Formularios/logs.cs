using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_IA.Formularios
{
    public partial class logs : Form
    {
        private string versao = "Version - 0.0.0.2";
        public logs()
        {
            InitializeComponent();
            LB_versao.Text = versao;
            this.KeyPreview = true; // <<< Permite que o formulário capture teclas
            this.KeyDown += new KeyEventHandler(this.Atalhos_KeyDown); // <<< Associa o evento de tecla
        }

        private async void Atalhos_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                login();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
                e.Handled = true;
            }
     
        }


        private void login()
        {
            MessageBox.Show("Login efetuado...");

            this.Hide();

            Dashboard janelaDashboard = new Dashboard(versao);
            janelaDashboard.FormClosed += (s, args) => this.Show();
            janelaDashboard.Show();

        }
    }
}
