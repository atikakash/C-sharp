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
    
    public partial class Product : UserControl
        
    {
        Functions fn = new Functions();
        DataSet ds = new DataSet();
        string Query;
        private DataAccess Da { get; set; }
        public Product()
        {
            this.Da = new DataAccess();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Product_Load(object sender, EventArgs e)
        {
            Query = "select * from Product";
            DataSet ds = fn.getData(Query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void search_Click(object sender, EventArgs e)
        {
            Query = "Select* from Product where ID  = '" + searchtb.Text + "'";
            DataSet ds = fn.getData(Query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView1.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to remove the data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure to remove the data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var ID = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                var Name = this.dataGridView1.CurrentRow.Cells["Mname"].Value.ToString();
                //MessageBox.Show(id+title);
                var query = "delete from Product where ID = '" + ID + "';";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show(Name.ToUpper() + " has been removed from the list.");
                else
                    MessageBox.Show("data remove failed");


            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occured:\n" + exc.Message);
            }
        }

        private void searchtb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
