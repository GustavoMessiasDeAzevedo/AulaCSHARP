using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmSoftwareCPFeCNPJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



       
  







        
        static string RemoverCaracteresEspeciais(string input)
        {

            string resultado = Regex.Replace(input, @"[^0-9]", "");
            return resultado;

        }

        static bool Letras(string value)
        {

            foreach (char c in value)
            {

                if (char.IsLetter(c))
                {
                    return true;
                }
            }
            return false;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void BtnGerar_Click(object sender, EventArgs e)
        {
            if (!RadCNPJ.Checked && !RadCPF.Checked)
            {

                MessageBox.Show("Selecione o CPF ou o CNPJ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            if (RadCPF.Checked)
            {
                int[] cpfArray = new int[11];
                string[] numeroCPF = new string[11];

                Random random = new Random();

                for (int i = 0; i < 11; i++)
                {
                    cpfArray[i] = random.Next(0, 10);
                }

                for (int i = 0; i < 9; i++)
                {
                    numeroCPF[i] = cpfArray[i].ToString();
                }

                int soma = 0;
                for (int i = 0; i < 9; i++)
                {
                    soma += cpfArray[i] * (10 - i);
                }

                int div = (soma * 10) % 11;

                if (div == 10 || div == 11)
                {
                    cpfArray[9] = 0;

                }
                else
                {
                    cpfArray[9] = div;
                }

                int soma2 = 0;
                for (int i = 0; i < 10; i++)
                {
                    soma2 += cpfArray[i] * (11 - i);
                }

                int div2 = (soma2 * 10) % 11;
                if (div2 == 10 || div2 == 11)
                {
                    cpfArray[10] = 0;
                }
                else
                {
                    cpfArray[10] = div2;
                }

                string cpfNovo = $"{numeroCPF[0]}{numeroCPF[1]}{numeroCPF[2]}.{numeroCPF[3]}{numeroCPF[4]}{numeroCPF[5]}.{numeroCPF[6]}{numeroCPF[7]}{numeroCPF[8]}-{cpfArray[9]}{cpfArray[10]}";

                txtCPForCNPJ.Text = cpfNovo;
            }

            if (RadCNPJ.Checked)
            {

            }
           
        }

        private void validarCPFECNPJToolStripMenuItem_Click(object sender, EventArgs e)
        {
         BtnGerar.Hide();
         BtnValidar.Show();
         txtCPForCNPJ.Clear();
        
        }

        private void gerarCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnValidar.Hide();
            BtnGerar.Show();
            txtCPForCNPJ.ReadOnly = false;
            txtCPForCNPJ.Clear();
        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {

            if (!RadCNPJ.Checked && !RadCPF.Checked)
            {

                MessageBox.Show("Selecione o CPF ou o CNPJ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


            if (RadCPF.Checked)
            {



                string numeroString = txtCPForCNPJ.Text;
                int[] numeroCPF = new int[11];

                if (Letras(numeroString))
                {

                    MessageBox.Show("O CPF aceita apenas numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (numeroString.Length >= 15)
                {
                    MessageBox.Show("O número de caracteres foi ultrapassado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string cpfSemMascara = RemoverCaracteresEspeciais(numeroString);


                for (int i = 0; i < 11; i++)
                {
                    numeroCPF[i] = int.Parse(cpfSemMascara[i].ToString());

                }

                int soma = 0;

                for (int i = 0; i < 9; i++)
                {
                    soma += numeroCPF[i] * (10 - i);
                }

                int div = (soma * 10) % 11;
                if (div == 10)
                {
                    numeroCPF[9] = 0;
                }
                else
                {
                    numeroCPF[9] = div;
                }


                int soma2 = 0;

                for (int i = 0; i < 10; i++)
                {
                    soma2 += numeroCPF[i] * (11 - i);
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

                char digito1 = cpfSemMascara[9];
                char digito2 = cpfSemMascara[10];
                char dig = Convert.ToChar(numeroCPF[9].ToString());
                char dig2 = Convert.ToChar(numeroCPF[10].ToString());


                if (dig == digito1 && dig2 == digito2)
                {

                    MessageBox.Show("Seu CPF é válido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCPForCNPJ.Clear();

                }
                else
                {

                    MessageBox.Show("Seu CPF é inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCPForCNPJ.Clear();
                }
            }

            if (RadCNPJ.Checked)
            {



                string numeroStringCpnj = txtCPForCNPJ.Text;

                if (numeroStringCpnj.Length >= 19)
                {
                    MessageBox.Show("O número de caracteres foi ultrapassado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string cnpjSemMascara = RemoverCaracteresEspeciais(numeroStringCpnj);

                if (Letras(numeroStringCpnj))
                {

                    MessageBox.Show("O CNPJ aceita apenas numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                int[] numeroCNPJ = new int[14];
                int[] multiplicacao = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicacao2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

                for (int i = 0; i < 14; i++)
                {

                    numeroCNPJ[i] = int.Parse(cnpjSemMascara[i].ToString());
                }

                int soma = 0;

                for (int i = 0; i < 12; i++)
                {

                    soma += numeroCNPJ[i] * multiplicacao[i];
                }

                int divisao = soma % 11;

                numeroCNPJ[12] = (divisao < 2) ? 0 : 11 - divisao;

                int soma2 = 0;
                for (int i = 0; i < 13; i++)
                {

                    soma2 += numeroCNPJ[i] * multiplicacao2[i];
                }

                int divisao2 = soma2 % 11;

                numeroCNPJ[13] = (divisao2 < 2) ? 0 : 11 - divisao2;

                char digito1 = cnpjSemMascara[12];
                char digito2 = cnpjSemMascara[13];
                char dig1 = Convert.ToChar(numeroCNPJ[12].ToString());
                char dig2 = Convert.ToChar(numeroCNPJ[13].ToString());





                if (dig1 == digito1 && dig2 == digito2)
                {

                    MessageBox.Show("Seu CNPJ é válido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCPForCNPJ.Clear();

                }
                else
                {

                    MessageBox.Show("Seu CNPJ é inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCPForCNPJ.Clear();
                }
            }
        }
    }
}
