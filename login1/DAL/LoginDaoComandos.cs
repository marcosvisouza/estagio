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
    class LoginDalComandos
    {
        public bool tem = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader? dr;

        public bool VericarLogin(string login, string senha)
        { //verficar se tem no banco 
            cmd.CommandText = "select * from logins where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }

            catch (SqlException)
            {

                this.mensagem = "Erro com o banco de dados";
            }
            return tem;
            
        }
        public string cadastrar(string email, string senha, string confsenha)
        {//inserir no banco
            tem = false;
            if(senha.Equals(confsenha))
            {
                cmd.CommandText = "insert into logins values (@e, @s);";
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", senha);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com sucesso";
                    tem = true;
                }
                catch (SqlException)
                {

                    this.mensagem = "Erro com o banco de dados";
                }
                
            }
            else
            {
                this.mensagem = "Senhas não correspondem";
            }
            cmd.CommandText = "";
            return mensagem;
        }

        
    }
}
