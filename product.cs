using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket {
    

    
    public partial class product : Form
        


        
    {
        DBconnect dbcon = new DBconnect();
        public product()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblpass_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbladlnam_Click(object sender, EventArgs e)
        {

        }

        private void product_Load(object sender, EventArgs e)
        {

            bindtxt();
            bindcmbtxt();
            
            txtprdid.Visible= false;
            bindcmbcat();
        }
        private void bindcmbtxt()
        {
            dbcon.Opencon();
            SqlCommand cmd = new SqlCommand("select catid, catname from tcategory order by catname asc ", dbcon.Getcon());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cmbcat.DataSource = dt;
            cmbcat.DisplayMember = "Catname";
            cmbcat. ValueMember = "Catid";
            dataGridView1.ClearSelection();


        }
        private void bindtxt()
        {
            dbcon.Opencon();
            SqlCommand cmd = new SqlCommand("select * from tprdct ", dbcon.Getcon());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtpdtam.Text == String.Empty)
            {
                MessageBox.Show("Please enter Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                 txtpdtam.Focus();
                return;
            }
            else if (txtprc.Text == String.Empty)
            {
                MessageBox.Show("Please enter Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtprc.Focus();
                return;
            }
            else if (txtqt.Text == String.Empty)
            {
                MessageBox.Show("Please enter Your Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtqt.Focus();
                return;
            }
            //else if (cmbcat.SelectedIndex == 0)
            //{
            //    MessageBox.Show("Please select category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtqt.Focus();
            //    return;
            //}

            else
            {
                dbcon.Opencon();
                SqlCommand cmd = new SqlCommand("select prdnam from tprdct where prdnam = @prdnam  and prdcat= @prdcat", dbcon.Getcon());
                cmd.Parameters.AddWithValue("@prdnam", txtpdtam.Text);
                cmd.Parameters.AddWithValue("@prdcat", cmbcat.Text);
                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    MessageBox.Show("Product already Exists, enter new", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                cmd = new SqlCommand("select catid from tcategory where catname = @catname ", dbcon.Getcon());
                cmd.Parameters.AddWithValue("@catname", cmbcat.Text);
                var catid = cmd.ExecuteScalar();
                //cmd = new SqlCommand("insert into tprdct (prdcatid ) values(@prdcatid)", dbcon.Getcon());
                //cmd.Parameters.AddWithValue("@prdcatid", catid);
                cmd = new SqlCommand("insert into tprdct (prdnam, prdcat, prdprc, prdqty,prdcatid ) values(@prdnam, @prdcat ,@prdprc,@prdqty, @prdcatid)", dbcon.Getcon());
                cmd.Parameters.AddWithValue("@prdnam", txtpdtam.Text);
                cmd.Parameters.AddWithValue("@prdcat", cmbcat.Text);
                cmd.Parameters.AddWithValue("@prdprc", int.Parse(txtprc.Text));
                cmd.Parameters.AddWithValue("@prdqty", int.Parse(txtqt.Text));
                cmd.Parameters.AddWithValue("@prdcatid", catid);

                







                int j = cmd.ExecuteNonQuery();
                if (j > 0)
                {
                    MessageBox.Show("Product added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleartxt();
                    bindtxt();


                }
                dbcon.Closecon();



            }


        }
        private void cleartxt()
        {
            txtprc.Clear();
            txtqt.Clear();
            txtpdtam.Clear();
            cmbcat.SelectedIndex = 0;
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnupdate.Visible = true;
            btndelete.Visible = true;
            //lblselid.Visible = true;
            btnadd.Visible = false;
            txtprdid.Visible = true;



            txtpdtam.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            cmbcat.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtprc.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtqt.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
            txtprdid.Text= dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtpdtam.Text == String.Empty)
            {
                MessageBox.Show("Please enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (txtqt.Text == String.Empty || Convert.ToInt32(txtqt.Text) < 0)
            {
                MessageBox.Show("Please enter your Product Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtqt.Text == String.Empty)
                    txtqt.Focus();
                return;
            }
            if (txtprc.Text == String.Empty && Convert.ToInt32(txtprc.Text) < 0)
            {
                MessageBox.Show("Please enter Product Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtprc.Focus();
                return;
            }
            else
            {
                dbcon.Opencon();
                SqlCommand cmd = new SqlCommand("select prdnam from tprdct where @prdnam= prdnam", dbcon.Getcon());
                cmd.Parameters.AddWithValue("@prdnam", txtpdtam.Text);
                //cmd.Parameters.AddWithValue("@catdesc", txtcatdes.Text);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("Category not available, enter new", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cmd = new SqlCommand("select catid from tcategory where catname = @catname ", dbcon.Getcon());
                cmd.Parameters.AddWithValue("@catname", cmbcat.Text);
                var catid = cmd.ExecuteScalar();
                cmd = new SqlCommand("update tprdct set prdnam=@prdnam, prdcat=@prdcat, prdcatid=@prdcatid, prdprc=@prdprc, @prdqty=prdqty where @prdid=prdid", dbcon.Getcon());
                cmd.Parameters.AddWithValue("@prdprc", txtprc.Text);
                cmd.Parameters.AddWithValue("@prdnam", txtpdtam.Text);
                cmd.Parameters.AddWithValue("@prdcat", cmbcat.Text);
                cmd.Parameters.AddWithValue("@prdqty", txtqt.Text);
                cmd.Parameters.AddWithValue("@prdid", txtprdid.Text);
                cmd.Parameters.AddWithValue("@prdcatid", catid);


                //cmd.CommandType = CommandType.StoredProcedure;
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Product updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleartxt();
                    bindtxt();
                    btnadd.Visible = true;
                    btnupdate.Visible = false; btndelete.Visible = false;

                }
                else
                {
                    MessageBox.Show("Update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dbcon.Closecon();
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtprdid.Text == string.Empty)
            {
                MessageBox.Show("Please Select Seller", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("You sure want to Select", "Confiramtion", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    dbcon.Opencon();
                    SqlCommand cmd = new SqlCommand("Delete from tprdct where prdid= @prdid", dbcon.Getcon());
                    cmd.Parameters.AddWithValue("@prdid", txtprdid.Text);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Product Deleted Successfully", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Delete failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cleartxt();

                    }


                }
            }

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            cleartxt();
            dataGridView1.ClearSelection();
            lbladid.Visible = false;
            txtprdid.Visible = false;
            btnadd.Visible = true;
            btnupdate.Visible = false; btndelete.Visible = false;
        }

        private void bindcmbcat()
        {
            dbcon.Opencon();
            SqlCommand cmd = new SqlCommand("select catid, catname from tcategory order by catname asc ", dbcon.Getcon());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cmbsrch.DataSource = dt;
            cmbsrch.DisplayMember = "Catname";
            //cmbsrch.ValueMember = "Catid";
            //dataGridView1.ClearSelection();


        }

        private void btnsrch_Click(object sender, EventArgs e)
        {
            dbcon.Opencon();
            SqlCommand cmd = new SqlCommand("select * from tprdct where prdcat= @prdcat ", dbcon.Getcon());
            cmd.Parameters.AddWithValue("@prdcat", cmbsrch.Text);


            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        
    }
    }

