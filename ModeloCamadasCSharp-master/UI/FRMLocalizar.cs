﻿using BLL;
using DAL;
using MODELO;
using System;
using System.Data;
using System.Windows.Forms;

namespace PadraoDeProjetoEmCamadas
{
    public partial class FRMLocalizar : Form
    {
        public MODELOPessoa modelpessoa;

        public FRMLocalizar()
        {
            InitializeComponent();
        }

        protected void BTNBuscar_Click(object sender, EventArgs e)
        {
            DadosDaConexao dc = new DadosDaConexao();
            DALConexao cx = new DALConexao(dc.StringDeConexao);

            BLLPessoa bllpessoa = new BLLPessoa(cx);
            DataTable tabela = bllpessoa.Localizar(TXTBusca.Text);
            DGVDados.DataSource = tabela;
        }

        protected void DGVDados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.modelpessoa = new MODELOPessoa();

            this.modelpessoa.Id    = Convert.ToInt32(DGVDados.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.modelpessoa.Nome  = DGVDados.Rows[e.RowIndex].Cells[1].Value.ToString();
           
            DateTime data = Convert.ToDateTime(DGVDados.Rows[e.RowIndex].Cells[2].Value.ToString());

            this.modelpessoa.DataNascimento = data;
            this.modelpessoa.Sexo  = DGVDados.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.modelpessoa.Email = DGVDados.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.modelpessoa.Cpf   = DGVDados.Rows[e.RowIndex].Cells[5].Value.ToString();

            this.modelpessoa.Foto = null;
            if (DGVDados.Rows[e.RowIndex].Cells[6].Value != DBNull.Value)
            {
                this.modelpessoa.Foto = (byte[])DGVDados.Rows[e.RowIndex].Cells[6].Value;
            }

            this.Close();
        }

        protected void FRMLocalizar_Load(object sender, EventArgs e)
        {

        }

        protected void DGVDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        protected void TXTBusca_TextChanged(object sender, EventArgs e)
        {

        }

        protected void LBLBusca_Click(object sender, EventArgs e)
        {

        }
    }
}
