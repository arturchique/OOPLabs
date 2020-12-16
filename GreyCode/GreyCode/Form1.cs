using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreyCode
{
    public partial class Form1 : Form
    {
        public ConditionsModel model;

        public Form1()
        {
            InitializeComponent();
            this.model = new ConditionsModel();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string sys_;
            if (this.radioButton2.Checked)
            {
                sys_ = "2";
                if (!ConditionsController.IsBinValid(this.textBox1.Text))
                {
                    this.textBox1.Text = "";
                    this.label1.Text = "Введите корректные данные";
                    return;
                }
            }
            else
            {
                sys_ = "10";
                if (!ConditionsController.IsNumValid(this.textBox1.Text))
                {
                    this.textBox1.Text = "";
                    this.label1.Text = "Введите корректные данные";
                    return;
                }
            }
            int num = int.Parse(this.textBox1.Text);

            ConditionsController.ConvertAndLoad(model, num, sys_);

            Controls.Clear();
            ConditionsController.xorController(model, this);            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(sender, e);
            }
        }
    }
}
