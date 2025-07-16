using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_IA.Formularios
{
    public partial class Dashboard : Form
    {
        public Dashboard(string versao)
        {
            InitializeComponent();
            Versao.Text = versao;
            this.KeyPreview = true; // <<< Permite que o formulário capture teclas
            this.KeyDown += new KeyEventHandler(this.Atalhos_KeyDown); // <<< Associa o evento de tecla
        }

        private async void Atalhos_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                Close();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.F1)
            {
                PDV();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.F11)
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    WindowState = FormWindowState.Normal;
                }
                else
                {
                    WindowState = FormWindowState.Maximized;

                }
                e.Handled = true;
            }
        }

        public void PDV()
        {
            //this.Hide();

            PDV janelaPDV = new PDV();
            janelaPDV.FormClosed += (s, args) => this.Show();
            janelaPDV.Show();
        }
    }
}
