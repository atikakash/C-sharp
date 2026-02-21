namespace SuperShopManagement
{
    partial class Admin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showpbtn = new System.Windows.Forms.Button();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.Admininfbtn = new System.Windows.Forms.Button();
            this.Viewsalesmanbtn = new System.Windows.Forms.Button();
            this.Addsalesmanbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnladdsales = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 612);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Administrator";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.showpbtn);
            this.panel2.Controls.Add(this.Logoutbtn);
            this.panel2.Controls.Add(this.Admininfbtn);
            this.panel2.Controls.Add(this.Viewsalesmanbtn);
            this.panel2.Controls.Add(this.Addsalesmanbtn);
            this.panel2.Location = new System.Drawing.Point(0, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 396);
            this.panel2.TabIndex = 1;
            // 
            // showpbtn
            // 
            this.showpbtn.Location = new System.Drawing.Point(92, 189);
            this.showpbtn.Name = "showpbtn";
            this.showpbtn.Size = new System.Drawing.Size(86, 25);
            this.showpbtn.TabIndex = 4;
            this.showpbtn.Text = "Show product";
            this.showpbtn.UseVisualStyleBackColor = true;
            this.showpbtn.Click += new System.EventHandler(this.showpbtn_Click);
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.Location = new System.Drawing.Point(92, 341);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(86, 23);
            this.Logoutbtn.TabIndex = 3;
            this.Logoutbtn.Text = "Logout";
            this.Logoutbtn.UseVisualStyleBackColor = true;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // Admininfbtn
            // 
            this.Admininfbtn.Location = new System.Drawing.Point(92, 145);
            this.Admininfbtn.Name = "Admininfbtn";
            this.Admininfbtn.Size = new System.Drawing.Size(86, 25);
            this.Admininfbtn.TabIndex = 2;
            this.Admininfbtn.Text = "Update info";
            this.Admininfbtn.UseVisualStyleBackColor = true;
            this.Admininfbtn.Click += new System.EventHandler(this.Admininfbtn_Click);
            // 
            // Viewsalesmanbtn
            // 
            this.Viewsalesmanbtn.Location = new System.Drawing.Point(92, 93);
            this.Viewsalesmanbtn.Name = "Viewsalesmanbtn";
            this.Viewsalesmanbtn.Size = new System.Drawing.Size(86, 32);
            this.Viewsalesmanbtn.TabIndex = 1;
            this.Viewsalesmanbtn.Text = "View Users";
            this.Viewsalesmanbtn.UseVisualStyleBackColor = true;
            this.Viewsalesmanbtn.Click += new System.EventHandler(this.Viewsalesmanbtn_Click);
            // 
            // Addsalesmanbtn
            // 
            this.Addsalesmanbtn.Location = new System.Drawing.Point(92, 49);
            this.Addsalesmanbtn.Name = "Addsalesmanbtn";
            this.Addsalesmanbtn.Size = new System.Drawing.Size(86, 23);
            this.Addsalesmanbtn.TabIndex = 0;
            this.Addsalesmanbtn.Text = "Add Users";
            this.Addsalesmanbtn.UseVisualStyleBackColor = true;
            this.Addsalesmanbtn.Click += new System.EventHandler(this.Addsalesmanbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnladdsales
            // 
            this.pnladdsales.BackColor = System.Drawing.SystemColors.Window;
            this.pnladdsales.Location = new System.Drawing.Point(301, 0);
            this.pnladdsales.Name = "pnladdsales";
            this.pnladdsales.Size = new System.Drawing.Size(834, 610);
            this.pnladdsales.TabIndex = 1;
            this.pnladdsales.Paint += new System.Windows.Forms.PaintEventHandler(this.pnladdsales_Paint);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.pnladdsales);
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.Button Admininfbtn;
        private System.Windows.Forms.Button Viewsalesmanbtn;
        private System.Windows.Forms.Button Addsalesmanbtn;
        private System.Windows.Forms.Panel pnladdsales;
        private System.Windows.Forms.Button showpbtn;
    }
}