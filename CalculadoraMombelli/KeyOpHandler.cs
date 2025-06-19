using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMombelli
{
    internal class KeyOpHandler
    {
        private string UserInput = "";
        private Label labelResponce;

        public KeyOpHandler(string UserInput, Label responce)
        {
            this.labelResponce = responce;
            this.UserInput = UserInput;
        }

        public void handlerKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus)
            {
                UserInput = "+";
                labelResponce.Text = UserInput;

            } else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
            {
                UserInput = "-";
                labelResponce.Text = UserInput;

            }
            else if (e.KeyCode == Keys.Multiply)
            {
                UserInput = "X";
                labelResponce.Text = UserInput;

            }
            else if (e.KeyCode == Keys.Divide)
            {
                UserInput = "÷";
                labelResponce.Text = UserInput;

            }
            /*else if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.Oemcomma)
            {
                UserInput = ".";
                labelResponce.Text = UserInput;

            } */
            else if (e.KeyCode == Keys.Enter)
            {
                UserInput = "=";
                labelResponce.Text = UserInput;

            }

        }
    }
}
