using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Data Access Layer*/
namespace DAL
{
    public class DadosDaConexao
    {
        private string server = "remotemysql.com";
        private string port = "3306";
        private string user = "6UPAWT1quh";
        private string database = "6UPAWT1quh";
        private string password = "gYNZWUjBja";

        public string StringDeConexao
        {
            get
            {
                return "server=" + this.server + ";" +
                       "port=" + this.port + ";" +
                       "User Id=" + this.user + ";" +
                       "Password=" + this.password + ";" +
                       "database=" + this.database + ";";
            }
        }

    }
}
