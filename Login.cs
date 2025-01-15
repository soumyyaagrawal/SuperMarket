using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class Login : Form
    {
        DBconnect dbcon = new DBconnect();

        public static string Loginname, logintype;

        public Login()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            txtrole.SelectedIndex = 1;
            txtpassword.Text = "hey";
            txtusername.Text = "so11";




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                {
                    if (txtusername.Text == String.Empty)
                    {
                        MessageBox.Show("Please enter your Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtusername.Focus();
                        return;
                    }

                    if (txtpassword.Text == String.Empty)
                    {
                        MessageBox.Show("Please enter your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtpassword.Focus();
                        return;
                    }
                    if (txtrole.SelectedIndex == 0)
                    {
                        MessageBox.Show("Please select Valid Role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }

                    if (txtrole.SelectedIndex > 0 && txtusername.Text != string.Empty && txtpassword.Text != string.Empty)
                    { //login Setup
                        if (txtrole.Text == "Admin")
                        {
                            dbcon.Opencon();
                            SqlCommand cmd = new SqlCommand("select top 1 adminid, adminpassword, FullName from tadmin where fullname=@fullname and AdminPassword= @adminpassword", dbcon.Getcon());
                            cmd.Parameters.AddWithValue("@fullname", txtusername.Text);
                            cmd.Parameters.AddWithValue("@adminpassword", txtpassword.Text);
                            SqlDataAdapter adp = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            adp.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {

                                Loginname = txtusername.Text;
                                logintype = txtrole.Text;
                                Clearvalue();
                                this.Hide();
                                FormHome fm = new FormHome();
                                fm.Show();

                            }
                            else
                            {
                                MessageBox.Show("Invalid login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


                        }
                        else if (txtrole.Text == "Salesman")
                        {
                            dbcon.Opencon();
                            SqlCommand cmd = new SqlCommand("select top 1 sellername, sellerpass from tseller where sellername=@sellername and sellerPass= @sellerPass", dbcon.Getcon());
                            cmd.Parameters.AddWithValue("@sellername", txtusername.Text);
                            cmd.Parameters.AddWithValue("@sellerPass", txtpassword.Text);
                            SqlDataAdapter adp = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            adp.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {

                                Loginname = txtusername.Text;
                                logintype = txtrole.Text;
                                Clearvalue();
                                this.Hide();
                                FormHome fm = new FormHome();
                                fm.Show();

                            }
                            else
                            {
                                MessageBox.Show("Invalid login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }


                    }
                    else { MessageBox.Show("Please Enter Valid useraname or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Clearvalue();



                    }




                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else { txtpassword.UseSystemPasswordChar = true; }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Clearvalue();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Form3 otp = new Form3();
            otp.Show();

        }

        public void gotnext(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //e.Handled = true;
                //e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);

            }

        }

        private void Clearvalue()
        {
            txtrole.SelectedIndex = 0;
            txtusername.Clear();
            txtpassword.Clear();
        }

    }
}
