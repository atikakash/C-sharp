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
    public partial class Sell : UserControl
    {
        Functions fn = new Functions();
        String Query;
        DataSet ds = new DataSet();
        public Sell()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Sellm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Query = "select Mname from Product where Mname ='zidhro' ";
            ds=fn.getData (Query);
            for (int i = 0; i < ds.Tables[0].Rows.Count;i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            

        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            Sellm_Load(this,null);
            searchtb.Clear();
        }

        private void searchtb_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Query = "select Mname from Product where Mname like '" + searchtb.Text + "%'";
            ds = fn.getData(Query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nounit.Clear();
            String name= listBox1.GetItemText(listBox1.SelectedItem );
            mnametb.Text = name;
            Query = " select Mid,Edate,PerUnit from Product where mname='" + mnametb + "'";
            ds = fn.getData(Query);
            if (ds.Tables[0].Rows.Count != 0)
            {
            edatetb.Text = ds.Tables[0].Rows[0][5].ToString();
            }
            else
            {
                MessageBox.Show("Invalid Details");
            }
                
            

        }
    }
}
