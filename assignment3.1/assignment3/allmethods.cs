using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace assignment3
{
    //project table
    public class allmethods
    {
        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-JJ82MOAT;Initial Catalog=assignment3;Integrated Security=True");
        public void project_insert(string name, string date)
        {
            SqlCommand command = new SqlCommand("Insert into project(name,date) values('"+name+"','"+date+"')",connect);
            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
        }
        public void project_delete(int project_id)
        {
            SqlCommand command = new SqlCommand("delete from project where projectNumber=" + project_id, connect);
            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
        }
        public DataTable getProjectTable()
        {
            SqlConnection connect2 = new SqlConnection("Data Source=LAPTOP-JJ82MOAT;Initial Catalog=assignment3;Integrated Security=True");

            SqlCommand command = new SqlCommand("select * from project", connect2);
            connect2.Open();
            SqlDataReader sdr = command.ExecuteReader();
            
            DataTable table = new DataTable();
            table.Load(sdr);
            connect2.Close();
            return table;
            
        }
        public DataTable getProjectTableById(int project_id)
        {
            
            SqlCommand command = new SqlCommand("select * from project where projectNumber=" + project_id, connect);
            connect.Open();
            SqlDataReader sdr = command.ExecuteReader();
            
            DataTable table = new DataTable();
            table.Load(sdr);
            connect.Close();
            return table;
        }
        public void projectUpdate(int project_id, string name, string date)
        {
            SqlCommand command = new SqlCommand("update project set projectNumber ="+ project_id+", name = '"+name+"', date = '"+date+"' where projectNumber = "+project_id,connect);
            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
        }
        // department table
        public void department_insert(string name)
        {
            SqlCommand command = new SqlCommand("Insert into department values('" + name  +"')", connect);
            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
        }
        public void department_delete(int department_id)
        {
            SqlCommand command = new SqlCommand("delete from department where departmentNumber=" + department_id, connect);
            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
        }
        public DataTable getDepartmentTable()
        {
            SqlCommand command = new SqlCommand("select * from department", connect);
            connect.Open();
            SqlDataReader sdr = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(sdr);
            connect.Close();
            return table;
        }
        public DataTable getdepartmentTableById(int department_id)
        {
            SqlCommand command = new SqlCommand("select * from department where departmentNumber=" + department_id, connect);
            connect.Open();
            SqlDataReader sdr = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(sdr);
            connect.Close();
            return table;
        }
        public void departmentUpdate(int department_id, string name)
        {
            SqlCommand command = new SqlCommand("update department set departmentNumber =" + department_id + ", name = '" + name + "' where projectNumber = " + department_id, connect);
            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
        }
        //employee table
        public void employee_insert(string jobTitle,string lastName, string firstName,string gender, string birthday, string hireDate,int departmentNumber, int projectNumber)
        {
            SqlCommand command = new SqlCommand("Insert into employee(jobTitle,lastName,firstName,gender,birthday,hireDate,departmentNumber,projectNumber) values('" + jobTitle + "','" + lastName + "','" + firstName + "','" + gender + "','" + birthday + "','" + hireDate + "'," + departmentNumber + "," + projectNumber + ")", connect);
            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
        }
        public void employee_delete(int employeeNumber)
        {
            SqlCommand command = new SqlCommand("delete from employee where employeeNumber=" + employeeNumber, connect);
            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
        }
        public DataTable getemployeeTable()
        {
            SqlCommand command = new SqlCommand("select * from employee", connect);
            connect.Open();
            SqlDataReader sdr = command.ExecuteReader();
            
            DataTable table = new DataTable();
            table.Load(sdr);
            connect.Close();
            return table;
        }
        public DataTable getemployeeTableById(int employeeNumber)
        {
            SqlCommand command = new SqlCommand("select * from employee where employeeNumber=" + employeeNumber, connect);
            connect.Open();
            SqlDataReader sdr = command.ExecuteReader();
            
            DataTable table = new DataTable();
            table.Load(sdr);
            connect.Close();
            return table;  
        }
        public void employeeUpdate(int employeeNumber, string jobTitle, string lastName, string firstName, string gender, string birthday, string hireDate, int departmentNumber, int projectNumber)
        {
            SqlCommand command = new SqlCommand("update employee set jobTitle='"+jobTitle+ "', lastName='"+ lastName+ "', firstName='"+ firstName+ "', gender='"+ gender+ "', birthday='"+ birthday+ "', hireDate='"+ hireDate+ "', departmentNumber="+ departmentNumber+ ", projectNumber="+ projectNumber+ " where employeeNumber ="+employeeNumber, connect);
            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
        }
    }
}