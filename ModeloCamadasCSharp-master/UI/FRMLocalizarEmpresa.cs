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
    public partial class FRMLocalizarEmpresa : Form
    {
        public MODELOEmpresa modeloempresa;
        public FRMLocalizarEmpresa()
        {
            InitializeComponent();
        }

        //protected void dataGridView1_CellContentDoubleClic(object sender, DataGridViewCellEventArgs e)
        protected void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.modeloempresa = new MODELOEmpresa();

            this.modeloempresa.IDEMPRESA1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.modeloempresa.NOME1 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.modeloempresa.CODEMPRESA1 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.modeloempresa.DESCRICAO1 = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            this.Close();
        }

        protected void FRMLocalizarEmpresa_Load(object sender, EventArgs e)
        {

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

            BLLEmpresa bllpessoa = new BLLEmpresa(cx);
            DataTable tabela = bllpessoa.Localizar(TXTBusca.Text);
            dataGridView1.DataSource = tabela;
        }

        protected void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FRMLocalizarEmpresa_Load_1(object sender, EventArgs e)
        {

        }
    }
}
