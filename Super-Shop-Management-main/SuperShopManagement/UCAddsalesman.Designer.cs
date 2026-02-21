namespace SuperShopManagement
{
    partial class UCAddsalesman
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
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dobtb = new System.Windows.Forms.DateTimePicker();
            this.Passwordtb = new System.Windows.Forms.TextBox();
            this.Mobiletb = new System.Windows.Forms.TextBox();
            this.Useridtb = new System.Windows.Forms.TextBox();
            this.Rolecbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Useridlbl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.Emailtb = new System.Windows.Forms.TextBox();
            this.Nametb = new System.Windows.Forms.TextBox();
            this.Namelbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Clearbtn
            // 
            this.Clearbtn.ForeColor = System.Drawing.Color.Black;
            this.Clearbtn.Location = new System.Drawing.Point(418, 523);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(75, 23);
            this.Clearbtn.TabIndex = 32;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.ForeColor = System.Drawing.Color.Black;
            this.Savebtn.Location = new System.Drawing.Point(318, 523);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 31;
            this.Savebtn.Text = "Sign up";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(669, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 386);
            this.panel1.TabIndex = 30;
            // 
            // dobtb
            // 
            this.dobtb.Location = new System.Drawing.Point(318, 379);
            this.dobtb.Name = "dobtb";
            this.dobtb.Size = new System.Drawing.Size(200, 20);
            this.dobtb.TabIndex = 29;
            // 
            // Passwordtb
            // 
            this.Passwordtb.Location = new System.Drawing.Point(318, 287);
            this.Passwordtb.Name = "Passwordtb";
            this.Passwordtb.Size = new System.Drawing.Size(175, 20);
            this.Passwordtb.TabIndex = 28;
            // 
            // Mobiletb
            // 
            this.Mobiletb.Location = new System.Drawing.Point(318, 422);
            this.Mobiletb.Name = "Mobiletb";
            this.Mobiletb.Size = new System.Drawing.Size(175, 20);
            this.Mobiletb.TabIndex = 27;
            // 
            // Useridtb
            // 
            this.Useridtb.Location = new System.Drawing.Point(318, 212);
            this.Useridtb.Name = "Useridtb";
            this.Useridtb.Size = new System.Drawing.Size(175, 20);
            this.Useridtb.TabIndex = 26;
            this.Useridtb.TextChanged += new System.EventHandler(this.Useridtb_TextChanged);
            // 
            // Rolecbx
            // 
            this.Rolecbx.FormattingEnabled = true;
            this.Rolecbx.Items.AddRange(new object[] {
            "Admin",
            "Salesman"});
            this.Rolecbx.Location = new System.Drawing.Point(318, 333);
            this.Rolecbx.Name = "Rolecbx";
            this.Rolecbx.Size = new System.Drawing.Size(175, 21);
            this.Rolecbx.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mobile ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(194, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(194, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Date Of Birth";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(194, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Role";
            // 
            // Useridlbl
            // 
            this.Useridlbl.AutoSize = true;
            this.Useridlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Useridlbl.Location = new System.Drawing.Point(194, 210);
            this.Useridlbl.Name = "Useridlbl";
            this.Useridlbl.Size = new System.Drawing.Size(66, 20);
            this.Useridlbl.TabIndex = 20;
            this.Useridlbl.Text = "UserID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(195, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 24);
            this.label13.TabIndex = 19;
            this.label13.Text = "Add User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Email";
            // 
            // Emailtb
            // 
            this.Emailtb.Location = new System.Drawing.Point(318, 464);
            this.Emailtb.Name = "Emailtb";
            this.Emailtb.Size = new System.Drawing.Size(175, 20);
            this.Emailtb.TabIndex = 37;
            // 
            // Nametb
            // 
            this.Nametb.Location = new System.Drawing.Point(318, 251);
            this.Nametb.Name = "Nametb";
            this.Nametb.Size = new System.Drawing.Size(175, 20);
            this.Nametb.TabIndex = 38;
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.Location = new System.Drawing.Point(195, 251);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(55, 20);
            this.Namelbl.TabIndex = 39;
            this.Namelbl.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 565);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "*Double check user role before signup*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SuperShopManagement.Properties.Resources.Adduserlogo;
            this.pictureBox1.Location = new System.Drawing.Point(354, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(499, 210);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 27);
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // UCAddsalesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.Nametb);
            this.Controls.Add(this.Emailtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dobtb);
            this.Controls.Add(this.Passwordtb);
            this.Controls.Add(this.Mobiletb);
            this.Controls.Add(this.Useridtb);
            this.Controls.Add(this.Rolecbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Useridlbl);
            this.Controls.Add(this.label13);
            this.Name = "UCAddsalesman";
            this.Size = new System.Drawing.Size(834, 610);
            this.Load += new System.EventHandler(this.UCAddsalesman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dobtb;
        private System.Windows.Forms.TextBox Passwordtb;
        private System.Windows.Forms.TextBox Mobiletb;
        private System.Windows.Forms.TextBox Useridtb;
        private System.Windows.Forms.ComboBox Rolecbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Useridlbl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Emailtb;
        private System.Windows.Forms.TextBox Nametb;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
