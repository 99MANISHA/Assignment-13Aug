using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ConnectedObjects1
{
    public partial class WebOperations : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HFDJH1A\\MSSQLSERVER01;Initial Catalog=Assignments;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public void ShowGrid()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from EmpTb1", conn);

            SqlDataReader sdr = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(sdr);
            GridView1.DataSource = dt;
            GridView1.DataBind();

            sdr.Close();
            conn.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ShowGrid();
            }
        }

        protected void txtEmpId_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtEmpName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtEmpSal_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("Insert into EmpTb1(empName ,empSal) values (@empName ,@empSal)", conn);
            cmd.Parameters.Add("@empname", SqlDbType.VarChar, 20).Value = txtEmpName.Text;
            cmd.Parameters.Add("@empsal", SqlDbType.Float).Value = Convert.ToSingle(txtEmpSal.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                Response.Write("Alert(one row update)");
            }

            conn.Close();
            ShowGrid();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update EmpTb1 set EmpName=@empName, EmpSal=@empsal where EmpId=@empid", conn);
            cmd.Parameters.Add("@empid", SqlDbType.Int).Value = Convert.ToInt32(txtEmpId.Text);
            cmd.Parameters.Add("@empname", SqlDbType.VarChar, 20).Value = txtEmpName.Text;

            cmd.Parameters.Add("@empsal", SqlDbType.Float).Value = Convert.ToSingle(txtEmpSal.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            ShowGrid();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from EmpTb1   where EmpId='" + txtEmpId.Text + "'", conn);

            cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
        }

        protected void btnSp_Insert_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("Sp_InsertEmp1", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpName", txtEmpName.Text);
            cmd.Parameters.AddWithValue("@EmpSal", txtEmpSal.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
        }

        protected void btnSp_Update_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("sp_UpdateEmp1", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@EmpId", SqlDbType.Int).Value = Convert.ToInt32(txtEmpId.Text);
            cmd.Parameters.Add("@EmpName", SqlDbType.VarChar,20).Value = txtEmpName.Text;
            cmd.Parameters.Add("@EmpSal", SqlDbType.Float).Value = Convert.ToString(txtEmpSal.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
        }

        protected void btnSp_Delete_Click(object sender, EventArgs e)
        {

        }

        protected void btnDeletPar_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("delete from EmpTb1  where empId=@EmpId", conn);
            cmd.Parameters.Add("@empId", SqlDbType.Int).Value = Convert.ToInt32(txtEmpId.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
        }
    }
}