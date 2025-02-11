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





        //private void CbClienteTipo_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //if (CbClienteTipo.SelectedIndex == 0)
        //    //{
        //    //    MtbDocumento.Mask = "00.000.000/0000-00";
        //    //}
        //    //else
        //    //{
        //    //    MtbDocumento.Mask = "000.000.000-00";
        //    //}
        //    //MtbDocumento.Enabled = true;
        //}

    }
}
