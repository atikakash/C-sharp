namespace SuperShopManagement
{
    partial class UCviewuserpnl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label13 = new System.Windows.Forms.Label();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.vsmview = new System.Windows.Forms.DataGridView();
            this.Useridtb = new System.Windows.Forms.TextBox();
            this.Useridlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Clearbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vsmview)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 24);
            this.label13.TabIndex = 21;
            this.label13.Text = "View Salesman";
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(769, 568);
            this.Deletebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(84, 26);
            this.Deletebtn.TabIndex = 28;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // vsmview
            // 
            this.vsmview.AllowUserToAddRows = false;
            this.vsmview.AllowUserToDeleteRows = false;
            this.vsmview.BackgroundColor = System.Drawing.Color.White;
            this.vsmview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vsmview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vsmview.Location = new System.Drawing.Point(0, 315);
            this.vsmview.Margin = new System.Windows.Forms.Padding(2);
            this.vsmview.Name = "vsmview";
            this.vsmview.ReadOnly = true;
            this.vsmview.RowHeadersWidth = 51;
            this.vsmview.RowTemplate.Height = 24;
            this.vsmview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vsmview.Size = new System.Drawing.Size(863, 240);
            this.vsmview.TabIndex = 27;
            this.vsmview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vsmview_CellClick);
            // 
            // Useridtb
            // 
            this.Useridtb.Location = new System.Drawing.Point(245, 167);
            this.Useridtb.Margin = new System.Windows.Forms.Padding(2);
            this.Useridtb.Multiline = true;
            this.Useridtb.Name = "Useridtb";
            this.Useridtb.Size = new System.Drawing.Size(319, 19);
            this.Useridtb.TabIndex = 26;
            this.Useridtb.TextChanged += new System.EventHandler(this.Useridtb_TextChanged);
            // 
            // Useridlbl
            // 
            this.Useridlbl.AutoSize = true;
            this.Useridlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Useridlbl.Location = new System.Drawing.Point(191, 170);
            this.Useridlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Useridlbl.Name = "Useridlbl";
            this.Useridlbl.Size = new System.Drawing.Size(50, 13);
            this.Useridlbl.TabIndex = 25;
            this.Useridlbl.Text = "User ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Search by userid";
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(581, 165);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(75, 23);
            this.Clearbtn.TabIndex = 30;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // UCviewuserpnl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.vsmview);
            this.Controls.Add(this.Useridtb);
            this.Controls.Add(this.Useridlbl);
            this.Controls.Add(this.label13);
            this.Name = "UCviewuserpnl";
            this.Size = new System.Drawing.Size(865, 610);
            this.Load += new System.EventHandler(this.UCviewuserpnl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vsmview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.DataGridView vsmview;
        private System.Windows.Forms.TextBox Useridtb;
        private System.Windows.Forms.Label Useridlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Clearbtn;
    }
}
