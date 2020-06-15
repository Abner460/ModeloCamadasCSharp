namespace PadraoDeProjetoEmCamadas
{
    partial class frmCadastroEmpresa
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private new System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

#pragma warning disable CS0108 // O membro oculta o membro herdado; nova palavra-chave ausente
                              /// <summary>
                              /// Método necessário para suporte ao Designer - não modifique 
                              /// o conteúdo deste método com o editor de código.
                              /// </summary>
        private void InitializeComponent()
#pragma warning restore CS0108 // O membro oculta o membro herdado; nova palavra-chave ausente
        {
            this.TXTId = new System.Windows.Forms.TextBox();
            this.LBLCodigo = new System.Windows.Forms.Label();
            this.lblNOME = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblDESCRICAO = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtEmpresa = new System.Windows.Forms.MaskedTextBox();
            this.txtDescricaoEp = new System.Windows.Forms.MaskedTextBox();
            this.painel_campos.SuspendLayout();
            this.Painel_botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_campos
            // 
            this.painel_campos.Controls.Add(this.TXTId);
            this.painel_campos.Controls.Add(this.LBLCodigo);
            this.painel_campos.Controls.Add(this.txtDescricaoEp);
            this.painel_campos.Controls.Add(this.txtCnpj);
            this.painel_campos.Controls.Add(this.txtEmpresa);
            this.painel_campos.Controls.Add(this.lblDESCRICAO);
            this.painel_campos.Controls.Add(this.lblCNPJ);
            this.painel_campos.Controls.Add(this.lblNOME);
            this.painel_campos.Size = new System.Drawing.Size(611, 132);
            // 
            // Painel_botoes
            // 
            this.Painel_botoes.Location = new System.Drawing.Point(3, 150);
            this.Painel_botoes.Size = new System.Drawing.Size(611, 53);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // TXTId
            // 
            this.TXTId.Enabled = false;
            this.TXTId.Location = new System.Drawing.Point(81, 8);
            this.TXTId.Name = "TXTId";
            this.TXTId.Size = new System.Drawing.Size(46, 20);
            this.TXTId.TabIndex = 30;
            // 
            // LBLCodigo
            // 
            this.LBLCodigo.AutoSize = true;
            this.LBLCodigo.Location = new System.Drawing.Point(13, 15);
            this.LBLCodigo.Name = "LBLCodigo";
            this.LBLCodigo.Size = new System.Drawing.Size(40, 13);
            this.LBLCodigo.TabIndex = 29;
            this.LBLCodigo.Text = "Código";
            // 
            // lblNOME
            // 
            this.lblNOME.AutoSize = true;
            this.lblNOME.Location = new System.Drawing.Point(13, 34);
            this.lblNOME.Name = "lblNOME";
            this.lblNOME.Size = new System.Drawing.Size(35, 13);
            this.lblNOME.TabIndex = 0;
            this.lblNOME.Text = "Nome";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(13, 60);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(56, 13);
            this.lblCNPJ.TabIndex = 1;
            this.lblCNPJ.Text = "Cód CNPJ";
            // 
            // lblDESCRICAO
            // 
            this.lblDESCRICAO.AutoSize = true;
            this.lblDESCRICAO.Location = new System.Drawing.Point(13, 86);
            this.lblDESCRICAO.Name = "lblDESCRICAO";
            this.lblDESCRICAO.Size = new System.Drawing.Size(58, 13);
            this.lblDESCRICAO.TabIndex = 2;
            this.lblDESCRICAO.Text = "Descrição:";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(81, 57);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(520, 20);
            this.txtCnpj.TabIndex = 4;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(81, 31);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(520, 20);
            this.txtEmpresa.TabIndex = 3;
            // 
            // txtDescricaoEp
            // 
            this.txtDescricaoEp.Location = new System.Drawing.Point(81, 83);
            this.txtDescricaoEp.MaximumSize = new System.Drawing.Size(520, 70);
            this.txtDescricaoEp.MinimumSize = new System.Drawing.Size(520, 60);
            this.txtDescricaoEp.Name = "txtDescricaoEp";
            this.txtDescricaoEp.Size = new System.Drawing.Size(520, 20);
            this.txtDescricaoEp.TabIndex = 5;
            // 
            // frmCadastroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(623, 214);
            this.Name = "frmCadastroEmpresa";
            this.Load += new System.EventHandler(this.frmCadastroEmpresa_Load);
            this.painel_campos.ResumeLayout(false);
            this.painel_campos.PerformLayout();
            this.Painel_botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TXTId;
        private System.Windows.Forms.Label LBLCodigo;
        private System.Windows.Forms.MaskedTextBox txtDescricaoEp;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.MaskedTextBox txtEmpresa;
        private System.Windows.Forms.Label lblDESCRICAO;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblNOME;
    }
}
