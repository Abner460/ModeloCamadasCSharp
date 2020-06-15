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
    public class DALEmpresa
    {
        private DALConexao conexao;

        public DALEmpresa(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(MODELOEmpresa modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO Empresa (IDEMPRESA, NOME, DESCRICAO, CODEMPRESA)" +
                    "VALUES (NULL, @nome, @descricao, @cod);" +
                    "SELECT MAX(IDEMPRESA) FROM Empresa;";
                cmd.Parameters.AddWithValue("@nome", modelo.NOME1);
                cmd.Parameters.AddWithValue("@descricao", modelo.DESCRICAO1);
                cmd.Parameters.AddWithValue("@cod", modelo.CODEMPRESA1);
                
                conexao.Conectar();
                int idInserido = Convert.ToInt32(cmd.ExecuteScalar());
                modelo.IDEMPRESA1 = idInserido;
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

        public void Alterar(MODELOEmpresa modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE Empresa SET  NOME = @nome," + " DESCRICAO = @descricao," + " CODEMPRESA = @cod" + " WHERE " + " IDEMPRESA = @id";
                cmd.Parameters.AddWithValue("@nome", modelo.NOME1);
                cmd.Parameters.AddWithValue("@descricao", modelo.DESCRICAO1);
                cmd.Parameters.AddWithValue("@cod", modelo.CODEMPRESA1);
                cmd.Parameters.AddWithValue("@id", modelo.IDEMPRESA1);

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

                cmd.CommandText = "DELETE FROM Empresa WHERE IDEMPRESA = @id";
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
            string SQL = "SELECT * FROM Empresa WHERE NOME LIKE '%" + texto + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(SQL, this.conexao.ObjetoConexao);
            adapter.Fill(tabela);

            return tabela;
        }
    }
}
