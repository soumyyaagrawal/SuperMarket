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

namespace SuperMarket
{
    public partial class category : Form
    {
        DBconnect dbcon = new DBconnect();
        public category()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void category_Load(object sender, EventArgs e)
        {
            btnupdate.Visible = false;
            btndelete.Visible = false;
            lblcatid.Visible = false;
            label4.Visible = false;

            bindtxt();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtcatname.Text == String.Empty)
            {
                MessageBox.Show("Please enter your Category Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtcatname.Text == String.Empty)
                    txtcatname.Focus();
                return;
            }
            else if (txtcatdes.Text == String.Empty)
            {
                MessageBox.Show("Please enter Category Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcatdes.Focus();
                return;
            }
            else
            {
                dbcon.Opencon();
                SqlCommand cmd = new SqlCommand("select catname from tcategory where @catname =@catname ;", dbcon.Getcon());
                cmd.Parameters.AddWithValue("@catname", txtcatname.Text);
                //cmd.Parameters.AddWithValue("@catdesc", txtcatdes.Text);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("Category not available, enter new", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                cmd = new SqlCommand("insert into tcategory (catname, catdesc ) values(@catname, @catdesc)", dbcon.Getcon());
                cmd.Parameters.AddWithValue("@catname", txtcatname.Text);
                cmd.Parameters.AddWithValue("@catdesc", txtcatdes.Text);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Category added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindtxt();

                }
                dbcon.Closecon();

                

            }
        }
        private void cleartxt()
        {
            txtcatname.Clear();
            txtcatdes.Clear();
            lblcatid.Clear();
            

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblcatid.Text == String.Empty)
                {
                    MessageBox.Show("Please select category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                if (lblcatid.Text != String.Empty)
                {
                    if (DialogResult.Yes == MessageBox.Show("Do you want to Delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        dbcon.Opencon();
                        SqlCommand cmd = new SqlCommand("spcatdeletee", dbcon.Getcon());
                        cmd.Parameters.AddWithValue("@catid", int.Parse(lblcatid.Text));

                        cmd.CommandType = CommandType.StoredProcedure;
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Category Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cleartxt();
                            bindtxt();
                            btnadd.Visible = true;
                            btnupdate.Visible = false; btndelete.Visible = false;

                        } 
                        else
                        {
                            MessageBox.Show("Delete failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cleartxt
                                ();
                        }
                        dbcon.Closecon();
                    }
                }

            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
          
        private void bindtxt()
        {
            dbcon.Opencon();
            SqlCommand cmd = new SqlCommand("select * from tcategory ", dbcon.Getcon());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            btnupdate.Visible = true;
            btndelete.Visible = true;
            lblcatid.Visible = true;
            btnadd.Visible = false;
            label4.Visible = true;
            


            lblcatid.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtcatdes.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtcatname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (lblcatid.Text == String.Empty)
            {
                MessageBox.Show("Please select category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
                return;
            }
            if (txtcatname.Text == String.Empty)
            {
                MessageBox.Show("Please enter your Category Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtcatname.Text == String.Empty)
                    txtcatname.Focus();
                return;
            }
            else if (txtcatdes.Text == String.Empty)
            {
                MessageBox.Show("Please enter Category Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcatdes.Focus();
                return;
            }
            else
            {
                dbcon.Opencon();
                SqlCommand cmd = new SqlCommand("select catname from tcategory where catname = @catname  and CatID != @catid", dbcon.Getcon());
                cmd.Parameters.AddWithValue("@catname", txtcatname.Text);
                cmd.Parameters.AddWithValue("@catid", int.Parse(lblcatid.Text));
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("Category not available, enter new", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                cmd = new SqlCommand("spcatupdate", dbcon.Getcon());
                cmd.Parameters.AddWithValue("@catid", int.Parse(lblcatid.Text));
                cmd.Parameters.AddWithValue("@catname", txtcatname.Text);
                cmd.Parameters.AddWithValue("@catdesc", txtcatdes.Text);
                cmd.CommandType = CommandType.StoredProcedure;
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

        private void txtcatdes_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            cleartxt();
            dataGridView1.ClearSelection();
            lblcatid.Visible = false;
            label4.Visible = false;
            btnadd.Visible = true; btnupdate.Visible = false; btndelete.Visible = false;
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

        private void gtonext(object sender, KeyEventArgs e)
        {

        }
    } 
    
}
