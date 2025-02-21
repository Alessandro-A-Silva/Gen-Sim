using Gen_Sim.Controller;
using Gen_Sim.Dto;
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
    public partial class FormularioConsultarClientes : Form
    {
        ClientesController _clientesController = new ClientesController();
        List<ClientesDto> listClientes = new List<ClientesDto>();
        public FormularioConsultarClientes()
        {
            InitializeComponent();
        }

        private void RbCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            if (RbCNPJ.Checked)
                MtbDocumento.Mask = "00.000.00/0000-00";
        }

        private void RbCPF_CheckedChanged(object sender, EventArgs e)
        {
            if (RbCPF.Checked)
                MtbDocumento.Mask = "000.000.000-00";
        }

        private void FormularioConsultarClientes_Load(object sender, EventArgs e)
        {
            RbCNPJ.Checked = true;
            DtgClientes.DataSource = listClientes;
            //DtgClientes.DataSource = _clientesController.ReadAll();
        }
    }
}
