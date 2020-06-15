using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DALEleicao
    {
        private DALConexao conexao;

        public DALEleicao(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(MODELOEleicao modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO Eleicao (IDELEICAO, IDEMPRESA, NOME, DESCRICAO, TIPOVOTO, MENSAGEMENCERRADO, MENSAGEMFIM, DATAINICIO, DATAFIM)" +
                    "VALUES (NULL, @id, @nome, @dsc, @voto, @msgenc, @msgfim, @dtinicio, @dtfinal);" +
                    "SELECT MAX(IDELEICAO) FROM Eleicao;";
                cmd.Parameters.AddWithValue("@id", modelo.IDEMPRESA1);
                cmd.Parameters.AddWithValue("@nome", modelo.NOME1);
                cmd.Parameters.AddWithValue("@dsc", modelo.DESCRICAO1);
                cmd.Parameters.AddWithValue("@voto", modelo.TIPOVOTO1);
                cmd.Parameters.AddWithValue("@msgenc", modelo.MENSAGEMENCERRADO1);
                cmd.Parameters.AddWithValue("@msgfim", modelo.MENSAGEMFIM1);
                cmd.Parameters.AddWithValue("@dtinicio", modelo.DATAINICIO1.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@dtfinal", modelo.DATAFIM1.ToString("yyyy-MM-dd HH:mm:ss"));

                conexao.Conectar();
                int idInserido = Convert.ToInt32(cmd.ExecuteScalar());
                modelo.IDELEICAO1 = idInserido;
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.conexao.Desconectar();
            }

        }

        public void Alterar(MODELOEleicao modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE Eleicao SET IDEMPRESA = @id," +
                                  " NOME = @nome," +
                                  " DESCRICAO = @dsc," +
                                  " TIPOVOTO = @voto," +
                                  " MENSAGEMENCERRADO = @msgenc," +
                                  " MENSAGEMFIM = @msgfim," +
                                  " DATAINICIO = @dtinicio," +
                                  " DATAFIM = @dtfinal" +
                                  " WHERE " +
                                  " IDELEICAO = @ide";
                string datainicio = modelo.DATAINICIO1.ToString("yyyy-MM-dd HH:mm:ss");
                string datafim = modelo.DATAFIM1.ToString("yyyy-MM-dd HH:mm:ss");
                cmd.Parameters.AddWithValue("@ide", modelo.IDELEICAO1);
                cmd.Parameters.AddWithValue("@id", modelo.IDEMPRESA1);
                cmd.Parameters.AddWithValue("@nome", modelo.NOME1);
                cmd.Parameters.AddWithValue("@dsc", modelo.DESCRICAO1);
                cmd.Parameters.AddWithValue("@voto", modelo.TIPOVOTO1);
                cmd.Parameters.AddWithValue("@msgenc", modelo.MENSAGEMENCERRADO1);
                cmd.Parameters.AddWithValue("@msgfim", modelo.MENSAGEMFIM1);
                cmd.Parameters.AddWithValue("@dtinicio", datainicio);
                cmd.Parameters.AddWithValue("@dtfinal", datafim);

                this.conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.conexao.Desconectar();
            }
        }

        public void Excluir(int codigo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;

                cmd.CommandText = "DELETE FROM Eleicao WHERE IDELEICAO = @id";
                cmd.Parameters.AddWithValue("@id", codigo);
                this.conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.conexao.Desconectar();
            }
        }

        public DataTable Localizar(string texto)
        {
            DataTable tabela = new DataTable();
            string SQL = "SELECT e.IDELEICAO, p.IDEMPRESA, e.NOME, e.DESCRICAO, e.TIPOVOTO AS 'Voto secreto?', e.MENSAGEMENCERRADO, e.MENSAGEMFIM, e.DATAINICIO, e.DATAFIM FROM Empresa p INNER JOIN Eleicao e ON p.IDEMPRESA = e.IDEMPRESA WHERE e.NOME LIKE '%" + texto + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(SQL, this.conexao.ObjetoConexao);
            adapter.Fill(tabela);

            return tabela;
        }
    }
}
