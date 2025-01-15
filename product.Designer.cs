namespace SuperMarket
{
    partial class product
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
            this.txtprdid = new System.Windows.Forms.TextBox();
            this.cmbcat = new System.Windows.Forms.ComboBox();
            this.lblqt = new System.Windows.Forms.Label();
            this.txtqt = new System.Windows.Forms.TextBox();
            this.txtprc = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.lbladid = new System.Windows.Forms.Label();
            this.lblcat = new System.Windows.Forms.Label();
            this.lblprc = new System.Windows.Forms.Label();
            this.lblpdtnm = new System.Windows.Forms.Label();
            this.txtpdtam = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnsrch = new System.Windows.Forms.Button();
            this.cmbsrch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.SignIn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 52);
            this.panel1.TabIndex = 2;
            // 
            // SignIn
            // 
            this.SignIn.AutoSize = true;
            this.SignIn.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold);
            this.SignIn.ForeColor = System.Drawing.Color.Cornsilk;
            this.SignIn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SignIn.Location = new System.Drawing.Point(424, 9);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(133, 29);
            this.SignIn.TabIndex = 0;
            this.SignIn.Text = "Super Mart";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtprdid);
            this.groupBox1.Controls.Add(this.cmbcat);
            this.groupBox1.Controls.Add(this.lblqt);
            this.groupBox1.Controls.Add(this.txtqt);
            this.groupBox1.Controls.Add(this.txtprc);
            this.groupBox1.Controls.Add(this.Clear);
            this.groupBox1.Controls.Add(this.lbladid);
            this.groupBox1.Controls.Add(this.lblcat);
            this.groupBox1.Controls.Add(this.lblprc);
            this.groupBox1.Controls.Add(this.lblpdtnm);
            this.groupBox1.Controls.Add(this.txtpdtam);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(0, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 171);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Products";
            // 
            // txtprdid
            // 
            this.txtprdid.Location = new System.Drawing.Point(164, 0);
            this.txtprdid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtprdid.Name = "txtprdid";
            this.txtprdid.Size = new System.Drawing.Size(47, 29);
            this.txtprdid.TabIndex = 30;
            // 
            // cmbcat
            // 
            this.cmbcat.FormattingEnabled = true;
            this.cmbcat.Items.AddRange(new object[] {
            "Select"});
            this.cmbcat.Location = new System.Drawing.Point(243, 66);
            this.cmbcat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbcat.Name = "cmbcat";
            this.cmbcat.Size = new System.Drawing.Size(215, 30);
            this.cmbcat.TabIndex = 29;
            // 
            // lblqt
            // 
            this.lblqt.AutoSize = true;
            this.lblqt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblqt.Location = new System.Drawing.Point(742, 42);
            this.lblqt.Name = "lblqt";
            this.lblqt.Size = new System.Drawing.Size(76, 22);
            this.lblqt.TabIndex = 28;
            this.lblqt.Text = "Quantity";
            // 
            // txtqt
            // 
            this.txtqt.Location = new System.Drawing.Point(695, 66);
            this.txtqt.Name = "txtqt";
            this.txtqt.Size = new System.Drawing.Size(194, 29);
            this.txtqt.TabIndex = 25;
            // 
            // txtprc
            // 
            this.txtprc.Location = new System.Drawing.Point(485, 66);
            this.txtprc.Name = "txtprc";
            this.txtprc.Size = new System.Drawing.Size(183, 29);
            this.txtprc.TabIndex = 24;
            this.txtprc.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Clear
            // 
            this.Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Clear.Location = new System.Drawing.Point(378, 123);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(79, 29);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // lbladid
            // 
            this.lbladid.AutoSize = true;
            this.lbladid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbladid.Location = new System.Drawing.Point(19, 35);
            this.lbladid.Name = "lbladid";
            this.lbladid.Size = new System.Drawing.Size(0, 22);
            this.lbladid.TabIndex = 20;
            // 
            // lblcat
            // 
            this.lblcat.AutoSize = true;
            this.lblcat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblcat.Location = new System.Drawing.Point(304, 42);
            this.lblcat.Name = "lblcat";
            this.lblcat.Size = new System.Drawing.Size(79, 22);
            this.lblcat.TabIndex = 18;
            this.lblcat.Text = "Category";
            // 
            // lblprc
            // 
            this.lblprc.AutoSize = true;
            this.lblprc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblprc.Location = new System.Drawing.Point(545, 42);
            this.lblprc.Name = "lblprc";
            this.lblprc.Size = new System.Drawing.Size(47, 22);
            this.lblprc.TabIndex = 16;
            this.lblprc.Text = "Price";
            this.lblprc.Click += new System.EventHandler(this.lblpass_Click);
            // 
            // lblpdtnm
            // 
            this.lblpdtnm.AutoSize = true;
            this.lblpdtnm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblpdtnm.Location = new System.Drawing.Point(48, 42);
            this.lblpdtnm.Name = "lblpdtnm";
            this.lblpdtnm.Size = new System.Drawing.Size(121, 22);
            this.lblpdtnm.TabIndex = 11;
            this.lblpdtnm.Text = "Product Name";
            this.lblpdtnm.Click += new System.EventHandler(this.lbladlnam_Click);
            // 
            // txtpdtam
            // 
            this.txtpdtam.Location = new System.Drawing.Point(15, 66);
            this.txtpdtam.Name = "txtpdtam";
            this.txtpdtam.Size = new System.Drawing.Size(196, 29);
            this.txtpdtam.TabIndex = 0;
            // 
            // btnupdate
            // 
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnupdate.Location = new System.Drawing.Point(475, 123);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(78, 29);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnadd.Location = new System.Drawing.Point(282, 123);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(79, 29);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btndelete.Location = new System.Drawing.Point(571, 123);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(78, 29);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(939, 195);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.btnsrch);
            this.panel2.Controls.Add(this.cmbsrch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 222);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(943, 65);
            this.panel2.TabIndex = 8;
            // 
            // btnsrch
            // 
            this.btnsrch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsrch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnsrch.Location = new System.Drawing.Point(588, 16);
            this.btnsrch.Name = "btnsrch";
            this.btnsrch.Size = new System.Drawing.Size(79, 29);
            this.btnsrch.TabIndex = 30;
            this.btnsrch.Text = "Search";
            this.btnsrch.UseVisualStyleBackColor = true;
            this.btnsrch.Click += new System.EventHandler(this.btnsrch_Click);
            // 
            // cmbsrch
            // 
            this.cmbsrch.FormattingEnabled = true;
            this.cmbsrch.Location = new System.Drawing.Point(257, 18);
            this.cmbsrch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbsrch.Name = "cmbsrch";
            this.cmbsrch.Size = new System.Drawing.Size(312, 24);
            this.cmbsrch.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(174, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Search";
            // 
            // product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 484);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "product";
            this.Text = " ";
            this.Load += new System.EventHandler(this.product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SignIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label lbladid;
        private System.Windows.Forms.Label lblcat;
        private System.Windows.Forms.Label lblprc;
        private System.Windows.Forms.Label lblpdtnm;
        private System.Windows.Forms.TextBox txtpdtam;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txtqt;
        private System.Windows.Forms.TextBox txtprc;
        private System.Windows.Forms.Label lblqt;
        private System.Windows.Forms.ComboBox cmbcat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbsrch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsrch;
        private System.Windows.Forms.TextBox txtprdid;
    }
}