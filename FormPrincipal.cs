using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetTech
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFuncionario func = new FormFuncionario();
            func.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente cli = new FormCliente();
            cli.Show();
        }

        private void servicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormServico serv = new FormServico();
            serv.Show();
        }

        private void animaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAnimais anima = new FormAnimais();
            anima.Show();
        }

        private void racaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRaca raca = new FormRaca();
            raca.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgenda agen = new FormAgenda();
            agen.Show();
        }
    }
}
