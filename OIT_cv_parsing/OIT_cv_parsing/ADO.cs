﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace OIT_cv_parsing
{
    class ADO
    {
        // Declaration des objets sql
        public SqlConnection cnx = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();

        // declaration de la methode connecter
        public void CONNECTER()
        {
            if (cnx.State == ConnectionState.Closed || cnx.State == ConnectionState.Broken)
            {
                // cnx.ConnectionString = "Data Source=LENOVOPC;Initial Catalog=TDI;Integrated Security=True";
<<<<<<< HEAD
                cnx.ConnectionString = @"Data Source=.;Initial Catalog=login;Integrated Security=True";
=======
                cnx.ConnectionString = @"Data Source=DESKTOP-4ALIMHA\SQLEXPRESS;Initial Catalog=parsing;Integrated Security=True";
>>>>>>> bba56c88950a3b1d1500a21cdc59ac6784af01b9
                cnx.Open();
            }
        }

        // declaration de la methode deconnecter
        public void DECONNECTER()
        {
            if (cnx.State == ConnectionState.Open)
            {

                cnx.Close();
            }
        }   
    }
}
