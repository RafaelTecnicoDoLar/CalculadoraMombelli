using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMombelli
{
    public partial class Calculadora : Form
    {
        string UserInput = "";
        private keyNumHandler Key;
        private KeyOpHandler KeyOp;

        public Calculadora()
        {
            InitializeComponent();
            thema.Items.AddRange(new string[] { "Claro", "Escuro" });

            this.KeyPreview = true;

            Key = new keyNumHandler(UserInput, responce);
            this.KeyDown += new KeyEventHandler(Key.handlerKeyDown);

            KeyOp = new KeyOpHandler(UserInput, Operator);
            this.KeyDown += new KeyEventHandler(KeyOp.handlerKeyDown);
        }
        private void thema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (thema.SelectedIndex != 1)
            {
                this.BackColor = Color.WhiteSmoke;
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button) ctrl.BackColor = Color.LightGray;
                }
            }
            else
            {
                this.BackColor = Color.Black;
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button) ctrl.BackColor = Color.DimGray;
                }
            }
        }
        private void bntNumFunction(object sender, EventArgs e)
        {
            Button bnt = sender as Button;
            if (bnt != null)
            {
                UserInput += bnt.Text;
                responce.Text = UserInput;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            UserInput = "";
            responce.Text = UserInput;
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (UserInput.Length > 0)
            {
                UserInput = UserInput.Substring(0, UserInput.Length - 1);
                responce.Text = UserInput;
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            bntNumFunction(sender, e);
        }

        private void one_Click(object sender, EventArgs e)
        {
            bntNumFunction(sender, e);
        }

        private void two_Click(object sender, EventArgs e)
        {
            bntNumFunction(sender, e);
        }

        private void three_Click(object sender, EventArgs e)
        {
            bntNumFunction(sender, e);
        }

        private void four_Click(object sender, EventArgs e)
        {
            bntNumFunction(sender, e);
        }

        private void five_Click(object sender, EventArgs e)
        {
            bntNumFunction(sender, e);
        }

        private void six_Click(object sender, EventArgs e)
        {
            bntNumFunction(sender, e);
        }

        private void seven_Click(object sender, EventArgs e)
        {
            bntNumFunction(sender, e);
        }

        private void eight_Click(object sender, EventArgs e)
        {
            bntNumFunction(sender, e);
        }

        private void nine_Click(object sender, EventArgs e)
        {
            bntNumFunction(sender, e);
        }

        private void numA_Click(object sender, EventArgs e)
        {
            bntNumFunction(sender, e);
        }
        private void numB_Click(object sender, EventArgs e)
        {
            bntNumFunction(sender, e);
        }

        private void numC_Click(object sender, EventArgs e)
        {
            bntNumFunction(sender, e);
        }

        private void numD_Click(object sender, EventArgs e)
        {
            bntNumFunction(sender, e);
        }

        private void numE_Click(object sender, EventArgs e)
        {
            bntNumFunction(sender, e);
        }

        private void numF_Click(object sender, EventArgs e)
        {
            bntNumFunction(sender, e);
        }
        private void dot_Click(object sender, EventArgs e)
        {
            bntNumFunction(sender, e);
        }

        private void modules_Click(object sender, EventArgs e)
        {

        }

        private void answer_Click(object sender, EventArgs e)
        {

        }

        private void negative_Click(object sender, EventArgs e)
        {

        }

        private void random_Click(object sender, EventArgs e)
        {

        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void binary_Click(object sender, EventArgs e)
        {

        }

        private void hexadecimal_Click(object sender, EventArgs e)
        {

        }

        private void octal_Click(object sender, EventArgs e)
        {

        }

        private void numDecimal_Click(object sender, EventArgs e)
        {

        }

        private void exponent_Click(object sender, EventArgs e)
        {

        }

        private void tangent_Click(object sender, EventArgs e)
        {

        }

        private void cosine_Click(object sender, EventArgs e)
        {

        }

        private void sine_Click(object sender, EventArgs e)
        {

        }

        private void degrees_Click(object sender, EventArgs e)
        {

        }

        private void secundaryFunction_Click(object sender, EventArgs e)
        {

        }

        private void openParentheses_Click(object sender, EventArgs e)
        {

        }

        private void naturalLogarithm_Click(object sender, EventArgs e)
        {

        }

        private void logarithm_Click(object sender, EventArgs e)
        {

        }

        private void exponential_Click(object sender, EventArgs e)
        {

        }

        private void binomial_Click(object sender, EventArgs e)
        {

        }

        private void closeParentheses_Click(object sender, EventArgs e)
        {

        }

        private void squareRoot_Click(object sender, EventArgs e)
        {

        }

        private void factorial_Click(object sender, EventArgs e)
        {

        }

        private void fraction_Click(object sender, EventArgs e)
        {

        }

        private void pi_Click(object sender, EventArgs e)
        {

        }

        private void euler_Click(object sender, EventArgs e)
        {

        }
        private void percentage_Click(object sender, EventArgs e)
        {

        }
        private void division_Click(object sender, EventArgs e)
        {

        }

        private void multiplication_Click(object sender, EventArgs e)
        {

        }

        private void subtraction_Click(object sender, EventArgs e)
        {

        }

        private void sum_Click(object sender, EventArgs e)
        {

        }

        private void equal_Click(object sender, EventArgs e)
        {

        }



        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
        private void responce_Click(object sender, EventArgs e)
        {

        }

        private void preciousAnswer_Click(object sender, EventArgs e)
        {

        }

        private void Operator_Click(object sender, EventArgs e)
        {

        }
    }
}
