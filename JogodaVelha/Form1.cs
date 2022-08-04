using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogodaVelha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        bool turno = true; // true = vez de X // false = vez de O
        int turno_cont = 0;
        static String jogador1, jogador2;

        public static void definirjogadores(String j1, String j2) 
        {
            jogador1 = j1;
            jogador2 = j2;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            vitoriasX.Text = jogador1;
            vitoriasO.Text = jogador2;

        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Realizado por Matheus", "Sobre Jogo da Velha");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Primeiro Botão
        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turno)

                b.Text = "X";

            else

                b.Text = "O";

            turno = !turno;
            b.Enabled = false;
            turno_cont++;

            checarvencedor();
        }

        // checagem de vencedor


        private void checarvencedor()
        {
            bool quemvenceu = false;

            //checagem de linhas horizontais
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                quemvenceu = true;

            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                quemvenceu = true;

            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                quemvenceu = true;

            //checagem de linhas verticais
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                quemvenceu = true;

            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                quemvenceu = true;

            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                quemvenceu = true;

            //checagem de linhas diagonais
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                quemvenceu = true;

            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                quemvenceu = true;




            // Mensagem de Vencedor

            if (quemvenceu)

            {
                disableButtons();

                String vencedor = "";
                if (turno)
                { 
                    vencedor = jogador2;
                    contadorO.Text = (Int32.Parse(contadorO.Text) + 1).ToString();
                }
                else 
                { 
                    vencedor = jogador1;
                    contadorX.Text = (Int32.Parse(contadorX.Text) + 1).ToString();
                }


                MessageBox.Show(vencedor + " Ganhou!", "Você venceu!");
            }// fim do if
            else
            {
                if (turno_cont == 9)
                {
                    contadorempate.Text = (Int32.Parse(contadorempate.Text) + 1).ToString();
                    MessageBox.Show("Empatou!", "Vocês empataram");
                }
            }



        } // fim da checagem de vencedor

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void novoJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turno = true;
            turno_cont = 0;

           

                foreach (Control c in Controls)
                {
                try
                {

                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }//fim do foreach
           
        }

        private void reiniciarPontuaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contadorO.Text = "0";
            contadorX.Text = "0";
            contadorempate.Text = "0";

        }

        //  private void Button_enter(object sender, EventArgs e)
        //{
        //  try
        //{
        //  Button b = (Button)sender;
        //if (b.Enabled)
        //{
        //  if (turno)
        //    b.Text = "X";
        // else
        //   b.Text = "O";

        //     }//fim de if
        // } 
        //catch { }

        //  }
        //
        // private void Button_leave(object sender, EventArgs e)
        // {
        //   try { 
        // Button b = (Button)sender;
        // if (b.Enabled)
        // {

        //  b.Text = "";

        //     }//fim de if
        //   } 
        //  catch {}
    }
}

