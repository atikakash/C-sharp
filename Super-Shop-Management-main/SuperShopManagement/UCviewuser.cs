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
    
    public partial class UCviewuserpnl : UserControl
    {
        Functions fn = new Functions();
        DataSet ds = new DataSet();
        string Query;
        private DataAccess Da { get; set; }
        public UCviewuserpnl()
        {
            this.Da = new DataAccess();
            InitializeComponent();
        }

        private void UCviewuserpnl_Load(object sender, EventArgs e)
        {
            Query = "select * from Userinfo";
            DataSet ds = fn.getData(Query);
            vsmview.DataSource = ds.Tables [0];    
        }

        private void Useridtb_TextChanged(object sender, EventArgs e)
        {
            Query = "Select* from Userinfo where UserId like '"+Useridtb.Text+"%'";
            DataSet ds = fn.getData(Query);
            vsmview.DataSource = ds.Tables[0];


        }

        private void vsmview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.vsmview.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to remove the data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure to remove the data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var UserId = this.vsmview.CurrentRow.Cells[0].Value.ToString();
               var Name = this.vsmview.CurrentRow.Cells["Name"].Value.ToString();
                //MessageBox.Show(id+title);
                var query = "delete from Userinfo where UserId = '" + UserId + "';";
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

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            this.Useridtb.Clear();
        }
    }
}
