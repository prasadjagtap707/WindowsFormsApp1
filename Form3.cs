using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder scb;

        public Form3()
        {
            InitializeComponent();
            string strConnection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            con = new SqlConnection(strConnection);
        }
        private DataSet GetEmpData()
        {
            da = new SqlDataAdapter("select * from Employee", con);
            // add PK constraint to the col (id) which is in DataSet
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // build the command for DataAdpater 
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            // Fill() fire the select qry in DB & load data in DataSet
            da.Fill(ds, "Employee"); // emp is the name given to the table which get loaded in the DataSet
            return ds;
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmpData();
                DataRow row = ds.Tables["Employee"].NewRow();
                row["EmpID"] =Convert.ToInt32( txtEmpID.Text);
               row["EName"] = txtEName.Text;
                row["Salary"] = txtsalary.Text;
                row["Address"] = txtAddress.Text;
                row["Contact"] = textContact.Text;
                ds.Tables["Employee"].Rows.Add(row);
                // reflect the changes from DataSet to DB
                int result = da.Update(ds.Tables["Employee"]);
                if (result == 1)
                {
                    MessageBox.Show("Record inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtAddress.Clear();
            textContact.Clear();
            txtEmpID.Clear();
            txtEName.Clear();
            txtsalary.Clear();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmpData();
                DataRow row = ds.Tables["Employee"].NewRow();
                row["EmpID"] = Convert.ToInt32(txtEmpID.Text);
                row["EName"] = txtEName.Text;
                row["Salary"] = Convert.ToInt32(txtsalary.Text);
                row["Address"] = txtAddress.Text;
                ds.Tables["Employee"].Rows.Add(row);
                // reflect the changes from DataSet to DB
                int result = da.Update(ds.Tables["Employee"]);
                if (result == 1)
                {
                    MessageBox.Show("Record inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmpData();
                DataRow row = ds.Tables["Employee"].Rows.Find(txtEmpID.Text);
                if (row != null)
                {
                    txtEName.Text = row["Name"].ToString();
                    txtsalary.Text = row["Salary"].ToString();
                    txtAddress.Text = row["Address"].ToString();
                    textContact.Text = row["Contact"].ToString();
                }
                else
                {
                    MessageBox.Show("Record does not exists");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAllEmp_Click(object sender, EventArgs e)
        {
            ds = GetEmpData();
            dataGridView1.DataSource = ds.Tables["Employee"];

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddress.Clear();
            textContact.Clear();
            txtEmpID.Clear();
            txtEName.Clear();
            txtsalary.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmpData();
                DataRow row = ds.Tables["Employee"].Rows.Find(txtEmpID.Text);
                if (row != null)
                {
                    row.Delete();// delete the row from DataSet
                    int result = da.Update(ds.Tables["Employee"]);
                    if (result == 1)
                    {
                        MessageBox.Show("Record deleted");
                    }

                }
                else
                {
                    MessageBox.Show("Id does not exists to delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }

}
