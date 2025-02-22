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
        List<ClientesDto> _listClientes = new List<ClientesDto>();
        public FormularioConsultarClientes()
        {
            InitializeComponent();
            _listClientes = _clientesController.ReadAll();
            DtgClientes.DataSource = _listClientes;
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
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {   
            if (string.IsNullOrEmpty(TbNome.Text) && string.IsNullOrEmpty(MtbDocumento.Text.Trim()))
                DtgClientes.DataSource = _listClientes;
            else
            {
                if (!string.IsNullOrEmpty(TbNome.Text) && string.IsNullOrEmpty(MtbDocumento.Text.Trim()))
                    DtgClientes.DataSource = _listClientes.Where(cliente => cliente.Nome.Contains(TbNome.Text)).ToList();
                if (string.IsNullOrEmpty(TbNome.Text) && !string.IsNullOrEmpty(MtbDocumento.Text.Trim()))
                    DtgClientes.DataSource = _listClientes.Where(cliente => cliente.CnpjCpf.Contains(MtbDocumento.Text)).ToList();
                else
                    DtgClientes.DataSource = _listClientes.Where(cliente => cliente.Nome.Contains(TbNome.Text) && cliente.CnpjCpf.Contains(MtbDocumento.Text)).ToList();
            }
        }

        private void DtgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DtgClientes.Rows[e.RowIndex];
                var _formularioPerfilClientes = new FormularioPerfilClientes(_listClientes.FirstOrDefault(cliente => cliente.Id == (int)row.Cells["Id"].Value));
                _formularioPerfilClientes.ShowDialog();
                _listClientes = _clientesController.ReadAll();
                DtgClientes.DataSource = _listClientes;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            _listClientes = _clientesController.ReadAll();
            DtgClientes.DataSource = _listClientes;
        }
    }
}
