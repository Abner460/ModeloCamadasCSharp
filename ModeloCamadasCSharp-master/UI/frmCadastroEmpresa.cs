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
    public partial class frmCadastroEmpresa : PadraoDeProjetoEmCamadas.frmModeloDeCadastro
    {
        public frmCadastroEmpresa(frmPrincipal frmPrincipal)
        {
            InitializeComponent();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            alterapropriedades(2);
        }

        public void limparCampos()
        {
            TXTId.Clear();
            txtEmpresa.Clear();
            txtCnpj.Clear();
            txtDescricaoEp.Clear();
        }

        private void popularcampos(MODELOEmpresa p)
        {
            if (p != null)
            {
                TXTId.Text = p.IDEMPRESA1.ToString();
                txtEmpresa.Text = p.NOME1;
                txtCnpj.Text = p.CODEMPRESA1;
                txtDescricaoEp.Text = p.DESCRICAO1;
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            FRMLocalizarEmpresa f = new FRMLocalizarEmpresa();
            f.ShowDialog();

            popularcampos(f.modeloempresa);

            alterapropriedades(3);
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLEmpresa bllempresa = new BLLEmpresa(cx);

                MODELOEmpresa p = new MODELOEmpresa();
                p.IDEMPRESA1 = Convert.ToInt32(TXTId.Text);
                p.NOME1 = txtEmpresa.Text;
                p.CODEMPRESA1 = txtCnpj.Text;
                p.DESCRICAO1 = txtDescricaoEp.Text;

                bllempresa.Alterar(p);
                MessageBox.Show("Empresa alterada com sucesso.");

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
                BLLEmpresa bllempresa = new BLLEmpresa(cx);
                bllempresa.Excluir(Convert.ToInt32(TXTId.Text));
                MessageBox.Show("Empresa excluida com sucesso.");

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

                BLLEmpresa bllpessoa = new BLLEmpresa(cx);

                MODELOEmpresa p = new MODELOEmpresa();
                p.NOME1 = txtEmpresa.Text;
                p.CODEMPRESA1 = txtCnpj.Text;
                p.DESCRICAO1 = txtDescricaoEp.Text;

                bllpessoa.Incluir(p);
                TXTId.Text = p.IDEMPRESA1.ToString(); ;
                MessageBox.Show("Empresa cadastrada com sucesso id:" + p.IDEMPRESA1);

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

        private void frmCadastroEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
