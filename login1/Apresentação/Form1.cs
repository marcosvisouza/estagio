using login1.Apresentação;
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
using login1.Modelo;
using jogo_da_velha_2;

namespace login1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txbLogin.Text, txbSenha.Text);
            if (controle.mensagem.Equals(""))
            {

                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    velha velha = new velha();
                    velha.Show();
                    
                }
                else
                {
                    MessageBox.Show("Login ou senha incorretos", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            telaRegistrar cad = new telaRegistrar();
            cad.Show();
        }

        private void boxSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
