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


            if (numeroString.Length == 0)
            {
                MessageBox.Show("Por favor preencha o campo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int[] numeroCPF = new int[11];


            string CPFsemMascara = RemoverCaracteresEspeciais(numeroString);

            if (Letras(numeroString)){

                MessageBox.Show("O CPF deve conter apenas numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        

            for (int i = 0; i < 11; i++) {

                numeroCPF[i] = int.Parse(CPFsemMascara[i].ToString());
            }

            
            int soma = 0;

            for(int i = 0; i < 9; i++) {

                soma += numeroCPF[i] * (10 - i);

            }

            int div = (soma * 10) % 11;

            if (div == 10 || div == 11) {
                numeroCPF[9] = 0;
            }else {
                numeroCPF[9] = div;
            }


            int soma2 = 0;

            for(int i = 0;i < 10; i++) {

                soma2 += numeroCPF[i] * (11 - i);

            }

            int div2 = (soma2 * 10) % 11;
            if (div2 == 10 || div2 == 11)
            {
                numeroCPF[10] = 0;
            }
            else
            {
                numeroCPF[10] = div2;
            }

            char digito1 = CPFsemMascara[9];
            char digito2 = CPFsemMascara[10];
            char dig = Convert.ToChar(numeroCPF[9].ToString());
            char dig2 = Convert.ToChar(numeroCPF[10].ToString());

                
            if ( dig == digito1 &&  dig2 == digito2 ) {

                MessageBox.Show("Seu CPF é válido", "Aceito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else {

                MessageBox.Show("Seu CPF é inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void btnGeradorCPF_Click(object sender, EventArgs e)
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

            txtGerarCPF.Text = cpfNovo;



        }
        static string RemoverCaracteresEspeciais(string input)
        {

            string resultado = Regex.Replace(input, @"[^0-9]", "");
            return resultado;

        }


        static bool Letras (string value){

            foreach(char c in value) {  
            
                if (char.IsLetter(c))
                {
                    return true;
                }

               
            
            }
            return false;
        }
    
    
    }
}
