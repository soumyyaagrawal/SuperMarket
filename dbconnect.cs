using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;    

namespace SuperMarket
{
     class DBconnect

    {
        private SqlConnection con = new SqlConnection(@"Data Source=COMPUTER\SQLEXPRESS;Initial Catalog=sm;Integrated Security=True;");

        public SqlConnection Getcon()
        { return con; }
        public void Opencon()
        {
            if(con.State== ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void Closecon()
        {
            if (con.State == ConnectionState.Open)
                
                con.Close();
            }
        }
    }

