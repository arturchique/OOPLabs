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
    public partial class ConditionsView : Form
    {
        ConditionsModel model;
        public ConditionsView()
        {
            InitializeComponent();
        }

        public ConditionsView(ConditionsModel model)
        {
            InitializeComponent();
            this.model = model;
            this.label3.Text += $"{this.model.num}";
            this.label4.Text += $"{this.model.bin}";
            this.label5.Text += $"{this.model.binGrey}";
            this.label6.Text += $"{this.model.numGrey}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            this.Hide();
            form.Show();

        }

        private void ConditionsView_FormClosed(object sender, FormClosedEventArgs e)
        { 
            Application.Exit();
        }


        /* private ConditionsModel model = ConditionsModel()*/
    }
}
