using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class addnewseller : Form
    {
        DBconnect dbcon = new DBconnect();
        public addnewseller()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblselid.Visible = false;
            txtselid.Visible = false;
            btnupdate.Visible = false;
            btndelete.Visible = false;
            //txtselnam.Focus();
            bindtxt();   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtphn_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblselid.Text == String.Empty)
                {
                    MessageBox.Show("Please select seller", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                if (txtselnam.Text == String.Empty)
                {
                    MessageBox.Show("Please enter Seller Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtselnam.Focus();
                    return;
                }
                else if (txtphn.Text == String.Empty)
                {
                    MessageBox.Show("Please enter Phone ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtphn.Focus();
                    return;
                }
                else if (txtpass.Text == String.Empty)
                {
                    MessageBox.Show("Please enter your Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpass.Focus();
                    return;
                }
                else
                {
                    dbcon.Opencon();
                    SqlCommand cmd = new SqlCommand("select sellerPhone from tseller where sellerName = @sellerName  and sellerPhone= @sellerPhone", dbcon.Getcon());
                    cmd.Parameters.AddWithValue("@sellerName", txtselnam.Text);
                    cmd.Parameters.AddWithValue("@sellerPhone", int.Parse(txtphn.Text));
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show("User already Exists, enter new", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                     

                    cmd = new SqlCommand("update tseller set sellername=@sellerName, sellerAge=@sellerAge, sellerPhone=@sellerPhone, sellerPass=@sellerPass where sellerId=@sellerid ", dbcon.Getcon());
                    cmd.Parameters.AddWithValue("@sellerPhone", int.Parse(txtphn.Text));
                    cmd.Parameters.AddWithValue("@sellerName", txtselnam.Text);
                    cmd.Parameters.AddWithValue("@sellerAge", int.Parse(txtselag.Text));
                    cmd.Parameters.AddWithValue("@sellerPass", txtpass.Text);
                    cmd.Parameters.AddWithValue("@sellerid", txtselid.Text);
                        int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Category updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtselnam.Text == String.Empty)
            {
                MessageBox.Show("Please enter Seller Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                    txtselnam.Focus();
                return;
            }
            else if (txtphn.Text == String.Empty)
            {
                MessageBox.Show("Please enter Seller Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtphn.Focus();
                return;
            }
            else if (txtpass.Text == String.Empty)
            {
                MessageBox.Show("Please enter Your Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpass.Focus();
                return;
            }
          
            else
            {
                dbcon.Opencon();
                SqlCommand cmd = new SqlCommand("select sellerid from tseller where sellerphone= @sellerphone", dbcon.Getcon());
                cmd.Parameters.AddWithValue("@sellerphone", int.Parse(txtphn.Text));
                //cmd.Parameters.AddWithValue("@sellerPhone", txtphn.Text);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("User already Exists, enter new", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                cmd = new SqlCommand("insert into tseller ( sellername, sellerAge, sellerPhone, sellerPass ) values(@sellerName,@sellerAge,@sellerPhone,@sellerPass)", dbcon.Getcon());
                cmd.Parameters.AddWithValue("@sellerName", txtselnam.Text);
                cmd.Parameters.AddWithValue("@sellerAge", int.Parse(txtselag.Text));
                cmd.Parameters.AddWithValue("@sellerPhone", int.Parse(txtphn.Text));
                cmd.Parameters.AddWithValue("@sellerPass", txtpass.Text);
                //cmd.Parameters.AddWithValue("@sellerid", txtselid.Text);
                int j = cmd.ExecuteNonQuery();
                if (j > 0)
                {
                    MessageBox.Show("User added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleartxt();
                    bindtxt();


                }
                dbcon.Closecon();



            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        { if (txtselid.Text == string.Empty)
            {
                MessageBox.Show("Please Select Seller", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }
            else {
                if (DialogResult.Yes == MessageBox.Show("You sure want to Select", "Confiramtion", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    dbcon.Opencon();
                    SqlCommand cmd = new SqlCommand("Delete from tseller where sellerId= @sellerID", dbcon.Getcon());
                    cmd.Parameters.AddWithValue("@sellerid", txtselid.Text);
                    int i= cmd.ExecuteNonQuery();
                    if (i > 0) {
                        MessageBox.Show("Seller Deleted Successfully", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        MessageBox.Show("Delete failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cleartxt();

                    }


                }
            }


        }
        private void cleartxt()
        {
            txtselnam.Clear();
            txtselid.Clear();
            txtselag.Clear();
            txtphn.Clear();
            txtpass.Clear();

        }
        private void bindtxt()
        {
            dbcon.Opencon();
            SqlCommand cmd = new SqlCommand("select * from tseller ", dbcon.Getcon());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ClearSelection();
        }

        private void lblsellnam_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else { txtpass.UseSystemPasswordChar = true; }
        }

        

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            btnupdate.Visible = true;
            btndelete.Visible = true;
            lblselid.Visible = true;
            btnadd.Visible = false;
            txtselid.Visible = true;


            txtselid.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtselag.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtselnam.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtphn.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtpass.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            cleartxt();
            dataGridView1.ClearSelection();
            lblselid.Visible = false;
            txtselid.Visible = false;
            btnadd.Visible = true;
            btnupdate.Visible = false; 
            btndelete.Visible = false;

        }





        private void gotnext(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);

            }
        }
    }
}
