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
    public partial class UCAddsalesman : UserControl
    {
        Functions fn= new Functions();
        string Query;
        public UCAddsalesman()
        {
            InitializeComponent();
        }

        private void UCAddsalesman_Load(object sender, EventArgs e)
        {

        }

        

        private void Savebtn_Click(object sender, EventArgs e)
        {
            String UserID = Useridtb.Text;
            String role = Rolecbx.Text;
            String Name = Nametb.Text;
            String dob = dobtb.Text;
            String mobile = Mobiletb.Text;
            String Email = Emailtb.Text;
            String Pass = Passwordtb.Text;
            try
            {
                Query = "insert into Userinfo (UserId,Name,Role,DOB,Mobile,Password,Email)Values('"+UserID+"','"+Name+"','"+role+"','"+dob+"','"+mobile+"','"+Pass+"','"+Email+"')";
                fn.setData(Query, "Sign up Successful");
            }
            catch (Exception )
            { 
                MessageBox.Show("UserID Already taken.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            Useridtb.Clear();
            Rolecbx.ResetText();
            Nametb.Clear();
            Emailtb.Clear();
            Passwordtb.Clear();
            dobtb.ResetText();
            Mobiletb.Clear();

        }

        private void Useridtb_TextChanged(object sender, EventArgs e)
        {
            Query = "select* from Userinfo where UserId='"+Useridtb.Text+"'";
            DataSet ds = fn.getData(Query);
            if (ds.Tables[0].Rows.Count== 0 )
            {
                this.pictureBox2.ImageLocation = @"E:\The\yes.png";
            }
            else
            {
                this.pictureBox2.ImageLocation = @"E:\The\No.png";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
