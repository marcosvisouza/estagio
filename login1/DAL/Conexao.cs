using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace login1.DAL
{
    public class Conexao
    {
       SqlConnection con = new SqlConnection();
       
        public Conexao() 
        {
            con.ConnectionString = @"Data Source=DESKTOP-PGCV3T7\SQLEXPRESS;Initial Catalog=projeto_login;Integrated Security=True;Trust Server Certificate=True";
        }public SqlConnection conectar() 
        {
            if (con.State ==System.Data.ConnectionState.Closed) 
            { 
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {   
                con.Close();
            }
        }
    }
}
