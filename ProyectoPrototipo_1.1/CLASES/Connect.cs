using System;
using System.Data.SqlClient;

namespace ProyectoPrototipo_1._0
{
    public class Connect
    {
        public string usuario;
        public string pass;
        public string server;
        private string bd;
        public string con;
        public string stringconnect;
        public static SqlConnection? connect;

        public Connect(string usuario, string pass)
        {
            this.usuario = usuario;
            this.pass = pass;
            server = " DESKTOP-OUHSBBV";

            bd = "db_farmacia";

            con= "Server=DESKTOP-OUHSBBV;Database=db_farmacia;Integrated Security=True;";
            //con = "Server=" + server + ";Database=" + bd + ";User Id=" + usuario + ";Password=" + pass;
            stringconnect = "Server=DESKTOP-OUHSBBV;Database=db_farmacia;Integrated Security=True;";

        }
        //Connect Poaquiza
        /*public Connect(string usuario, string pass)
        {
            this.usuario = usuario;
            this.pass = pass;

            server = "LAPTOP-S7D8N62P\\MSSQLSERVER10";

            bd = "db_farmacia";

            con = "Server=" + server + ";Database=" + bd + ";User Id=" + usuario + ";Password=" + pass;
            stringconnect = "Server=" + server + ";Database=" + bd + ";User Id=" + usuario + ";Password=" + pass;
        }*/

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
