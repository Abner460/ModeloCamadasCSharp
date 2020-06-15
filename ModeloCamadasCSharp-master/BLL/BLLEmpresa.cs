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
    public class BLLEmpresa
    {
        private DALEmpresa DALobj;

        public BLLEmpresa(DALConexao cx)
        {
            DALobj = new DALEmpresa(cx);
        }

        public void Incluir(MODELOEmpresa modelo)
        {
            try
            { 
                if (modelo.NOME1 == "")
                {
                    throw new ArgumentNullException("Nome", "Nao pode ser vazio.");
                }
                if (modelo.CODEMPRESA1 == "")
                {
                    throw new ArgumentNullException("CODEMPRESA", " O código não pode ser nulo");
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

        public void Alterar(MODELOEmpresa modelo)
        {
            try
            {
                if (modelo.NOME1 == "")
                {
                    throw new ArgumentNullException("Nome", "Nao pode ser vazio.");
                }
                if (modelo.CODEMPRESA1 == "")
                {
                    throw new ArgumentNullException("CODEMPRESA", " O código não pode ser nulo");
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
