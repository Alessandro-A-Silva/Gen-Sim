using Gen_Sim.Controller;
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
    public partial class FormularioCadastrarClientes : Form
    {
        private EnderecosController _cepController;
        public FormularioCadastrarClientes()
        {
            InitializeComponent();
            _cepController = new EnderecosController();
        }

        private void FormularioCadastrarClientes_Load(object sender, EventArgs e)
        {
            RbCNPJ.Checked = true;
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

        private async void MtbCep_TextChanged(object sender, EventArgs e)
        {
            if(MtbCep.Text.Length == 8)
            {
                var endereco = await _cepController.GetEndereco(MtbCep.Text);
                if(endereco != null)
                {
                    TbLogradouro.Text = endereco.logradouro;
                    TbBairro.Text = endereco.bairro;
                    TbCidade.Text = endereco.localidade;
                    CbEstado.Text = endereco.estado;
                }
            }
        }
    }
}
