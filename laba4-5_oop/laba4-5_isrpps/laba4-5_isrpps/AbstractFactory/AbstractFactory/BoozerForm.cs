using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory
{
    public partial class BoozerForm : Form
    {
        public BoozerForm(AbstractHero hero)
        {
            InitializeComponent();
            this.label1.Text = hero.GetPowers();
        }
    }
}
