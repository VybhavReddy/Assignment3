using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace assignment3
{
    public partial class project : System.Web.UI.Page
    {
        allmethods obj = new allmethods();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt2 = obj.getProjectTable();
          
            GridView1.DataSource = dt2;
            GridView1.DataBind();
        }
       
        protected void insert_button_Click(object sender, EventArgs e)
        {
            
            string copy_name = name.Text;
            string date_copy = date.Text;
            obj.project_insert(copy_name, date_copy);
            dt = obj.getProjectTable();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void update_button_Click(object sender, EventArgs e)
        {
            int proj_num = Convert.ToInt32(projectNumber.Text);
            string copy_name = name.Text;
            string date_copy = date.Text;
            obj.projectUpdate(proj_num, copy_name, date_copy);
            dt = obj.getProjectTable();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void delete_button_Click(object sender, EventArgs e)
        {
            int proj_num = Convert.ToInt32(projectNumber.Text);
            obj.project_delete(proj_num);
            dt = obj.getProjectTable();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void search_button_Click(object sender, EventArgs e)
        {
            int proj_num = Convert.ToInt32(search_box.Text);
            DataTable table = obj.getProjectTableById(proj_num);
            GridView1.DataSource = table;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int proj_num = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "select")
            {
                DataTable table = obj.getProjectTableById(proj_num);
                projectNumber.Text = table.Rows[0][0].ToString();
                name.Text = table.Rows[0][1].ToString();
                date.Text = table.Rows[0][2].ToString();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}