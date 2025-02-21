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
    public partial class FormularioCadastrarClientes : Form
    {
        private EnderecosController _enderecoController = new EnderecosController();
        private ClientesController _clientesController = new ClientesController();
        public FormularioCadastrarClientes()
        {
            InitializeComponent();
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
            if (MtbCep.Text.Length == 8)
            {
                var endereco = await _enderecoController.ReadByCep(MtbCep.Text);

                TbLogradouro.Text = endereco.logradouro;
                TbBairro.Text = endereco.bairro;
                TbCidade.Text = endereco.localidade;
                CbEstado.Text = endereco.estado;
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = new ClientesDto()
                {
                    Nome = TbNome.Text,
                    Cep = MtbCep.Text,
                    Logradouro = TbLogradouro.Text,
                    Numero = (int)NudNumero.Value,
                    Bairro = TbBairro.Text,
                    Estado = CbEstado.Text,
                    CnpjCpf = MtbDocumento.Text,
                    InscricaoEstadual = MtbInscricaoEstadual.Text,
                    Email = TbEmail.Text,
                    Cidade = TbCidade.Text,
                    Telefone = MtbTelefone.Text,
                    Whatssap = MtbWhatssap.Text
                };
                if(_clientesController.Create(cliente))
                    ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar! " + ex.Message, "Dados do Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void ClearFields()
        {
            TbNome.Clear();
            MtbCep.Clear();
            TbLogradouro.Clear();
            NudNumero.Value = 0;
            TbBairro.Clear();
            CbEstado.SelectedIndex = -1;
            RbCNPJ.Checked = true;
            MtbDocumento.Clear();
            MtbInscricaoEstadual.Clear();
            TbEmail.Clear();
            TbCidade.Clear();
            MtbTelefone.Clear();
            MtbWhatssap.Clear();
        }
    }
}
