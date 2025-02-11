namespace Gen_Sim.View
{
    partial class FormularioCadastrarClientes
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
            LbNome = new Label();
            TbNome = new TextBox();
            LbCep = new Label();
            MtbCep = new MaskedTextBox();
            LbLogradouro = new Label();
            TbLogradouro = new TextBox();
            LbNumero = new Label();
            NudNumero = new NumericUpDown();
            LbBairro = new Label();
            TbBairro = new TextBox();
            LbEstado = new Label();
            CbEstado = new ComboBox();
            GbCadastrarClientes = new GroupBox();
            MtbDocumento = new MaskedTextBox();
            LbDocumento = new Label();
            GbTipoDocumento = new GroupBox();
            RbCPF = new RadioButton();
            RbCNPJ = new RadioButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)NudNumero).BeginInit();
            GbCadastrarClientes.SuspendLayout();
            GbTipoDocumento.SuspendLayout();
            SuspendLayout();
            // 
            // LbNome
            // 
            LbNome.AutoSize = true;
            LbNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbNome.ForeColor = Color.Red;
            LbNome.Location = new Point(6, 25);
            LbNome.Name = "LbNome";
            LbNome.Size = new Size(57, 21);
            LbNome.TabIndex = 0;
            LbNome.Text = "Nome";
            // 
            // TbNome
            // 
            TbNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbNome.Location = new Point(6, 49);
            TbNome.Name = "TbNome";
            TbNome.Size = new Size(826, 29);
            TbNome.TabIndex = 1;
            // 
            // LbCep
            // 
            LbCep.AutoSize = true;
            LbCep.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbCep.ForeColor = Color.Black;
            LbCep.Location = new Point(6, 85);
            LbCep.Name = "LbCep";
            LbCep.Size = new Size(39, 21);
            LbCep.TabIndex = 2;
            LbCep.Text = "Cep";
            // 
            // MtbCep
            // 
            MtbCep.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MtbCep.Location = new Point(6, 109);
            MtbCep.Mask = "00000-000";
            MtbCep.Name = "MtbCep";
            MtbCep.Size = new Size(107, 29);
            MtbCep.TabIndex = 3;
            MtbCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // LbLogradouro
            // 
            LbLogradouro.AutoSize = true;
            LbLogradouro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbLogradouro.ForeColor = Color.Red;
            LbLogradouro.Location = new Point(115, 85);
            LbLogradouro.Name = "LbLogradouro";
            LbLogradouro.Size = new Size(99, 21);
            LbLogradouro.TabIndex = 4;
            LbLogradouro.Text = "Logradouro";
            // 
            // TbLogradouro
            // 
            TbLogradouro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbLogradouro.Location = new Point(115, 109);
            TbLogradouro.Name = "TbLogradouro";
            TbLogradouro.Size = new Size(376, 29);
            TbLogradouro.TabIndex = 5;
            // 
            // LbNumero
            // 
            LbNumero.AutoSize = true;
            LbNumero.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbNumero.ForeColor = Color.Black;
            LbNumero.Location = new Point(497, 85);
            LbNumero.Name = "LbNumero";
            LbNumero.Size = new Size(73, 21);
            LbNumero.TabIndex = 6;
            LbNumero.Text = "Número";
            // 
            // NudNumero
            // 
            NudNumero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NudNumero.Location = new Point(497, 110);
            NudNumero.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            NudNumero.Name = "NudNumero";
            NudNumero.Size = new Size(120, 29);
            NudNumero.TabIndex = 11;
            // 
            // LbBairro
            // 
            LbBairro.AutoSize = true;
            LbBairro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbBairro.ForeColor = Color.Red;
            LbBairro.Location = new Point(623, 85);
            LbBairro.Name = "LbBairro";
            LbBairro.Size = new Size(56, 21);
            LbBairro.TabIndex = 12;
            LbBairro.Text = "Bairro";
            // 
            // TbBairro
            // 
            TbBairro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbBairro.Location = new Point(623, 110);
            TbBairro.Name = "TbBairro";
            TbBairro.Size = new Size(209, 29);
            TbBairro.TabIndex = 13;
            // 
            // LbEstado
            // 
            LbEstado.AutoSize = true;
            LbEstado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbEstado.ForeColor = Color.Red;
            LbEstado.Location = new Point(7, 141);
            LbEstado.Name = "LbEstado";
            LbEstado.Size = new Size(61, 21);
            LbEstado.TabIndex = 14;
            LbEstado.Text = "Estado";
            // 
            // CbEstado
            // 
            CbEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CbEstado.FormattingEnabled = true;
            CbEstado.Items.AddRange(new object[] { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins" });
            CbEstado.Location = new Point(7, 165);
            CbEstado.Name = "CbEstado";
            CbEstado.Size = new Size(254, 29);
            CbEstado.TabIndex = 15;
            // 
            // GbCadastrarClientes
            // 
            GbCadastrarClientes.Controls.Add(label1);
            GbCadastrarClientes.Controls.Add(MtbDocumento);
            GbCadastrarClientes.Controls.Add(LbDocumento);
            GbCadastrarClientes.Controls.Add(GbTipoDocumento);
            GbCadastrarClientes.Controls.Add(CbEstado);
            GbCadastrarClientes.Controls.Add(LbEstado);
            GbCadastrarClientes.Controls.Add(TbBairro);
            GbCadastrarClientes.Controls.Add(LbBairro);
            GbCadastrarClientes.Controls.Add(NudNumero);
            GbCadastrarClientes.Controls.Add(LbNumero);
            GbCadastrarClientes.Controls.Add(TbLogradouro);
            GbCadastrarClientes.Controls.Add(LbLogradouro);
            GbCadastrarClientes.Controls.Add(MtbCep);
            GbCadastrarClientes.Controls.Add(LbCep);
            GbCadastrarClientes.Controls.Add(TbNome);
            GbCadastrarClientes.Controls.Add(LbNome);
            GbCadastrarClientes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbCadastrarClientes.Location = new Point(12, 12);
            GbCadastrarClientes.Name = "GbCadastrarClientes";
            GbCadastrarClientes.Size = new Size(838, 489);
            GbCadastrarClientes.TabIndex = 0;
            GbCadastrarClientes.TabStop = false;
            GbCadastrarClientes.Text = "Cadastro de cliente";
            // 
            // MtbDocumento
            // 
            MtbDocumento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MtbDocumento.Location = new Point(431, 165);
            MtbDocumento.Name = "MtbDocumento";
            MtbDocumento.Size = new Size(157, 29);
            MtbDocumento.TabIndex = 19;
            MtbDocumento.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // LbDocumento
            // 
            LbDocumento.AutoSize = true;
            LbDocumento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbDocumento.ForeColor = Color.Red;
            LbDocumento.Location = new Point(431, 141);
            LbDocumento.Name = "LbDocumento";
            LbDocumento.Size = new Size(100, 21);
            LbDocumento.TabIndex = 18;
            LbDocumento.Text = "Documento";
            // 
            // GbTipoDocumento
            // 
            GbTipoDocumento.Controls.Add(RbCPF);
            GbTipoDocumento.Controls.Add(RbCNPJ);
            GbTipoDocumento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbTipoDocumento.Location = new Point(267, 146);
            GbTipoDocumento.Name = "GbTipoDocumento";
            GbTipoDocumento.Size = new Size(158, 50);
            GbTipoDocumento.TabIndex = 17;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(594, 141);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 20;
            // 
            // FormularioCadastrarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 513);
            Controls.Add(GbCadastrarClientes);
            Name = "FormularioCadastrarClientes";
            Text = "Cadastro de cliente";
            Load += FormularioCadastrarClientes_Load;
            ((System.ComponentModel.ISupportInitialize)NudNumero).EndInit();
            GbCadastrarClientes.ResumeLayout(false);
            GbCadastrarClientes.PerformLayout();
            GbTipoDocumento.ResumeLayout(false);
            GbTipoDocumento.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox TbCidade;
        private Label LbCidade;
        private Label LbNome;
        private TextBox TbNome;
        private Label LbCep;
        private MaskedTextBox MtbCep;
        private Label LbLogradouro;
        private TextBox TbLogradouro;
        private Label LbNumero;
        private NumericUpDown NudNumero;
        private Label LbBairro;
        private TextBox TbBairro;
        private Label LbEstado;
        private ComboBox CbEstado;
        private GroupBox GbCadastrarClientes;
        private GroupBox GbTipoDocumento;
        private MaskedTextBox MtbDocumento;
        private Label LbDocumento;
        private RadioButton RbCPF;
        private RadioButton RbCNPJ;
        private Label label1;
    }
}