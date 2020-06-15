namespace PadraoDeProjetoEmCamadas
{
    partial class FRMLocalizarEleicao
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
            this.LBLBusca = new System.Windows.Forms.Label();
            this.TXTBusca = new System.Windows.Forms.TextBox();
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.DGVeleicao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVeleicao)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLBusca
            // 
            this.LBLBusca.AutoSize = true;
            this.LBLBusca.Location = new System.Drawing.Point(12, 26);
            this.LBLBusca.Name = "LBLBusca";
            this.LBLBusca.Size = new System.Drawing.Size(96, 13);
            this.LBLBusca.TabIndex = 1;
            this.LBLBusca.Text = "Localizar por nome";
            this.LBLBusca.Click += new System.EventHandler(this.LBLBusca_Click);
            // 
            // TXTBusca
            // 
            this.TXTBusca.Location = new System.Drawing.Point(15, 42);
            this.TXTBusca.Name = "TXTBusca";
            this.TXTBusca.Size = new System.Drawing.Size(332, 20);
            this.TXTBusca.TabIndex = 2;
            this.TXTBusca.TextChanged += new System.EventHandler(this.TXTBusca_TextChanged);
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.Location = new System.Drawing.Point(353, 40);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(75, 23);
            this.BTNBuscar.TabIndex = 3;
            this.BTNBuscar.Text = "Buscar";
            this.BTNBuscar.UseVisualStyleBackColor = true;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click);
            // 
            // DGVeleicao
            // 
            this.DGVeleicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVeleicao.Location = new System.Drawing.Point(15, 69);
            this.DGVeleicao.Name = "DGVeleicao";
            this.DGVeleicao.Size = new System.Drawing.Size(413, 141);
            this.DGVeleicao.TabIndex = 4;
            this.DGVeleicao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVeleicao_CellContentClick);
            this.DGVeleicao.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVeleicao_CellContentDoubleClick);
            // 
            // FRMLocalizarEleicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 223);
            this.Controls.Add(this.DGVeleicao);
            this.Controls.Add(this.BTNBuscar);
            this.Controls.Add(this.TXTBusca);
            this.Controls.Add(this.LBLBusca);
            this.Name = "FRMLocalizarEleicao";
            this.Text = "FRMLocalizarEleicao";
            this.Load += new System.EventHandler(this.FRMLocalizarEleicao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVeleicao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label LBLBusca;
        protected System.Windows.Forms.TextBox TXTBusca;
        protected System.Windows.Forms.Button BTNBuscar;
        private System.Windows.Forms.DataGridView DGVeleicao;
    }
}