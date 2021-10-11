using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace assignment3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        allmethods obj = new allmethods();
        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-JJ82MOAT;Initial Catalog=assignment3;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable table = obj.getDepartmentTable();
            GridView1.DataSource = table;
            GridView1.DataBind();
        }

        protected void insert_button_Click(object sender, EventArgs e)
        {
            obj.department_insert(name.Text);
            DataTable table = obj.getDepartmentTable();
            GridView1.DataSource = table;
            GridView1.DataBind();
        }

        protected void update_button_Click(object sender, EventArgs e)
        {
            obj.departmentUpdate(Convert.ToInt32(departmentNumber.Text), name.Text);
            DataTable table = obj.getDepartmentTable();
            GridView1.DataSource = table;
            GridView1.DataBind();
        }

        protected void delete_button_Click(object sender, EventArgs e)
        {
            obj.department_delete(Convert.ToInt32(departmentNumber.Text));
            DataTable table = obj.getDepartmentTable();
            GridView1.DataSource = table;
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int deptno = Convert.ToInt32(e.CommandArgument);
            if(e.CommandName=="select")
            {
                DataTable dt = obj.getdepartmentTableById(deptno);
                departmentNumber.Text = dt.Rows[0][0].ToString();
                name.Text = dt.Rows[0][1].ToString();
            }
        }
    }
}