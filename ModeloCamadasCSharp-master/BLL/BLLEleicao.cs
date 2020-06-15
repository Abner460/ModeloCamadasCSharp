using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MODELO;
using MySql.Data.MySqlClient;

namespace BLL
{
    public class BLLEleicao
    {
        private DALEleicao DALobj;

        public BLLEleicao(DALConexao cx)
        {
            DALobj = new DALEleicao(cx);
        }

        public void Incluir(MODELOEleicao modelo)
        {
            try
            {
                if (modelo.NOME1 == "")
                {
                    throw new ArgumentNullException("Nome", "Nao pode ser vazio.");
                }

                DALobj.Incluir(modelo);
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Alterar(MODELOEleicao modelo)
        {
            try
            {
                if (modelo.NOME1 == "")
                {
                    throw new ArgumentNullException("Nome", "Nao pode ser vazio.");
                }

                DALobj.Incluir(modelo);
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(int codigo)
        {
            if (codigo <= 0)
            {
                throw new ArgumentNullException("ID", "Para deletar código, não pode estar zerado!");
            }
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(string texto)
        {
            return DALobj.Localizar(texto);
        }
    }
}
