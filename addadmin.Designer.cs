namespace SuperMarket
{
    partial class addadmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SignIn = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Clear = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtadid = new System.Windows.Forms.TextBox();
            this.lbladid = new System.Windows.Forms.Label();
            this.txtadphn = new System.Windows.Forms.TextBox();
            this.lblphn = new System.Windows.Forms.Label();
            this.txtadpas = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.lbladlnam = new System.Windows.Forms.Label();
            this.txtadnam = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.SignIn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 65);
            this.panel1.TabIndex = 1;
            // 
            // SignIn
            // 
            this.SignIn.AutoSize = true;
            this.SignIn.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold);
            this.SignIn.ForeColor = System.Drawing.Color.Cornsilk;
            this.SignIn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SignIn.Location = new System.Drawing.Point(477, 11);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(163, 35);
            this.SignIn.TabIndex = 0;
            this.SignIn.Text = "Super Mart";
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.Clear);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.txtadid);
            this.groupBox1.Controls.Add(this.lbladid);
            this.groupBox1.Controls.Add(this.txtadphn);
            this.groupBox1.Controls.Add(this.lblphn);
            this.groupBox1.Controls.Add(this.txtadpas);
            this.groupBox1.Controls.Add(this.lblpass);
            this.groupBox1.Controls.Add(this.lbladlnam);
            this.groupBox1.Controls.Add(this.txtadnam);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(0, 72);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(519, 480);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Admin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Clear
            // 
            this.Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Clear.Location = new System.Drawing.Point(143, 431);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(89, 36);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox1.Location = new System.Drawing.Point(194, 299);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(181, 30);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtadid
            // 
            this.txtadid.Location = new System.Drawing.Point(194, 35);
            this.txtadid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtadid.Name = "txtadid";
            this.txtadid.Size = new System.Drawing.Size(256, 33);
            this.txtadid.TabIndex = 21;
            // 
            // lbladid
            // 
            this.lbladid.AutoSize = true;
            this.lbladid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbladid.Location = new System.Drawing.Point(21, 44);
            this.lbladid.Name = "lbladid";
            this.lbladid.Size = new System.Drawing.Size(100, 26);
            this.lbladid.TabIndex = 20;
            this.lbladid.Text = "Admin ID";
            // 
            // txtadphn
            // 
            this.txtadphn.Location = new System.Drawing.Point(194, 158);
            this.txtadphn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtadphn.Name = "txtadphn";
            this.txtadphn.Size = new System.Drawing.Size(256, 33);
            this.txtadphn.TabIndex = 1;
            // 
            // lblphn
            // 
            this.lblphn.AutoSize = true;
            this.lblphn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblphn.Location = new System.Drawing.Point(21, 166);
            this.lblphn.Name = "lblphn";
            this.lblphn.Size = new System.Drawing.Size(77, 26);
            this.lblphn.TabIndex = 18;
            this.lblphn.Text = "Phone ";
            // 
            // txtadpas
            // 
            this.txtadpas.Location = new System.Drawing.Point(194, 224);
            this.txtadpas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtadpas.Name = "txtadpas";
            this.txtadpas.Size = new System.Drawing.Size(256, 33);
            this.txtadpas.TabIndex = 2;
            this.txtadpas.UseSystemPasswordChar = true;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblpass.Location = new System.Drawing.Point(21, 232);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(99, 26);
            this.lblpass.TabIndex = 16;
            this.lblpass.Text = "Password";
            this.lblpass.Click += new System.EventHandler(this.lblpass_Click);
            // 
            // lbladlnam
            // 
            this.lbladlnam.AutoSize = true;
            this.lbladlnam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbladlnam.Location = new System.Drawing.Point(14, 102);
            this.lbladlnam.Name = "lbladlnam";
            this.lbladlnam.Size = new System.Drawing.Size(135, 26);
            this.lbladlnam.TabIndex = 11;
            this.lbladlnam.Text = "Admin Name";
            // 
            // txtadnam
            // 
            this.txtadnam.Location = new System.Drawing.Point(194, 94);
            this.txtadnam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtadnam.Name = "txtadnam";
            this.txtadnam.Size = new System.Drawing.Size(256, 33);
            this.txtadnam.TabIndex = 0;
            // 
            // btnupdate
            // 
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnupdate.Location = new System.Drawing.Point(255, 431);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(88, 36);
            this.btnupdate.TabIndex = 6;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click_1);
            // 
            // btnadd
            // 
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnadd.Location = new System.Drawing.Point(26, 431);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(89, 36);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // btndelete
            // 
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btndelete.Location = new System.Drawing.Point(362, 431);
            this.btndelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(88, 36);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(515, 72);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(629, 480);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // addadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "addadmin";
            this.Text = "Add Admin";
            this.Load += new System.EventHandler(this.addadmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SignIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtadid;
        private System.Windows.Forms.Label lbladid;
        private System.Windows.Forms.TextBox txtadphn;
        private System.Windows.Forms.Label lblphn;
        private System.Windows.Forms.TextBox txtadpas;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lbladlnam;
        private System.Windows.Forms.TextBox txtadnam;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}