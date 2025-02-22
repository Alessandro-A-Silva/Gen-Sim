using Gen_Sim.Controller;
using Gen_Sim.Dto;
using Gen_Sim.Model;
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
    public partial class FormularioPerfilClientes : Form
    {
        private EnderecosController _enderecoController = new EnderecosController();
        private ClientesController _clientesController = new ClientesController();
        private ClientesDto _cliente;
        public FormularioPerfilClientes(ClientesDto clientes)
        {
            InitializeComponent();
            _cliente = clientes;
            if (_cliente.CnpjCpf.Length == 14)
                RbCNPJ.Checked = true;
            else
                RbCPF.Checked = true;

            TbNome.Text = _cliente.Nome;
            MtbCep.Text = _cliente.Cep;
            TbLogradouro.Text = _cliente.Logradouro;
            NudNumero.Value = _cliente.Numero;
            TbBairro.Text = _cliente.Bairro;
            CbEstado.Text = _cliente.Estado;
            MtbDocumento.Text = _cliente.CnpjCpf;
            MtbInscricaoEstadual.Text = _cliente.InscricaoEstadual;
            TbEmail.Text = _cliente.Email;
            TbCidade.Text = _cliente.Cidade;
            MtbTelefone.Text = _cliente.Telefone;
            MtbWhatssap.Text = _cliente.Whatssap;
        }

        private void FormularioPerfilClientes_Load(object sender, EventArgs e)
        {
           
        }

        private void RbCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            if (RbCNPJ.Checked)
                MtbDocumento.Mask = "00.000.000/0000-00";
        }

        private void RbCPF_CheckedChanged(object sender, EventArgs e)
        {
            if (RbCPF.Checked)
                MtbDocumento.Mask = "000.000.000-00";
        }

        private async void MtbCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Você tem certeza que deseja atualizar os dados do cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _cliente.Nome = TbNome.Text;
                _cliente.Cep = MtbCep.Text;
                _cliente.Logradouro = TbLogradouro.Text;
                _cliente.Numero = (int)NudNumero.Value;
                _cliente.Bairro = TbBairro.Text;
                _cliente.Estado = CbEstado.Text;
                _cliente.CnpjCpf = MtbDocumento.Text;
                _cliente.InscricaoEstadual = MtbInscricaoEstadual.Text;
                _cliente.Email = TbEmail.Text;
                _cliente.Cidade = TbCidade.Text;
                _cliente.Telefone = MtbTelefone.Text;
                _cliente.Whatssap = MtbWhatssap.Text;
                _clientesController.Update(_cliente);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja excluir os dados do cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _clientesController.Delete(_cliente);
                ClearFields();
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
