using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using DAL;
using MODELO;
using MySql.Data.MySqlClient;

namespace PadraoDeProjetoEmCamadas
{
    public partial class frmCadastroEleicao : PadraoDeProjetoEmCamadas.frmModeloDeCadastro
    {
        public frmCadastroEleicao(frmPrincipal frmPrincipal)
        {
            InitializeComponent();
        }

        private void popularcampos(MODELOEleicao p)
        {
            if (p != null)
            {
                txtEmpresap.Text = p.IDEMPRESA1.ToString();
                txtvoto.Text = p.TIPOVOTO1.ToString();
                txtNomep.Text = p.NOME1;
                txtDescricaop.Text = p.DESCRICAO1;
                txtEncerradop.Text = p.MENSAGEMENCERRADO1;
                txtFimp.Text = p.MENSAGEMFIM1;
                dateTimePick1.Text = Convert.ToString(p.DATAINICIO1);
                dateTimePick2.Text = Convert.ToString(p.DATAFIM1);
                TXTId.Text = p.IDELEICAO1.ToString();
            }
        }
        public void limparCampos()
        {
            txtEmpresap.Clear();
            txtNomep.Clear();
            txtDescricaop.Clear();
            txtvoto.Clear();
            TXTId.Clear();
            txtEncerradop.Clear();
            txtFimp.Clear();
            dateTimePick1.Text = "";
            dateTimePick2.Text = "";
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            alterapropriedades(2);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            FRMLocalizarEleicao f = new FRMLocalizarEleicao();
            f.ShowDialog();

            popularcampos(f.modeloele);

            alterapropriedades(3);
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLEleicao blleleicao = new BLLEleicao(cx);

                MODELOEleicao p = new MODELOEleicao();
                p.IDEMPRESA1 = Convert.ToInt32(txtEmpresap.Text);
                p.NOME1 = txtNomep.Text;
                p.DESCRICAO1 = txtDescricaop.Text;
                p.TIPOVOTO1 = Convert.ToInt32(txtvoto.Text);
                p.MENSAGEMENCERRADO1 = txtEncerradop.Text;
                p.MENSAGEMFIM1 = txtFimp.Text;

                p.DATAINICIO1 = new DateTime(dateTimePick1.Value.Year,
                   dateTimePick1.Value.Month,
                   dateTimePick1.Value.Day);

                p.DATAFIM1 = new DateTime(dateTimePick2.Value.Year,
                   dateTimePick2.Value.Month,
                   dateTimePick2.Value.Day);

                p.IDELEICAO1= Convert.ToInt32(TXTId.Text);

                blleleicao.Alterar(p);
                MessageBox.Show("Eleição alterada com sucesso.");

                limparCampos();
                alterapropriedades(1);
            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Registro já existe no banco de dados");
                }
                else
                {
                    MessageBox.Show("Falha ao alterar errro:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao alterar errro geral:" + ex.Message);
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);
                BLLEleicao bllele = new BLLEleicao(cx);
                bllele.Excluir(Convert.ToInt32(TXTId.Text));
                MessageBox.Show("Eleição excluida com sucesso.");

                limparCampos();
                alterapropriedades(1);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Falha ao excluir erro:" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir erro geral:" + ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            alterapropriedades(1);
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLEleicao bllele = new BLLEleicao(cx);

                MODELOEleicao p = new MODELOEleicao();
                p.IDEMPRESA1 = Convert.ToInt32(txtEmpresap.Text);
                p.NOME1 = txtNomep.Text;
                p.DESCRICAO1 = txtDescricaop.Text;
                p.TIPOVOTO1 = Convert.ToInt32(txtvoto.Text);
                p.MENSAGEMENCERRADO1 = txtEncerradop.Text;
                p.MENSAGEMFIM1 = txtFimp.Text;

                p.DATAINICIO1 = new DateTime(dateTimePick1.Value.Year,
                   dateTimePick1.Value.Month,
                   dateTimePick1.Value.Day);

                p.DATAFIM1 = new DateTime(dateTimePick2.Value.Year,
                   dateTimePick2.Value.Month,
                   dateTimePick2.Value.Day);

                p.IDELEICAO1 = Convert.ToInt32(TXTId.Text);

                bllele.Incluir(p);
                TXTId.Text = p.IDELEICAO1.ToString(); ;
                MessageBox.Show("Eleição registrada com sucesso id:" + p.IDELEICAO1);

                limparCampos();
                alterapropriedades(1);
            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Registro j'a existe no banco de dados");
                }
                else
                {
                    MessageBox.Show("Falha ao inserir errro:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao inserir errro geral:" + ex.Message);
            }
        }

        private void frmCadastroEleicao_Load(object sender, EventArgs e)
        {

        }
    }
}
