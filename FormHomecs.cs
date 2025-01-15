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
    public partial class FormHome : Form
    {
        DBconnect dbcon = new DBconnect();

        public FormHome()
        {
            InitializeComponent();

        }
        double total = 0; int n = 0;


        private void FormHome_Load(object sender, EventArgs e)
        {
            if(Login.Loginname!= null)
            {
                toolStripStatusLabel2.Text= Login.Loginname;
            }
            if(Login.logintype!= null && Login.logintype== "Salesman")
            {
                addUserToolStripMenuItem.Visible = false;
                categoryToolStripMenuItem.Visible = false;
            }
            label3.Text = DateTime.Now.ToLongDateString();
            bindcmbtxt();
            gttl.Visible = false;
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignIn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
              category ct = new category();
            ct.Show();
        }

        //private void formhome_formclosing(object sender, formclosingeventargs e)
        //{
        //    dialogresult dia = messagebox.show("do you want to close", "confirmation", messageboxbuttons.yesno, messageboxicon.question);
        //    if (dia == dialogresult.no)
        //    {
        //        e.cancel = true;
        //    }

        //}

        private void sellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addnewseller sell= new addnewseller();
            sell.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addadmin admin = new addadmin();

            admin.Show();


        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            product ap = new product();
            ap.Show();

        }

        
        private void btnsrch_Click(object sender, EventArgs e)
        {
           
        }
        private void bindcmbtxt()
        {
            dbcon.Opencon();
            SqlCommand cmd = new SqlCommand("select catid, catname from tcategory order by catname asc ", dbcon.Getcon());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            box1.DataSource = dt;
            box1.DisplayMember = "Catname";
            //cmbcat.ValueMember = "Catid";
            dataGridView1.ClearSelection();


        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[3].Value.ToString();
            //textBox3.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
            //txtqt.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
            textBox3.Clear();
            textBox3.Focus();
        }

        private void btnadodr_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsrch_Click_1(object sender, EventArgs e)
        {
            dbcon.Opencon();
            SqlCommand cmd = new SqlCommand("select * from tprdct where prdcat= @prdcat ", dbcon.Getcon());
            cmd.Parameters.AddWithValue("@prdcat", box1.Text);


            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void btnadodr_Click_1(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Enter Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    double ttl = Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox2.Text);
                    DataGridViewRow add = new DataGridViewRow();
                    add.CreateCells(dataGridView1);
                    //add.Cells[0].Value = ++n;
                    add.Cells[0].Value = textBox1.Text;
                    add.Cells[1].Value = textBox2.Text;
                    add.Cells[2].Value = textBox3.Text;
                    add.Cells[3].Value = ttl;
                    dataGridView1.Rows.Add(add);
                    total += ttl;
                    gttl.Visible = true;
                    gttl.Text = "Rs. " + total.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void box1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 1)
            { MessageBox.Show("Enter Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            else
            {
                dbcon.Opencon();

                SqlCommand cmd = new SqlCommand("insert into tbill  (sellerid, selldate, ttlamt ) values( @sellerid, @selldate, @ttlamt)", dbcon.Getcon());
                //cmd.Parameters.AddWithValue("@billid", txtbillno.Text);
                cmd.Parameters.AddWithValue("@sellerid", toolStripStatusLabel2.Text);
                cmd.Parameters.AddWithValue("@selldate", label3.Text);
                cmd.Parameters.AddWithValue("@ttlamt", Convert.ToDouble(total));
                int j = cmd.ExecuteNonQuery();
                if (j > 0)
                {
                    bindtxt();
                    MessageBox.Show("Bill added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleartxt();
                    gttl.Visible = false;
                    dataGridView1.Rows.Clear();



                }
                dbcon.Closecon();
            }
        }   
        private void cleartxt()
        {
          textBox1.Clear();
          textBox2.Clear();
          textBox3.Clear();
           

        }
        private void bindtxt()
        {
            dbcon.Opencon();
            SqlCommand cmd = new SqlCommand("select * from tbill order by billid desc  ", dbcon.Getcon());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView3.DataSource = dt;
            dbcon.Closecon();
        }

        private void txtbillno_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[3].Value.ToString();
            //textBox3.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
            //txtqt.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
            textBox3.Clear();
            textBox3.Focus();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            cleartxt();
            gttl.Visible = false;
            dataGridView1.Rows.Clear();



        }

        private void btnrf_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
        }
    }
}
