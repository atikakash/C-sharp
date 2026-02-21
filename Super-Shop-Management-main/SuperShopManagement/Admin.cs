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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
       
        private void Addsalesmanbtn_Click(object sender, EventArgs e)
        {
             UCAddsalesman ucs = new UCAddsalesman();
            pnladdsales.Controls.Clear();
            this.pnladdsales.Controls.Add(ucs);
            // this.Addsalepnl.Visible = true;
            
           
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login fm = new Login();
            fm.Show();
        }

        private void Addsalepnl_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
           
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnladdsales_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void Viewsalesmanbtn_Click(object sender, EventArgs e)
        {
            UCviewuserpnl ucv = new UCviewuserpnl();
           pnladdsales.Controls.Clear();    
            this.pnladdsales.Controls.Add(ucv);
           
        }

        private void Admininfbtn_Click(object sender, EventArgs e)
        {
            AdminProfile adminProfile = new AdminProfile();
            pnladdsales.Controls.Clear();
            this.pnladdsales.Controls.Add(adminProfile);

        }

        private void showpbtn_Click(object sender, EventArgs e)
        {
            Product pn= new Product();
            pnladdsales.Controls.Clear();
            this.pnladdsales.Controls.Add(pn);

        }
    }
}
