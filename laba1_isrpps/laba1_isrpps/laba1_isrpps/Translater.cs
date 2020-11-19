using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1_isrpps
{
    public partial class Translater : Form
    {
        public Translater()
        {
            InitializeComponent();
        }

        private void InputTextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void SubmitInputButton_Click(object sender, EventArgs e)
        {
            try
            {
                string RusKey = "Ё!\"№;%:?*()_+ЙЦУКЕНГШЩЗХЪ/ФЫВАПРОЛДЖЭЯЧСМИТЬБЮ,ё1234567890-=йцукенгшщзхъ\\фывапролджэячсмитьбю. ";
                string EngKey = "~!@#$%^&*()_+QWERTYUIOP{}|ASDFGHJKL:\"ZXCVBNM<>?`1234567890-=qwertyuiop[]\\asdfghjkl;'zxcvbnm,./ ";


                string Text = InputTextBox.Text;
                string OutputText = "";

                for (int i = 0; i < Text.Length; i++)
                {
                    try
                    {
                        OutputText += EngKey.Substring(RusKey.IndexOf(Text[i]), 1);
                    }
                    catch
                    {
                        OutputText += RusKey.Substring(EngKey.IndexOf(Text[i]), 1);
                    }
                }


                OutputTextBox.Clear();
                OutputTextBox.AppendText(OutputText);
                MessageBox.Show("Успешно переведено                                                  ");
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так                                                      ");
            }
        }

        private void InputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SubmitInputButton_Click(sender, e);
            }
        }
    }
}
