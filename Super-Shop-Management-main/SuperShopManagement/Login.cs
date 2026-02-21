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
    public partial class Login : Form
    {
        Functions fn = new Functions();
        string Query;
        DataSet ds;
        public Login()
        {
            InitializeComponent();
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            this.UserIDtb.Clear();
            this.Passwordtb.Clear();
        }

        private void UserIDtb_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
          
                Query = "select * from Userinfo where UserId ='" + this.UserIDtb.Text + "'and Password='" +this. Passwordtb.Text + "'";
                ds = fn.getData(Query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                string role = ds.Tables[0].Rows[0][2].ToString();
                if (role == "Admin")
                {
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                }
                else if (role =="Salesman")
                {
                    Salesman sm = new Salesman();
                    sm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid Userid or Password");
            }
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {

        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void UserIdlbl_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
