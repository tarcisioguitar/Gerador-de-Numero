using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerador_de_numero
{
    public partial class Form1 : Form
    {
        Random aleatorio = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbQuantidadeJogos.SelectedIndex = 0;
            cbQuantidadeNumeros.SelectedIndex = 0;
            jogo1.Visible = false;
            jogo2.Visible = false;
            jogo3.Visible = false;
        }

        private async void btnGerar_Click(object sender, EventArgs e)
        {
            jogo1.Text = "";
            jogo2.Text = "";
            jogo3.Text = "";
            int qtdJogos = Convert.ToByte(cbQuantidadeJogos.Text);
            int qtdNumeros = Convert.ToByte(cbQuantidadeNumeros.Text);

            btnGerar.Visible = false;
            for (int i = 1; i <= 100; i++)
            {
                await Task.Delay(10);
                progressBar1.Value = i;
                
            }
            
            MostrarJogos(qtdNumeros, qtdJogos);

            btnGerar.Visible = true;

        }

        public void MostrarJogos(int qtdNumeros, int qtdJogos)
        {
            jogo1.Visible = true;
            jogo2.Visible = true;
            jogo3.Visible = true;

            switch (qtdJogos)
            {
                case 1:
                    jogo1.Text = "Jogo 1:   " + CriarJogo(qtdNumeros);
                    break;
                case 2:
                    jogo1.Text = "Jogo 1:   " + CriarJogo(qtdNumeros);
                    jogo2.Text = "Jogo 2:   " + CriarJogo(qtdNumeros);
                    break;
                case 3:
                    jogo1.Text = "Jogo 1:   " + CriarJogo(qtdNumeros);
                    jogo2.Text = "Jogo 2:   " + CriarJogo(qtdNumeros);
                    jogo3.Text = "Jogo 3:   " + CriarJogo(qtdNumeros);
                    break;
                default:
                    MessageBox.Show("Houve algum erro");
                    return;
            }
        }

     
        public string CriarJogo(int qtdNumero)
        {

            string numero;
            string resultado = "";
            for (int i = 1; i <= qtdNumero; i++)
            {
                numero = aleatorio.Next(1, 99).ToString("D2");
                if (resultado.Contains(numero))
                {
                    numero = "";
                    numero = aleatorio.Next(1, 99).ToString("D2");
                    if (resultado.Contains(numero))
                    {
                        MessageBox.Show($"Número repetido {numero}");
                        numero = "";
                        numero = aleatorio.Next(1, 99).ToString("D2");

                    }
                }

                resultado += numero + "    ";
            }

            return resultado;
        }



    }
}