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
    public partial class pnladd : UserControl
    {
        Functions fn = new Functions();
        String Query;
        DataSet ds = new DataSet();


        public pnladd()
        {
            InitializeComponent();
        }

        private void medicineidtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)

        {
            if(productidtb.Text!="" && productnametb.Text!="" && productnumbertb.Text!="" && manudate.Text!="" && exdate.Text!="" && Quantitytb.Text!="" && Pricetb.Text!="")
            {
                string ID = productidtb.Text;
                String Productid = productidtb.Text;
                String Productname = productnametb.Text;
                String Productnumber = productnumbertb.Text;
                String Manudate = manudate.Text;
                String Expiredate = exdate.Text;
                Int64 Quantity = Int64.Parse(Quantitytb.Text);
                Int64 Price = Int64.Parse(Pricetb.Text);


                Query = "insert into Product (ID,Mid,Mname,Mnumber,Mdate,Edate,Quantity,PerUnit)Values('"+ID+"','" + Productid + "','" + Productname + "','" + Productnumber + "','" + Manudate + "','" + Expiredate + "','" + Quantity + "','" + Price + "')";
                fn.setData(Query, "Sign up Successful");
            }
            else 
            {
                MessageBox.Show("Id Already taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            productidtb.Clear();
            productidtb.Clear();
            productnametb.Clear();
            productnumbertb.Clear();
            manudate.ResetText();
            exdate.ResetText();
            Quantitytb.Clear();
            Pricetb.Clear();    
        }

        private void exdate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
