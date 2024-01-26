using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jogo_da_velha_2
{
    public partial class velha : Form
    {
        int Xpts = 0, Opts = 0, empt = 0, rodadas = 0;
        bool turno = true, jogo_final = false;
        string[] texto = new string[9];

        public velha()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int button_index = btn.TabIndex;

            if (btn.Text == "" && jogo_final == false)
            {

                if (turno)
                {
                    btn.Text = "X";
                    texto[button_index] = "X";
                    rodadas++;
                    turno = !turno;
                    Checagem(1);
                }
                else
                {
                    btn.Text = "O";
                    texto[button_index] = "O";
                    rodadas++;
                    turno = !turno;
                    Checagem(2);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            btn.Text = "";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";

            for (int i = 0; i < 9; i++)
            {
                texto[i] = "";
                rodadas = 0;
                jogo_final = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        void vencedor(int player_ganhou)
        {
            jogo_final = true;

            if (player_ganhou == 1)
            {
                Xpts++;
                Xpontos.Text = Convert.ToString(Xpts);
                MessageBox.Show("X ganhou");
                turno = true;

            }
            else
            {
                Opts++;
                Opontos.Text = Convert.ToString(Opts);
                MessageBox.Show("O ganhou");
                turno = false;
            }
        }

        void Checagem(int checagem_player)
        {
            string suporte = "";

            if (checagem_player == 1)
            {
                suporte = "X";
            }
            else
            {
                suporte = "O";
            } //suporte

            for (int horizontal = 0; horizontal < 8; horizontal += 3)
            {
                if (suporte == texto[horizontal])
                {
                    if (texto[horizontal] == texto[horizontal + 1] && texto[horizontal] == texto[horizontal + 2])
                    {
                        vencedor(checagem_player);
                        return;
                    }
                }//checagen horizontal
            }

            for (int vertical = 0; vertical < 3; vertical++)
            {
                if (suporte == texto[vertical])
                {
                    if (texto[vertical] == texto[vertical + 3] && texto[vertical] == texto[vertical + 6])
                    {
                        vencedor(checagem_player);
                        return;
                    }
                }//checagen horizontal
            }

            if (texto[0] == suporte)
            {

                if (texto[0] == texto[4] && texto[0] == texto[8])
                {
                    vencedor(checagem_player);
                    return;
                }
            }

            if (texto[2] == suporte)
            {

                if (texto[2] == texto[4] && texto[2] == texto[6])
                {
                    vencedor(checagem_player);
                    return;
                }
            }
            if (rodadas == 9 && jogo_final == false)
            {
                empt++;
                Empates.Text = Convert.ToString(empt);
                MessageBox.Show("Empate");
                turno = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
