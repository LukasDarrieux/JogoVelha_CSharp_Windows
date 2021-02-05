using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
   
    public partial class Form1 : Form
    {
        public int X = 1, O = 1;
        public string JogadorAtual = "X";
        public Form1()
        {
            InitializeComponent();
        }

        public string InverterJogador()
        {
            if (JogadorAtual == "X")
            {
                return "O";
            }
            else
            {
                return "X";
            }
            return "X";
        }

        void Ganhar()
        {
            
            if (JogadorAtual == "X")
            {
                
                lblX.Text = "X: " + X++;
            }
            if (JogadorAtual == "O")
            {
                
                lblO.Text = "O: " + O++;
            }
            MessageBox.Show("O jogador " + JogadorAtual + " ganhou!");
            Limpar();
        }

        public bool Verificar(string JogadorAt)
        {
            if (button1.Text == JogadorAtual && button2.Text == JogadorAtual && button3.Text == JogadorAtual)
            {
                Ganhar();
                return true;
            }
            if (button4.Text == JogadorAtual && button5.Text == JogadorAtual && button6.Text == JogadorAtual)
            {
                Ganhar();
                return true;
            }
            if (button7.Text == JogadorAtual && button8.Text == JogadorAtual && button9.Text == JogadorAtual)
            {
                Ganhar();
                return true;
            }
            if (button1.Text == JogadorAtual && button4.Text == JogadorAtual && button7.Text == JogadorAtual)
            {
                Ganhar();
                return true;
            }
            if (button2.Text == JogadorAtual && button5.Text == JogadorAtual && button8.Text == JogadorAtual)
            {
                Ganhar();
                return true;
            }
            if (button3.Text == JogadorAtual && button6.Text == JogadorAtual && button9.Text == JogadorAtual)
            {
                Ganhar();
                return true;
            }
            if (button1.Text == JogadorAtual && button5.Text == JogadorAtual && button9.Text == JogadorAtual)
            {
                Ganhar();
                return true;
            }
            if (button3.Text == JogadorAtual && button5.Text == JogadorAtual && button7.Text == JogadorAtual)
            {
                Ganhar();
                return true;
            }
            if (button1.Text.Length != 0 && button2.Text.Length != 0 && button3.Text.Length != 0 && button4.Text.Length != 0 && button5.Text.Length != 0 && button6.Text.Length != 0 && button7.Text.Length != 0 && button8.Text.Length != 0 && button9.Text.Length != 0)
            {
                MessageBox.Show("Deu Velha!");
                Limpar();
                return true;
            }
            JogadorAtual = InverterJogador();
            label1.Text = "Jogador Atual: " + JogadorAtual;
            return false;
        }

        public void Limpar()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            label1.Text = "Jogador Atual: X";
            JogadorAtual = "X"; 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = JogadorAtual;
                Verificar(JogadorAtual);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = JogadorAtual;
                Verificar(JogadorAtual);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = JogadorAtual;
                Verificar(JogadorAtual);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                button4.Text = JogadorAtual;
                Verificar(JogadorAtual);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                button5.Text = JogadorAtual;
                Verificar(JogadorAtual);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = JogadorAtual;
                Verificar(JogadorAtual);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                button7.Text = JogadorAtual;
                Verificar(JogadorAtual);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                button8.Text = JogadorAtual;
                Verificar(JogadorAtual);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                button9.Text = JogadorAtual;
                Verificar(JogadorAtual);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Limpar();
            X = 1;
            O = 1;
            lblO.Text = "O: 0";
            lblX.Text = "X: 0";
        }
    }
}
