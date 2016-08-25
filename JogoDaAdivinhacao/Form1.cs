using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaAdivinhacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }




        Random rnd = new Random();
        byte numeroSorteado; 

        private void Form1_Load(object sender, EventArgs e)
        {

            numeroSorteado = (byte)rnd.Next(1, 100);
        }

        byte nTentativas = 10;

        private void btnPalpite_Click(object sender, EventArgs e)
        {

            nTentativas--;
            lbTentativas.Text = nTentativas + "";
            byte recebeNum = byte.Parse(txtPalpite.Text);

           
            string enviaMsg;
            if (nTentativas > 0)
            {

                if (recebeNum < numeroSorteado)
                {
                    enviaMsg = "Você errou! o número é mais alto.";
                    lbResposta.Text = enviaMsg;

                }
                else if (recebeNum > numeroSorteado)
                {
                    enviaMsg = "Você errou! o número é mais baixo.";
                    lbResposta.Text = enviaMsg;

                }
                else
                {
                    enviaMsg = "Parabéns! você acertou, o número sorteado é: " + numeroSorteado;
                    lbResposta.Text = enviaMsg;
                    btnPalpite.Visible = false;
                    txtPalpite.Visible = false;
                    lbInform.Visible = false;
                }
                

            }
            else
            {
                enviaMsg = "Você perdeu, o número sorteado é: " + numeroSorteado;
                lbResposta.Text = enviaMsg;
                btnPalpite.Visible = false;
                txtPalpite.Visible = false;
                lbInform.Visible = false;
            }
            
           
           
        }
        
     
    }
}
