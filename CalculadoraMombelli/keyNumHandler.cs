using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMombelli
{
    internal class keyNumHandler
    {
        private string UserInput = "";
        private Label labelResponce;

        public keyNumHandler(string UserInput, Label responce)
        {
            this.labelResponce = responce;
            this.UserInput = UserInput;
        }
        public void handlerKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                UserInput += "0";
                labelResponce.Text = UserInput;

            }
            else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                UserInput += "1";
                labelResponce.Text = UserInput;

            }
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                UserInput += "2";
                labelResponce.Text = UserInput;

            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                UserInput += "3";
                labelResponce.Text = UserInput;

            }
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                UserInput += "4";
                labelResponce.Text = UserInput;

            }
            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                UserInput += "5";
                labelResponce.Text = UserInput;

            }
            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                UserInput += "6";
                labelResponce.Text = UserInput;

            }
            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                UserInput += "7";
                labelResponce.Text = UserInput;

            }
            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                UserInput += "8";
                labelResponce.Text = UserInput;

            }
            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                UserInput += "9";
                labelResponce.Text = UserInput;

            }
            else if (e.KeyCode == Keys.A)
            {
                UserInput += "A";
                labelResponce.Text = UserInput;

            }
            else if (e.KeyCode == Keys.B)
            {
                UserInput += "B";
                labelResponce.Text = UserInput;

            }
            else if (e.KeyCode == Keys.C)
            {
                UserInput += "C";
                labelResponce.Text = UserInput;

            }
            else if (e.KeyCode == Keys.D)
            {
                UserInput += "D";
                labelResponce.Text = UserInput;

            }
            else if (e.KeyCode == Keys.E)
            {
                UserInput += "E";
                labelResponce.Text = UserInput;

            }
            else if (e.KeyCode == Keys.F)
            {
                UserInput += "F";
                labelResponce.Text = UserInput;

            }
            else if (e.KeyCode == Keys.Back)
            {
                if (UserInput.Length > 0)
                {
                    UserInput = UserInput.Substring(0, UserInput.Length - 1);
                    labelResponce.Text = UserInput;
                }

            }
            else if (e.KeyCode == Keys.Delete)
            {
                UserInput = "";
                labelResponce.Text = UserInput;

            }

        }
    }
}
