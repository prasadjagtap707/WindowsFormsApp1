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
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder scb;

        public Form2()
        {
            InitializeComponent();
            string strConnection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            con = new SqlConnection(strConnection);
        }
        private DataSet GetEmpData()
        {
            da = new SqlDataAdapter("select * from Course", con);
            // add PK constraint to the col (id) which is in DataSet
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // build the command for DataAdpater 
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            // Fill() fire the select qry in DB & load data in DataSet
            da.Fill(ds, "Course"); // emp is the name given to the table which get loaded in the DataSet
            return ds;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmpData();
                DataRow row = ds.Tables["Course"].NewRow();
                row["Course ID"] = Convert.ToInt32(txtCId.Text);
                row["CName"] = txtCName.Text;
                row["Fees"] = Convert.ToInt32(txtCFee.Text);
                row["Duration"] = Convert.ToInt32(txtCDuration.Text);
              
                ds.Tables["Course"].Rows.Add(row);
                // reflect the changes from DataSet to DB
                int result = da.Update(ds.Tables["Course"]);
                if (result == 1)
                {
                    MessageBox.Show("Record inserted");
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCDuration.Clear();
            txtCFee.Clear();
            txtCId.Clear();
            txtCName.Clear();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmpData();
                DataRow row = ds.Tables["Course"].Rows.Find(txtCId.Text);
                if (row != null)
                {
                    txtCName.Text = row["CName"].ToString();
                    txtCFee.Text = row["Fees"].ToString();
                    txtCDuration.Text = row["Duration"].ToString();
                   
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
            finally
            {
                con.Close();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
               
                ds = GetEmpData();
                DataRow row = ds.Tables["Course"].Rows.Find(txtCId.Text);
                if (row != null)
                {
                    row["CName"] = txtCName.Text;
                    row["Fees"] = Convert.ToInt32(txtCFee.Text);
                    row["Duration"] = Convert.ToInt32(txtCDuration.Text);
                    int result = da.Update(ds.Tables["Course"]);
                    if (result == 1)
                    {
                        MessageBox.Show("Record updated");
                    }

                }
                else
                {
                    MessageBox.Show("Id does not exists to update");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmpData();
                DataRow row = ds.Tables["Course"].Rows.Find(txtCId.Text);
                if (row != null)
                {
                    row.Delete();// delete the row from DataSet
                    int result = da.Update(ds.Tables["Course"]);
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
            finally
            {
                con.Close();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ds = GetEmpData();
            dataGridView1.DataSource = ds.Tables["Course"];

        }
    }
}
