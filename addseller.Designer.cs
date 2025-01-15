namespace SuperMarket
{
    partial class addnewseller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addnewseller));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SignIn = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Clear = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtselid = new System.Windows.Forms.TextBox();
            this.lblselid = new System.Windows.Forms.Label();
            this.txtphn = new System.Windows.Forms.TextBox();
            this.lblphn = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblsellnam = new System.Windows.Forms.Label();
            this.txtselnam = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.txtselag = new System.Windows.Forms.TextBox();
            this.lblsellag = new System.Windows.Forms.Label();
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
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SignIn
            // 
            resources.ApplyResources(this.SignIn, "SignIn");
            this.SignIn.ForeColor = System.Drawing.Color.Cornsilk;
            this.SignIn.Name = "SignIn";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.Clear);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.txtselid);
            this.groupBox1.Controls.Add(this.lblselid);
            this.groupBox1.Controls.Add(this.txtphn);
            this.groupBox1.Controls.Add(this.lblphn);
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Controls.Add(this.lblpass);
            this.groupBox1.Controls.Add(this.lblsellnam);
            this.groupBox1.Controls.Add(this.txtselnam);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.txtselag);
            this.groupBox1.Controls.Add(this.lblsellag);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Clear
            // 
            resources.ApplyResources(this.Clear, "Clear");
            this.Clear.Name = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            this.Clear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gotnext);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gotnext);
            // 
            // txtselid
            // 
            resources.ApplyResources(this.txtselid, "txtselid");
            this.txtselid.Name = "txtselid";
            // 
            // lblselid
            // 
            resources.ApplyResources(this.lblselid, "lblselid");
            this.lblselid.Name = "lblselid";
            // 
            // txtphn
            // 
            resources.ApplyResources(this.txtphn, "txtphn");
            this.txtphn.Name = "txtphn";
            this.txtphn.TextChanged += new System.EventHandler(this.txtphn_TextChanged);
            this.txtphn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gotnext);
            // 
            // lblphn
            // 
            resources.ApplyResources(this.lblphn, "lblphn");
            this.lblphn.Name = "lblphn";
            // 
            // txtpass
            // 
            resources.ApplyResources(this.txtpass, "txtpass");
            this.txtpass.Name = "txtpass";
            this.txtpass.UseSystemPasswordChar = true;
            this.txtpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gotnext);
            // 
            // lblpass
            // 
            resources.ApplyResources(this.lblpass, "lblpass");
            this.lblpass.Name = "lblpass";
            this.lblpass.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblsellnam
            // 
            resources.ApplyResources(this.lblsellnam, "lblsellnam");
            this.lblsellnam.Name = "lblsellnam";
            this.lblsellnam.Click += new System.EventHandler(this.lblsellnam_Click);
            // 
            // txtselnam
            // 
            resources.ApplyResources(this.txtselnam, "txtselnam");
            this.txtselnam.Name = "txtselnam";
            this.txtselnam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gotnext);
            // 
            // btnupdate
            // 
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnupdate, "btnupdate");
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            this.btnupdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gotnext);
            // 
            // btnadd
            // 
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnadd, "btnadd");
            this.btnadd.Name = "btnadd";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            this.btnadd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gotnext);
            // 
            // btndelete
            // 
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btndelete, "btndelete");
            this.btndelete.Name = "btndelete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtselag
            // 
            resources.ApplyResources(this.txtselag, "txtselag");
            this.txtselag.Name = "txtselag";
            this.txtselag.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gotnext);
            // 
            // lblsellag
            // 
            resources.ApplyResources(this.lblsellag, "lblsellag");
            this.lblsellag.Name = "lblsellag";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // addnewseller
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "addnewseller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gotnext);
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
        private System.Windows.Forms.Label lblsellnam;
        private System.Windows.Forms.TextBox txtselnam;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txtselag;
        private System.Windows.Forms.Label lblsellag;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtphn;
        private System.Windows.Forms.Label lblphn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtselid;
        private System.Windows.Forms.Label lblselid;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Clear;
    }
}