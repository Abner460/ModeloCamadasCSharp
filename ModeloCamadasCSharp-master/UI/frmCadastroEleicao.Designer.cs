namespace PadraoDeProjetoEmCamadas
{
    partial class frmCadastroEleicao
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
        protected void InitializeComponent()
#pragma warning restore CS0108 // O membro oculta o membro herdado; nova palavra-chave ausente
        {
            this.LBLCodigo = new System.Windows.Forms.Label();
            this.TXTId = new System.Windows.Forms.TextBox();
            this.txtEmpresap = new System.Windows.Forms.MaskedTextBox();
            this.txtDescricaop = new System.Windows.Forms.MaskedTextBox();
            this.txtEncerradop = new System.Windows.Forms.MaskedTextBox();
            this.txtFimp = new System.Windows.Forms.MaskedTextBox();
            this.txtNomep = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDESCRICAO = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblNOME = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePick1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePick2 = new System.Windows.Forms.DateTimePicker();
            this.txtvoto = new System.Windows.Forms.MaskedTextBox();
            this.painel_campos.SuspendLayout();
            this.Painel_botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_campos
            // 
            this.painel_campos.Controls.Add(this.txtvoto);
            this.painel_campos.Controls.Add(this.label5);
            this.painel_campos.Controls.Add(this.dateTimePick2);
            this.painel_campos.Controls.Add(this.label4);
            this.painel_campos.Controls.Add(this.dateTimePick1);
            this.painel_campos.Controls.Add(this.label3);
            this.painel_campos.Controls.Add(this.label2);
            this.painel_campos.Controls.Add(this.label1);
            this.painel_campos.Controls.Add(this.lblDESCRICAO);
            this.painel_campos.Controls.Add(this.lblCNPJ);
            this.painel_campos.Controls.Add(this.lblNOME);
            this.painel_campos.Controls.Add(this.txtNomep);
            this.painel_campos.Controls.Add(this.txtFimp);
            this.painel_campos.Controls.Add(this.txtEncerradop);
            this.painel_campos.Controls.Add(this.txtDescricaop);
            this.painel_campos.Controls.Add(this.txtEmpresap);
            this.painel_campos.Controls.Add(this.TXTId);
            this.painel_campos.Controls.Add(this.LBLCodigo);
            this.painel_campos.Size = new System.Drawing.Size(608, 248);
            // 
            // Painel_botoes
            // 
            this.Painel_botoes.Location = new System.Drawing.Point(3, 266);
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
            // LBLCodigo
            // 
            this.LBLCodigo.AutoSize = true;
            this.LBLCodigo.Location = new System.Drawing.Point(35, 11);
            this.LBLCodigo.Name = "LBLCodigo";
            this.LBLCodigo.Size = new System.Drawing.Size(40, 13);
            this.LBLCodigo.TabIndex = 38;
            this.LBLCodigo.Text = "Código";
            // 
            // TXTId
            // 
            this.TXTId.Enabled = false;
            this.TXTId.Location = new System.Drawing.Point(81, 8);
            this.TXTId.Name = "TXTId";
            this.TXTId.Size = new System.Drawing.Size(46, 20);
            this.TXTId.TabIndex = 39;
            // 
            // txtEmpresap
            // 
            this.txtEmpresap.Location = new System.Drawing.Point(91, 35);
            this.txtEmpresap.Name = "txtEmpresap";
            this.txtEmpresap.Size = new System.Drawing.Size(497, 20);
            this.txtEmpresap.TabIndex = 40;
            // 
            // txtDescricaop
            // 
            this.txtDescricaop.Location = new System.Drawing.Point(91, 87);
            this.txtDescricaop.Name = "txtDescricaop";
            this.txtDescricaop.Size = new System.Drawing.Size(497, 20);
            this.txtDescricaop.TabIndex = 42;
            // 
            // txtEncerradop
            // 
            this.txtEncerradop.Location = new System.Drawing.Point(91, 139);
            this.txtEncerradop.Name = "txtEncerradop";
            this.txtEncerradop.Size = new System.Drawing.Size(497, 20);
            this.txtEncerradop.TabIndex = 44;
            // 
            // txtFimp
            // 
            this.txtFimp.Location = new System.Drawing.Point(91, 163);
            this.txtFimp.Name = "txtFimp";
            this.txtFimp.Size = new System.Drawing.Size(497, 20);
            this.txtFimp.TabIndex = 45;
            // 
            // txtNomep
            // 
            this.txtNomep.Location = new System.Drawing.Point(91, 61);
            this.txtNomep.Name = "txtNomep";
            this.txtNomep.Size = new System.Drawing.Size(497, 20);
            this.txtNomep.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "MSG FIM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "MSG Encerrado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Voto Secreto = 1, Não = 0";
            // 
            // lblDESCRICAO
            // 
            this.lblDESCRICAO.AutoSize = true;
            this.lblDESCRICAO.Location = new System.Drawing.Point(6, 94);
            this.lblDESCRICAO.Name = "lblDESCRICAO";
            this.lblDESCRICAO.Size = new System.Drawing.Size(58, 13);
            this.lblDESCRICAO.TabIndex = 49;
            this.lblDESCRICAO.Text = "Descrição:";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(6, 68);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(35, 13);
            this.lblCNPJ.TabIndex = 48;
            this.lblCNPJ.Text = "Nome";
            // 
            // lblNOME
            // 
            this.lblNOME.AutoSize = true;
            this.lblNOME.Location = new System.Drawing.Point(6, 42);
            this.lblNOME.Name = "lblNOME";
            this.lblNOME.Size = new System.Drawing.Size(60, 13);
            this.lblNOME.TabIndex = 47;
            this.lblNOME.Text = "Id Empresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Data início";
            // 
            // dateTimePick1
            // 
            this.dateTimePick1.Location = new System.Drawing.Point(91, 212);
            this.dateTimePick1.Name = "dateTimePick1";
            this.dateTimePick1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePick1.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Data fim";
            // 
            // dateTimePick2
            // 
            this.dateTimePick2.Location = new System.Drawing.Point(388, 212);
            this.dateTimePick2.Name = "dateTimePick2";
            this.dateTimePick2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePick2.TabIndex = 55;
            // 
            // txtvoto
            // 
            this.txtvoto.Location = new System.Drawing.Point(143, 113);
            this.txtvoto.Name = "txtvoto";
            this.txtvoto.Size = new System.Drawing.Size(30, 20);
            this.txtvoto.TabIndex = 57;
            // 
            // frmCadastroEleicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(623, 332);
            this.Name = "frmCadastroEleicao";
            this.Load += new System.EventHandler(this.frmCadastroEleicao_Load);
            this.painel_campos.ResumeLayout(false);
            this.painel_campos.PerformLayout();
            this.Painel_botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label LBLCodigo;
        protected System.Windows.Forms.TextBox TXTId;
        protected System.Windows.Forms.MaskedTextBox txtEmpresap;
        protected System.Windows.Forms.MaskedTextBox txtDescricaop;
        protected System.Windows.Forms.MaskedTextBox txtEncerradop;
        protected System.Windows.Forms.MaskedTextBox txtNomep;
        protected System.Windows.Forms.MaskedTextBox txtFimp;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label lblDESCRICAO;
        protected System.Windows.Forms.Label lblCNPJ;
        protected System.Windows.Forms.Label lblNOME;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.DateTimePicker dateTimePick1;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.DateTimePicker dateTimePick2;
        protected System.Windows.Forms.MaskedTextBox txtvoto;
    }
}
