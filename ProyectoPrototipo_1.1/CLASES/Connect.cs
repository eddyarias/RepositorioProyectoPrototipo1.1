﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoPrototipo_1._0
{
    public class Connect
    {
        private string usuario;
        private string pass;
        private string server;
        private string bd;
        private string con;
        private SqlConnection connect;

        public Connect()
        {
            usuario = ""; //crean un usuario como muestra el video 4, o usan el generico "sa" con la contraseña que crean cuando se instala el sql server
            server = "LAPTOP-S7D8N62P\\MSSQLSERVER10"; //poner su propio servidor con \\ en medio
            bd = "db_farmacia"; //nombre de su base de datos

            con = "Server=" + server + ";Database=" + bd + ";User Id=" + usuario + ";Password=" + pass;
        }

        public Connect(string usuario, string pass)
        {
            this.usuario = usuario;
            this.pass = pass;
            server = "LAPTOP-S7D8N62P\\MSSQLSERVER10";
            bd = "db_farmacia";

            con = "Server=" + server + ";Database=" + bd + ";User Id=" + usuario + ";Password=" + pass;
        }

        public SqlConnection RealizarConexion()
        {
            try
            {
                connect = new SqlConnection(con);
                connect.Open();
            }
            catch (Exception e)
            {
                connect = null;
            }

            return connect;
        }
    }


}
