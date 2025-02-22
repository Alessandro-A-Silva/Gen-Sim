namespace Gen_Sim.View
{
    partial class FormularioConsultarClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GbConsultarCliente = new GroupBox();
            LbClientes = new Label();
            DtgClientes = new DataGridView();
            BtnPesquisar = new Button();
            MtbDocumento = new MaskedTextBox();
            LbDocumento = new Label();
            GbTipoDocumento = new GroupBox();
            RbCPF = new RadioButton();
            RbCNPJ = new RadioButton();
            TbNome = new TextBox();
            LbNome = new Label();
            GbConsultarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtgClientes).BeginInit();
            GbTipoDocumento.SuspendLayout();
            SuspendLayout();
            // 
            // GbConsultarCliente
            // 
            GbConsultarCliente.Controls.Add(LbClientes);
            GbConsultarCliente.Controls.Add(DtgClientes);
            GbConsultarCliente.Controls.Add(BtnPesquisar);
            GbConsultarCliente.Controls.Add(MtbDocumento);
            GbConsultarCliente.Controls.Add(LbDocumento);
            GbConsultarCliente.Controls.Add(GbTipoDocumento);
            GbConsultarCliente.Controls.Add(TbNome);
            GbConsultarCliente.Controls.Add(LbNome);
            GbConsultarCliente.Dock = DockStyle.Fill;
            GbConsultarCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbConsultarCliente.Location = new Point(0, 0);
            GbConsultarCliente.Name = "GbConsultarCliente";
            GbConsultarCliente.Size = new Size(797, 450);
            GbConsultarCliente.TabIndex = 0;
            GbConsultarCliente.TabStop = false;
            GbConsultarCliente.Text = "Consulta de clientes";
            // 
            // LbClientes
            // 
            LbClientes.AutoSize = true;
            LbClientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbClientes.ForeColor = Color.Black;
            LbClientes.Location = new Point(359, 101);
            LbClientes.Name = "LbClientes";
            LbClientes.Size = new Size(71, 21);
            LbClientes.TabIndex = 27;
            LbClientes.Text = "Clientes";
            // 
            // DtgClientes
            // 
            DtgClientes.AllowUserToAddRows = false;
            DtgClientes.AllowUserToDeleteRows = false;
            DtgClientes.BackgroundColor = Color.LightSteelBlue;
            DtgClientes.BorderStyle = BorderStyle.Fixed3D;
            DtgClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DtgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgClientes.GridColor = Color.Black;
            DtgClientes.Location = new Point(14, 125);
            DtgClientes.Name = "DtgClientes";
            DtgClientes.ReadOnly = true;
            DtgClientes.RowHeadersVisible = false;
            DtgClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtgClientes.Size = new Size(771, 319);
            DtgClientes.TabIndex = 26;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.BackColor = Color.DodgerBlue;
            BtnPesquisar.FlatStyle = FlatStyle.Flat;
            BtnPesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPesquisar.ForeColor = Color.White;
            BtnPesquisar.Location = new Point(674, 47);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(111, 32);
            BtnPesquisar.TabIndex = 25;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = false;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // MtbDocumento
            // 
            MtbDocumento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MtbDocumento.Location = new Point(482, 50);
            MtbDocumento.Name = "MtbDocumento";
            MtbDocumento.Size = new Size(186, 29);
            MtbDocumento.TabIndex = 21;
            MtbDocumento.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // LbDocumento
            // 
            LbDocumento.AutoSize = true;
            LbDocumento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbDocumento.ForeColor = Color.Black;
            LbDocumento.Location = new Point(482, 26);
            LbDocumento.Name = "LbDocumento";
            LbDocumento.Size = new Size(100, 21);
            LbDocumento.TabIndex = 20;
            LbDocumento.Text = "Documento";
            // 
            // GbTipoDocumento
            // 
            GbTipoDocumento.Controls.Add(RbCPF);
            GbTipoDocumento.Controls.Add(RbCNPJ);
            GbTipoDocumento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbTipoDocumento.Location = new Point(318, 32);
            GbTipoDocumento.Name = "GbTipoDocumento";
            GbTipoDocumento.Size = new Size(158, 50);
            GbTipoDocumento.TabIndex = 18;
            GbTipoDocumento.TabStop = false;
            GbTipoDocumento.Text = "Tipo documento";
            // 
            // RbCPF
            // 
            RbCPF.AutoSize = true;
            RbCPF.Location = new Point(79, 19);
            RbCPF.Name = "RbCPF";
            RbCPF.Size = new Size(56, 25);
            RbCPF.TabIndex = 1;
            RbCPF.TabStop = true;
            RbCPF.Text = "CPF";
            RbCPF.UseVisualStyleBackColor = true;
            RbCPF.CheckedChanged += RbCPF_CheckedChanged;
            // 
            // RbCNPJ
            // 
            RbCNPJ.AutoSize = true;
            RbCNPJ.Location = new Point(6, 19);
            RbCNPJ.Name = "RbCNPJ";
            RbCNPJ.Size = new Size(67, 25);
            RbCNPJ.TabIndex = 0;
            RbCNPJ.TabStop = true;
            RbCNPJ.Text = "CNPJ";
            RbCNPJ.UseVisualStyleBackColor = true;
            RbCNPJ.CheckedChanged += RbCNPJ_CheckedChanged;
            // 
            // TbNome
            // 
            TbNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbNome.Location = new Point(12, 50);
            TbNome.Name = "TbNome";
            TbNome.Size = new Size(300, 29);
            TbNome.TabIndex = 3;
            // 
            // LbNome
            // 
            LbNome.AutoSize = true;
            LbNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbNome.ForeColor = Color.Black;
            LbNome.Location = new Point(14, 26);
            LbNome.Name = "LbNome";
            LbNome.Size = new Size(57, 21);
            LbNome.TabIndex = 2;
            LbNome.Text = "Nome";
            // 
            // FormularioConsultarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 450);
            Controls.Add(GbConsultarCliente);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormularioConsultarClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioConsultarClientes";
            Load += FormularioConsultarClientes_Load;
            GbConsultarCliente.ResumeLayout(false);
            GbConsultarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DtgClientes).EndInit();
            GbTipoDocumento.ResumeLayout(false);
            GbTipoDocumento.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GbConsultarCliente;
        private TextBox TbNome;
        private Label LbNome;
        private GroupBox GbTipoDocumento;
        private RadioButton RbCPF;
        private RadioButton RbCNPJ;
        private MaskedTextBox MtbDocumento;
        private Label LbDocumento;
        private Button BtnPesquisar;
        private Label LbClientes;
        private DataGridView DtgClientes;
    }
}