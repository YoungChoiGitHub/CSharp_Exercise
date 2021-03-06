using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication18
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            /* Parameterized approach
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Employees where LastName like @LastName";
                cmd.Parameters.AddWithValue("@lastName", txtFilter.Text + "%");
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                GridView1.DataSource = reader;
                GridView1.DataBind();
            }
            */

	    // Store procedure approach
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spLastName", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LastName", txtFilter.Text);
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                GridView1.DataSource = reader;
                GridView1.DataBind();
            }
        }
    }
}