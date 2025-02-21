using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gen_Sim.View
{
    public partial class FormularioPrincipal : Form
    {
        private FormularioCadastrarClientes _formularioCadastrarClientes = new FormularioCadastrarClientes();
        private FormularioConsultarClientes _formularioConsultarClientes = new FormularioConsultarClientes();
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formularioCadastrarClientes.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formularioConsultarClientes.ShowDialog();
        }
    }
}
