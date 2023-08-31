using System;
using System.Data.SqlClient;

namespace ProyectoPrototipo_1._0
{
    public class Connect
    {
        private string usuario;
        private string pass;
        public string server;
        private string bd;
        public string con;
        public static SqlConnection? connect;

        public Connect(string usuario, string pass)
        {
            this.usuario = usuario;
            this.pass = pass;

            /*
            server = "LAPTOP-S7D8N62P\\MSSQLSERVER10";
            bd = "db_farmacy";

            con = "Server=" + server + ";Database=" + bd + ";User Id=" + usuario + ";Password=" + pass;
            */


            server = "DESKTOP-OUHSBBV";
            bd = "db_farmacia";

            con = "Data Source=" + server + ";Initial Catalog=" + bd + ";Integrated Security = true";

        }

        public SqlConnection? RealizarConexion()
        {
            try
            {
                connect = new SqlConnection(con);
                connect.Open();
            }
            catch (Exception)
            {
                connect = null;
            }

            return connect;
        }

        public string CadenaConexion
        {
            get { return con; }
        }
    }
}
