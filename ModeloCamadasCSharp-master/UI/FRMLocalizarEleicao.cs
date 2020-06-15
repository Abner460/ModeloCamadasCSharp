using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using MODELO;

namespace PadraoDeProjetoEmCamadas
{
    public partial class FRMLocalizarEleicao : Form
    {
        public MODELOEleicao modeloele;
        public FRMLocalizarEleicao()
        {
            InitializeComponent();
        }
        protected void DGVeleicao_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.modeloele = new MODELOEleicao();

            this.modeloele.IDELEICAO1 = Convert.ToInt32(DGVeleicao.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.modeloele.IDEMPRESA1 = Convert.ToInt32(DGVeleicao.Rows[e.RowIndex].Cells[1].Value.ToString());
            this.modeloele.NOME1 = DGVeleicao.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.modeloele.DESCRICAO1 = DGVeleicao.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.modeloele.TIPOVOTO1 = Convert.ToInt32(DGVeleicao.Rows[e.RowIndex].Cells[4].Value.ToString());
            this.modeloele.MENSAGEMENCERRADO1 = DGVeleicao.Rows[e.RowIndex].Cells[5].Value.ToString();
            this.modeloele.MENSAGEMFIM1 = DGVeleicao.Rows[e.RowIndex].Cells[6].Value.ToString();

            DateTime data = Convert.ToDateTime(DGVeleicao.Rows[e.RowIndex].Cells[7].Value.ToString());
            this.modeloele.DATAINICIO1 = data;

            DateTime dataf = Convert.ToDateTime(DGVeleicao.Rows[e.RowIndex].Cells[8].Value.ToString());
            this.modeloele.DATAFIM1 = dataf;

            this.Close();
        }

        protected void LBLBusca_Click(object sender, EventArgs e)
        {

        }

        protected void TXTBusca_TextChanged(object sender, EventArgs e)
        {

        }

        protected void BTNBuscar_Click(object sender, EventArgs e)
        {
            DadosDaConexao dc = new DadosDaConexao();
            DALConexao cx = new DALConexao(dc.StringDeConexao);

            BLLEleicao bllele = new BLLEleicao(cx);
            DataTable tabela = bllele.Localizar(TXTBusca.Text);
            DGVeleicao.DataSource = tabela;
        }

        protected void DGVeleicao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        protected void FRMLocalizarEleicao_Load(object sender, EventArgs e)
        {

        }
    }
}
