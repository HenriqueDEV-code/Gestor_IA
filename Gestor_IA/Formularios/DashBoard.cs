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
    // Confirmação do código conforme solicitado

    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // No form principal
        }

        // Variáveis para realizar o movimento do Forms
        private bool _Movimento = false;
        private Point _PosicaoInicialMouse;

        private void BT_Encerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BT_Minimizar_Click(object sender, EventArgs e)
        {
            // Minimiza a janela para a barra de tarefas, independente do tamanho atual
            this.WindowState = FormWindowState.Minimized;
        }

        private void Painel_de_Controle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _Movimento = true;
                _PosicaoInicialMouse = e.Location;
            }
        }

        private void Painel_de_Controle_MouseMove(object sender, MouseEventArgs e)
        {
            if (_Movimento)
            {
                // Calcular a nova posição da janela
                this.Location = new Point(
                    this.Location.X + e.X - _PosicaoInicialMouse.X,
                    this.Location.Y + e.Y - _PosicaoInicialMouse.Y
                );
            }
        }

        private void Painel_de_Controle_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _Movimento = false;
            }
        }

        // Maximiza o formulário para o tamanho especificado (1617, 918)
        private void Ampliar_Click(object sender, EventArgs e)
        {
            // Deixa o formulário maior que (1617, 918), ocupando quase toda a tela
            this.Size = new Size(
                Screen.PrimaryScreen.WorkingArea.Width - 5,
                Screen.PrimaryScreen.WorkingArea.Height - 5
            );
            this.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
            );
            Ampliar.Visible = false;
            Normallizar.Visible = true;
        }

        // Restaura o formulário para o tamanho normal (1617, 918)
        private void Normallizar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1617, 918);
            this.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
            );
            Ampliar.Visible = true;
            Normallizar.Visible = false;
        }

        private void BT_Clientes_Click(object sender, EventArgs e)
        {
            
        }

        private void BT_Mercadorias_Click(object sender, EventArgs e)
        {
            
        }
    }
}
