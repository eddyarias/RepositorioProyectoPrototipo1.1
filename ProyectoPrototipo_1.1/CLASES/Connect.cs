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

        //public Connect(string usuario, string pass)//deben cambiar para que se les conecte automaticamente.
        //{
        //    //this.usuario = usuario;
        //    //this.pass = pass;
        //    //server = "DESKTOP-PEKBI3D";
        //    //bd = "db_farmacia";
        //    //con = "Server=" + server + ";Database=" + bd + ";Integrated Security=True;";

        //    this.usuario = usuario;
        //    this.pass = pass;
        //    server = "LAPTOP-VF0SV152\\SQLEXPRESS";
        //    bd = "db_farmacia";
        //    con = "Server=" + server + ";Database=" + bd + ";Integrated Security=True;";
        //}

        ////Connect Poaquiza
        public Connect()
        {
            this.usuario = "Milton";
            this.pass = "Epn123";

            server = "LAPTOP-VF0SV152\\SQLEXPRESS";

            bd = "db_farmacia";

            con = "Server=" + server + ";Database=" + bd + ";User Id=" + usuario + ";Password=" + pass;
            stringconnect = "Server=" + server + ";Database=" + bd + ";User Id=" + usuario + ";Password=" + pass;
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
