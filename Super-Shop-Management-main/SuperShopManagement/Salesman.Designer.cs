namespace SuperShopManagement
{
    partial class Salesman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salesman));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.modifybtn = new System.Windows.Forms.Button();
            this.sellbtn = new System.Windows.Forms.Button();
            this.viewbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.modifybtn);
            this.panel1.Controls.Add(this.sellbtn);
            this.panel1.Controls.Add(this.viewbtn);
            this.panel1.Controls.Add(this.addbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 610);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // logoutbtn
            // 
            this.logoutbtn.Location = new System.Drawing.Point(99, 584);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(75, 23);
            this.logoutbtn.TabIndex = 5;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // modifybtn
            // 
            this.modifybtn.Location = new System.Drawing.Point(90, 349);
            this.modifybtn.Name = "modifybtn";
            this.modifybtn.Size = new System.Drawing.Size(97, 23);
            this.modifybtn.TabIndex = 4;
            this.modifybtn.Text = "Modify";
            this.modifybtn.UseVisualStyleBackColor = true;
            this.modifybtn.Click += new System.EventHandler(this.modifybtn_Click);
            // 
            // sellbtn
            // 
            this.sellbtn.Location = new System.Drawing.Point(90, 308);
            this.sellbtn.Name = "sellbtn";
            this.sellbtn.Size = new System.Drawing.Size(97, 23);
            this.sellbtn.TabIndex = 3;
            this.sellbtn.Text = "Sell";
            this.sellbtn.UseVisualStyleBackColor = true;
            this.sellbtn.Click += new System.EventHandler(this.sellbtn_Click);
            // 
            // viewbtn
            // 
            this.viewbtn.Location = new System.Drawing.Point(90, 269);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(97, 23);
            this.viewbtn.TabIndex = 2;
            this.viewbtn.Text = "View";
            this.viewbtn.UseVisualStyleBackColor = true;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(90, 231);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(97, 23);
            this.addbtn.TabIndex = 1;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salesman";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(304, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 610);
            this.panel2.TabIndex = 1;
            // 
            // Salesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 613);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Salesman";
            this.Text = "Salesman";
            this.Load += new System.EventHandler(this.Salesman_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Button modifybtn;
        private System.Windows.Forms.Button sellbtn;
        private System.Windows.Forms.Button viewbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}