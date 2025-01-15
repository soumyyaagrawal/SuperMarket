//////using system;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//namespace SuperMarket
//{
//    public partial class Form2 : Form
        
//    {
//        DBconnect dbcon = new DBconnect();
//        public Form2()
//        {
//            InitializeComponent();
//        }
//        double total = 0;int n = 0;
//        private void label2_Click(object sender, EventArgs e)
//        {

//        }

//        private void Form2_Load(object sender, EventArgs e)
//        {
//            label2.Text = DateTime.Now.ToLongDateString();
//            bindcmbtxt();
//            gttl.Visible = false;
//        }

//        private void label3_Click(object sender, EventArgs e)
//        {

//        }

//        private void label1_Click(object sender, EventArgs e)
//        {


//        }

//        private void btnrf_Click(object sender, EventArgs e)
//        {

//        }

//        private void btnsrch_Click(object sender, EventArgs e)
//        {
//            dbcon.Opencon();
//            SqlCommand cmd = new SqlCommand("select * from tprdct where prdcat= @prdcat ", dbcon.Getcon());
//            cmd.Parameters.AddWithValue("@prdcat", box1.Text);


//            SqlDataAdapter adp = new SqlDataAdapter(cmd);
//            DataTable dt = new DataTable();
//            adp.Fill(dt);
//            dataGridView2.DataSource = dt;
//        }
//        private void bindcmbtxt()
//        {
//            dbcon.Opencon();
//            SqlCommand cmd = new SqlCommand("select catid, catname from tcategory order by catname asc ", dbcon.Getcon());
//            SqlDataAdapter adp = new SqlDataAdapter(cmd);
//            DataTable dt = new DataTable();
//            adp.Fill(dt);
//            box1.DataSource = dt;
//            box1.DisplayMember = "Catname";
//            //cmbcat.ValueMember = "Catid";
//            dataGridView1.ClearSelection();


//        }

//        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {
//            textBox1.Text = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[1].Value.ToString();
//            textBox2.Text = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[3].Value.ToString();
//            //textBox3.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
//            //txtqt.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
//            textBox3.Clear();
//            textBox3.Focus();
//        }

//        private void btnadodr_Click(object sender, EventArgs e)
//        {
//            if (textBox3.Text == "")
//            {
//                MessageBox.Show("Enter Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }
//            else
//            {
//                try
//                {
//                    double ttl = Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox2.Text);
//                    DataGridViewRow add = new DataGridViewRow();
//                    add.CreateCells(dataGridView1);
//                    //add.Cells[0].Value = ++n;
//                    add.Cells[0].Value = textBox1.Text;
//                    add.Cells[1].Value = textBox2.Text;
//                    add.Cells[2].Value = textBox3.Text;
//                    add.Cells[3].Value = ttl;
//                    dataGridView1.Rows.Add(add);
//                    total += ttl;
//                    gttl.Visible = true;
//                    gttl.Text = "Rs. " + total.ToString();
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }
//            }

//        }
//    }
//    } 

