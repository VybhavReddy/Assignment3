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
    public partial class employee : System.Web.UI.Page
    {
        allmethods obj = new allmethods();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = obj.getemployeeTable();
            GridView1.DataBind();
        }
        protected void insert_button_Click(object sender, EventArgs e)
        {
            obj.employee_insert(jobTitle.Text, lastName.Text, firstName.Text, gender.Text, birthday.Text, hireDate.Text, Convert.ToInt32(departmentNumber.Text), Convert.ToInt32(projectNumber.Text));
            GridView1.DataSource = obj.getemployeeTable();
            GridView1.DataBind();
        }

        protected void delete_button_Click(object sender, EventArgs e)
        {
            obj.employee_delete(Convert.ToInt32(employeeNumber.Text));
            GridView1.DataSource = obj.getemployeeTable();
            GridView1.DataBind();
        }

        protected void update_button_Click(object sender, EventArgs e)
        {
            obj.employeeUpdate(Convert.ToInt32(employeeNumber.Text), jobTitle.Text, lastName.Text, firstName.Text, gender.Text, birthday.Text, hireDate.Text,Convert.ToInt32(departmentNumber.Text),Convert.ToInt32(projectNumber.Text));
            GridView1.DataSource = obj.getemployeeTable();
            GridView1.DataBind();
        }

        protected void search_button_Click(object sender, EventArgs e)
        {
            int emp_no=Convert.ToInt32(search_box.Text);
            DataTable table= obj.getemployeeTableById(emp_no);
            GridView1.DataSource = table;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int emp_no = Convert.ToInt32(e.CommandArgument);
            if(e.CommandName=="select")
            {
                DataTable table = new DataTable();
                table= obj.getemployeeTableById(emp_no);
                employeeNumber.Text = table.Rows[0][0].ToString();
                jobTitle.Text = table.Rows[0][1].ToString();
                lastName.Text = table.Rows[0][2].ToString();
                firstName.Text = table.Rows[0][3].ToString();
                gender.Text = table.Rows[0][4].ToString();
                birthday.Text = table.Rows[0][5].ToString();
                hireDate.Text = table.Rows[0][6].ToString();
                departmentNumber.Text = table.Rows[0][7].ToString();
                projectNumber.Text = table.Rows[0][8].ToString();
            }
        }
    }
}