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

using System.Net;
using System.Collections.Specialized;
using System.IO;

namespace SuperMarket
{
    public partial class addadmin : Form
    {
        DBconnect dbcon = new DBconnect();
        public addadmin()
        {
            InitializeComponent();
        }

        private void addadmin_Load(object sender, EventArgs e)
        {
            lbladid.Visible = false;
            txtadid.Visible = false;
            btnupdate.Visible = false;
            btndelete.Visible = false;
            //txtadnam.Focus();
            bindtxt();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblpass_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtadpas.UseSystemPasswordChar = false;
            }
            else { txtadpas.UseSystemPasswordChar = true; }
        }
        private void bindtxt()
        {
            dbcon.Opencon();
            SqlCommand cmd = new SqlCommand("select * from tadmin ", dbcon.Getcon());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ClearSelection();
        }
        



        private void cleartxt()
        {
            txtadnam.Clear();
            txtadid.Clear();
            txtadphn.Clear();
            txtadpas.Clear();


        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            if (txtadnam.Text == String.Empty)
            {
                MessageBox.Show("Please enter Admin Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtadnam.Focus();
                return;
            }
            else if (txtadphn.Text == String.Empty)
            {
                MessageBox.Show("Please enter Admin Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtadphn.Focus();
                return;
            }
            else if (txtadpas.Text == String.Empty)
            {
                MessageBox.Show("Please enter Your Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtadpas.Focus();
                return;
            }

            else
            {
                dbcon.Opencon();
                SqlCommand cmd = new SqlCommand("select fullname from tadmin where fullname= @fullname", dbcon.Getcon());
                cmd.Parameters.AddWithValue("@fullname", txtadnam.Text);
                //cmd.Parameters.AddWithValue("@adphn", txtadphn.Text);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("User already Exists, enter new", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                cmd = new SqlCommand("insert into tadmin (fullname, adphn, adminPassword ) values(@fullname,@adphn,@adminPassword)", dbcon.Getcon());
                cmd.Parameters.AddWithValue("@fullname", txtadnam.Text);
                cmd.Parameters.AddWithValue("@adphn", int.Parse(txtadphn.Text));
                cmd.Parameters.AddWithValue("@adminPassword", txtadpas.Text);
                //cmd.Parameters.AddWithValue("@adminid", txtadid.Text);
               

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

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (lbladid.Text == String.Empty)
                {
                    MessageBox.Show("Please select admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                if (txtadnam.Text == String.Empty)
                {
                    MessageBox.Show("Please enter admin Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtadnam.Focus();
                    return;
                }
                else if (txtadphn.Text == String.Empty)
                {
                    MessageBox.Show("Please enter Phone ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtadphn.Focus();
                    return;
                }
                else if (txtadpas.Text == String.Empty)
                {
                    MessageBox.Show("Please enter your Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtadpas.Focus();
                    return;
                }
                else
                {
                    dbcon.Opencon();
                    SqlCommand cmd = new SqlCommand("select adminid from tadmin where fullname = @fullname  and adminid= @adminid", dbcon.Getcon());
                    cmd.Parameters.AddWithValue("@fullname", txtadnam.Text);
                    cmd.Parameters.AddWithValue("@adminid", int.Parse(txtadid.Text));
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show("User already Exists, enter new", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    cmd = new SqlCommand("update tadmin set fullname=@fullname, adphn=@adphn, adminPassword=@adminPassword where adminId=@adminid ", dbcon.Getcon());
                    cmd.Parameters.AddWithValue("@adphn", int.Parse(txtadphn.Text));
                    cmd.Parameters.AddWithValue("@fullName", txtadnam.Text);
                    cmd.Parameters.AddWithValue("@adminPassword", txtadpas.Text);
                    cmd.Parameters.AddWithValue("@adminid", txtadid.Text);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Admin updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            if (txtadid.Text == string.Empty)
            {
                MessageBox.Show("Please Select Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("You sure want to Select", "Confiramtion", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    dbcon.Opencon();
                    SqlCommand cmd = new SqlCommand("Delete from tadmin where adminid= @adminid", dbcon.Getcon());
                    cmd.Parameters.AddWithValue("@adminid", txtadid.Text);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Admin Deleted Successfully", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Delete failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cleartxt();

                    }


                }
            }

        }

        private void Clear_Click_1(object sender, EventArgs e)
        {
            cleartxt();
            dataGridView1.ClearSelection();
            lbladid.Visible = false;
            txtadid.Visible = false;
            btnadd.Visible = true;
            btnupdate.Visible = false; btndelete.Visible = false;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            btnupdate.Visible = true;
            btndelete.Visible = true;
            lbladid.Visible = false;
            btnadd.Visible = false;
            txtadid.Visible = false;


            txtadid.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtadnam.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtadphn.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtadpas.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();

        }

        private void SignIn_Click(object sender, EventArgs e)
        {

        }
    }
}
