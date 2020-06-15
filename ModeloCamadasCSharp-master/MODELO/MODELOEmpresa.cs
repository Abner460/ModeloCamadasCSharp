using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class MODELOEmpresa
    {
        private Int32 IDEMPRESA;
        private string NOME;
        private string DESCRICAO;
        private string CODEMPRESA;

        public int IDEMPRESA1 { get { return IDEMPRESA; } set { IDEMPRESA = value; } }
        public string NOME1 { get { return NOME; } set { NOME = value; } }
        public string CODEMPRESA1 { get { return CODEMPRESA; } set { CODEMPRESA = value; } }
        public string DESCRICAO1 { get { return DESCRICAO; } set { DESCRICAO = value; } }
    }
}
