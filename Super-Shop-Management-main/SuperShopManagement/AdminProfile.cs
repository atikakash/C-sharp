using System;
using System.Collections;
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
    public partial class AdminProfile : UserControl
    {

           Functions fn = new Functions();
           DataSet ds = new DataSet();
           string Query;
        public AdminProfile()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Searchtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            Query = "Select* from Userinfo where UserId = '" + Searchtb.Text + "'";
            DataSet ds = fn.getData(Query);
            this.nametb.Text= ds.Tables[0].Rows[0][1].ToString();
            this.rolebox.Text= ds.Tables[0].Rows[0][2].ToString();
            this.dob1.Text= ds.Tables[0].Rows[0][3].ToString();
            this.mobiletb.Text= ds.Tables[0].Rows[0][4].ToString();
            this.emailtb.Text= ds.Tables[0].Rows[0][6].ToString();
            this.passwordtb.Text= ds.Tables[0].Rows[0][5].ToString();
          
            
        }

        
        private void resetbtn_Click(object sender, EventArgs e)
        {
            nametb.Clear();
            rolebox.ResetText();
            dob1.ResetText();
            mobiletb.ResetText();
            emailtb.ResetText();
            passwordtb.ResetText();
            Searchtb.Clear();

           
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            String Name = nametb.Text;
            String Role = rolebox.Text;
            String dob = dob1.Text;
            String Mobile=mobiletb.Text;
            String email = emailtb.Text;
            String password = passwordtb.Text;
            string UserId = Searchtb.Text;
            Query="update Userinfo set Name='" +Name+ "',Role ='"+Role+"',DOB ='"+dob+"',Mobile='"+Mobile+"',Email='"+email+"',Password='"+password+"'where UserId = '"+UserId+"'";
            fn.setData(Query, "Profile Updation Successful.");

        }
    }
}
