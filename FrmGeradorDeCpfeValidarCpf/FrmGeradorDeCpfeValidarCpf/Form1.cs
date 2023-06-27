using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmGeradorDeCpfeValidarCpf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidarCPF_Click(object sender, EventArgs e)
        {

            string numeroString = txtCPF.Text;
            int[] numeroCPF = new int[11];


            for(int i = 0; i < 11; i++) {

                numeroCPF[i] = int.Parse(numeroString[i].ToString());
                //MessageBox.Show(numeroString[i].ToString());
            }

            
            int soma = 0;

            for(int i = 0; i < 9; i++) {

                soma += numeroCPF[i] * (10 - i);

            }

            int div = (soma * 10) % 11;

            if (div == 10) {
                numeroCPF[9] = 0;
            }else {
                numeroCPF[9] = div;
            }


            int soma2 = 0;

            for(int i = 0;i < 10; i++) {

                soma += numeroCPF[i] * (11 - i);

            }

            int div2 = (soma2 * 10) % 11;

            if (div2 == 11)
            {
                numeroCPF[10] = 0;
            }
            else
            {
                numeroCPF[10] = div2;
            }

            char digito1 = numeroString[9];
            char digito2 = numeroString[10];
            char dig = Convert.ToChar(numeroCPF[9].ToString());
            char dig2 = Convert.ToChar(numeroCPF[10].ToString());

            if( dig == digito1 &&  dig2 == digito2 ) {

                MessageBox.Show("Seu CPF é válido", "Aceito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else {

                MessageBox.Show("Seu CPF é inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
    }
}
