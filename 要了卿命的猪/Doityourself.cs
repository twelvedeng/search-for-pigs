using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 要了卿命的猪
{
    public partial class Doityourself : Form
    {
        PigStart Main;
        public Doityourself(PigStart aMain)
        {
            InitializeComponent();
            Main = aMain;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Doityourself_Load(object sender, EventArgs e)
        {
            NumericUpDowwidth.Value = Convert.ToDecimal(Main.nWidth);
            NumericUpDownheight.Value = Convert.ToDecimal(Main.nHeight);
            NumericUpDownnum.Value = Convert.ToDecimal(Main.nPignum);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Main.nWidth = Convert.ToInt32(NumericUpDowwidth.Value);
            Main.nHeight = Convert.ToInt32(NumericUpDownheight.Value);
            Main.nPignum = Convert.ToInt32(NumericUpDownnum.Value);
            this.Close();
        }
    }
}
