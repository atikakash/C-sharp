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
    public partial class Modsale : UserControl
    {

        Functions fn = new Functions();
        DataSet ds = new DataSet();
        string Query;
        public Modsale()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void searchidtb_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            Query = "Select* from Product where ID = '" + searchidtb.Text + "'";
            DataSet ds = fn.getData(Query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                this.searchidtb.Text = ds.Tables[0].Rows[0][0].ToString();
                this.mnametb.Text = ds.Tables[0].Rows[0][2].ToString();
                this.mnumbertb.Text = ds.Tables[0].Rows[0][3].ToString();
                this.mdate.Text = ds.Tables[0].Rows[0][4].ToString();
                this.edate.Text = ds.Tables[0].Rows[0][5].ToString();
                this.aquantitytb.Text = ds.Tables[0].Rows[0][6].ToString();
                this.ppunittb.Text = ds.Tables[0].Rows[0][7].ToString();
            }
            else
            {
                MessageBox.Show("Invalid Productid");
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            String ID = searchidtb.Text;
            String Mname = mnametb.Text;
            String Mnumber = mnumbertb.Text;
            String Mdate = mdate.Text;
            String Edate = edate.Text;
            String Quantuty = aquantitytb.Text;
            String Ppunit = ppunittb.Text;
          
            Query = "update Product set Mname='" + Mname + "',Mnumber ='" + Mnumber + "',Mdate ='" + Mdate + "',Edate='" + Edate + "',Quantity='" + Quantuty + "',PerUnit='" + Ppunit + "'where ID = '"+ID+"'";
            fn.setData(Query, "Product Updation Successful.");
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            searchidtb.Clear();
            mnametb.Clear();
            mnumbertb.Clear();
            mdate.ResetText();
            edate.ResetText();
            aquantitytb.Clear();
            ppunittb.Clear();
        }
    }
}

    
    
