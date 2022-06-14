using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// add 
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            string strConnection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            con = new SqlConnection(strConnection);
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "insert into Employee values(@EmpID,@EName,@Address,@Salary,@Contact)";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@EmpID", Convert.ToInt32(txtEmpID.Text));
                cmd.Parameters.AddWithValue("@EName", txtEName.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Salary", Convert.ToInt32(txtsalary.Text));
                cmd.Parameters.AddWithValue("@Contact", Convert.ToInt32(textContact.Text));

                con.Open();

                int result = cmd.ExecuteNonQuery();
                if(result==1)
                {
                    MessageBox.Show("record Inserted ");
                }
                txtEmpID.Clear();
                txtAddress.Clear();
                txtEName.Clear();
                txtsalary.Clear();
                textContact.Clear();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmpID.Clear();
            txtAddress.Clear();
            txtEName.Clear();
            txtsalary.Clear();
            textContact.Clear();
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            { 
            string str = "delete from Employee where EmpID=@EmpID";
            cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@EmpID", Convert.ToInt32(txtEmpID.Text));

            con.Open();

            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                MessageBox.Show("record deleted");
            }


        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "update Employee set Address=@Address,Salary=@Salary,Contact=@Contact where EmpID=@EmpID";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@EmpID", Convert.ToInt32(txtEmpID.Text));
                cmd.Parameters.AddWithValue("@EName", txtEName.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Salary", Convert.ToInt32(txtsalary.Text));
                cmd.Parameters.AddWithValue("@Contact", Convert.ToInt32(textContact.Text));

                con.Open();

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("record updated ");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "select * from Employee where EmpID=@EmpID";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@EmpID", Convert.ToInt32(txtEmpID.Text));
                

                con.Open();
                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    if(dr.Read())
                    {
                        txtEName.Text = dr["EName"].ToString();
                        txtAddress.Text = dr["Address"].ToString();
                        txtsalary.Text = dr["Salary"].ToString();
                        textContact.Text = dr["Contact"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("record Not Found !!!!");
                }

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("record updated ");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
               
            }
        }

        private void btnAllEmp_Click(object sender, EventArgs e)
        {

            try
            {
                string str = "select * from Employee";
                cmd = new SqlCommand(str, con);

                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;

                con.Open();

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("All Data Loaded ");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtsalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmpID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
