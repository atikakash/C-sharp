using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopManagement
{
    public partial class Salesman : Form
    {
        public Salesman()
        {
            InitializeComponent();
        }

        private void Salesman_Load(object sender, EventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login fm = new Login();
            fm.Show();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {

            pnladd ucs = new pnladd();
            panel2.Controls.Clear();
            this.panel2.Controls.Add(ucs);
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            Product VD = new Product();
            panel2.Controls.Clear();
            this.panel2.Controls.Add(VD);

        }

        private void sellbtn_Click(object sender, EventArgs e)
        {
            Sell sm = new Sell();
            panel2.Controls.Clear();
            this.panel2.Controls.Add(sm);
        }

        private void modifybtn_Click(object sender, EventArgs e)
        {
            Modsale modsale = new Modsale();
            panel2.Controls.Clear();
            this.panel2.Controls.Add(modsale);
        }
    }
}
