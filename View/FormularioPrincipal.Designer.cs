namespace Gen_Sim.View
{
    partial class FormularioPrincipal
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
            MstMenuPrincipal = new MenuStrip();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            atualizarToolStripMenuItem = new ToolStripMenuItem();
            MstMenuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // MstMenuPrincipal
            // 
            MstMenuPrincipal.Items.AddRange(new ToolStripItem[] { clientesToolStripMenuItem });
            MstMenuPrincipal.Location = new Point(0, 0);
            MstMenuPrincipal.Name = "MstMenuPrincipal";
            MstMenuPrincipal.Size = new Size(800, 24);
            MstMenuPrincipal.TabIndex = 0;
            MstMenuPrincipal.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, consultaToolStripMenuItem, atualizarToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(61, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(125, 22);
            cadastroToolStripMenuItem.Text = "Cadastrar";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            consultaToolStripMenuItem.Size = new Size(125, 22);
            consultaToolStripMenuItem.Text = "Consultar";
            consultaToolStripMenuItem.Click += consultaToolStripMenuItem_Click;
            // 
            // atualizarToolStripMenuItem
            // 
            atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            atualizarToolStripMenuItem.Size = new Size(125, 22);
            atualizarToolStripMenuItem.Text = "Atualizar";
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MstMenuPrincipal);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = MstMenuPrincipal;
            MaximizeBox = false;
            Name = "FormularioPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioPrincipal";
            MstMenuPrincipal.ResumeLayout(false);
            MstMenuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MstMenuPrincipal;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem atualizarToolStripMenuItem;
    }
}