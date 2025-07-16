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
    public partial class PDV : Form
    {
        public PDV()
        {
            InitializeComponent();
            this.KeyPreview = true; // <<< Permite que o formulário capture teclas
            this.KeyDown += new KeyEventHandler(this.Atalhos_KeyDown); // <<< Associa o evento de tecla
        }


        private async void Atalhos_KeyDown(object sender, KeyEventArgs e)
        {
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
            if (e.KeyCode == Keys.Escape)
            {
                Close();
                e.Handled = true;
            }
        }

        private void siticoneContainer1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aloneButton5_Click(object sender, EventArgs e)
        {

        }

        private void aloneButton8_Click(object sender, EventArgs e)
        {

        }
    }
}
