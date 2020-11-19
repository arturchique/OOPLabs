using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2_isrpps
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        float a, b;
        char operation;
        bool sign = true;
        char[] keys = { (char)Keys.D0, (char)Keys.D1, (char)Keys.D2, (char)Keys.D3, (char)Keys.D4, (char)Keys.D5, (char)Keys.D6, (char)Keys.D7, (char)Keys.D8, (char)Keys.D9, (char)Keys.Oemcomma, (char)Keys.OemPeriod, (char)Keys.Back, (char)Keys.Left, (char)Keys.Right };

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            sign = true;
            label1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            operation = '+';
            label1.Text = a.ToString() + " + ";
            sign = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button19.Text = "";
                label2.Hide();
                numericUpDown1.Value = 0;
                numericUpDown1.Hide();
            }
            else
            {
                button19.Text = ".";
                label2.Show();
                numericUpDown1.Show();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
            else if (Array.Exists(keys, element => element == e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            operation = '-';
            label1.Text = a.ToString() + " - ";
            sign = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            operation = '*';
            label1.Text = a.ToString() + " * ";
            sign = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            operation = '/';
            label1.Text = a.ToString() + " / ";
            sign = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            b = calculate(a);
            b = (float)Math.Round((double)b, (int)numericUpDown1.Value);
            textBox1.Text = b.ToString();
            label1.Text = "";
        }

        public float calculate(float a)
        {
            switch (operation)
            {
                case '+':
                    b = a + float.Parse(textBox1.Text);
                    return b;
                case '-':
                    b = a - float.Parse(textBox1.Text);
                    return b;
                case '*':
                    b = a * float.Parse(textBox1.Text);
                    return b;
                case '/':
                    b = a  / float.Parse(textBox1.Text);
                    return b;
                default:
                    return 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(comboBox1.SelectedItem.ToString(), 8);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                             Это калькулятор!!!!!!!!                        ");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Надо вводить циферки и нажимать на знаки, тогда калькулятор будет калькуляторить!!!");
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text = textBox1.Text + "";
            }
            else
            {
                if (!textBox1.Text.Contains(",") && !(textBox1.Text == ""))
                {
                    textBox1.Text = textBox1.Text + ",";
                }
            }
        }
    }
}
