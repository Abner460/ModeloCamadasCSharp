using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class MODELOEleicao
    {
        private Int32 IDELEICAO;
        private Int32 IDEMPRESA;
        private string NOME;
        private string DESCRICAO;
        private int TIPOVOTO;
        private string MENSAGEMENCERRADO;
        private string MENSAGEMFIM;
        private DateTime DATAINICIO;
        private DateTime DATAFIM;

        public int IDELEICAO1 { get => IDELEICAO; set => IDELEICAO = value; }
        public int IDEMPRESA1 { get => IDEMPRESA; set => IDEMPRESA = value; }
        public string NOME1 { get => NOME; set => NOME = value; }
        public string DESCRICAO1 { get => DESCRICAO; set => DESCRICAO = value; }
        public int TIPOVOTO1 { get => TIPOVOTO; set => TIPOVOTO = value; }
        public string MENSAGEMENCERRADO1 { get => MENSAGEMENCERRADO; set => MENSAGEMENCERRADO = value; }
        public string MENSAGEMFIM1 { get => MENSAGEMFIM; set => MENSAGEMFIM = value; }
        public DateTime DATAINICIO1 { get => DATAINICIO; set => DATAINICIO = value; }
        public DateTime DATAFIM1 { get => DATAFIM; set => DATAFIM = value; }
    }
}
