using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cong_hau_4_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(lb1_hau_4.Text);
            b = int.Parse(lb2_hau_4.Text);
            Caculation_hau_4 c = new Caculation_hau_4(a, b);
            ketqua = c.Execute("+");
            lb3_hau_4.Text = ketqua.ToString();
        }

        private void tru_hau_4_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(lb1_hau_4.Text);
            b = int.Parse(lb2_hau_4.Text);
            Caculation_hau_4 c = new Caculation_hau_4(a, b);
            ketqua = c.Execute("-");
            lb3_hau_4.Text = ketqua.ToString();
        }

        private void nhan_hau_4_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(lb1_hau_4.Text);
            b = int.Parse(lb2_hau_4.Text);
            Caculation_hau_4 c = new Caculation_hau_4(a, b);
            ketqua = c.Execute("*");
            lb3_hau_4.Text = ketqua.ToString();
        }

        private void chia_hau_4_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(lb1_hau_4.Text);
            b = int.Parse(lb2_hau_4.Text);
            Caculation_hau_4 c = new Caculation_hau_4(a, b);
            ketqua = c.Execute("/");
            lb3_hau_4.Text = ketqua.ToString();
        }

        private void close_hau_4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
