using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication18
{
    public partial class WebForm1 : System.Web.UI.Page
    { 
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(getConnectionString());
            SqlCommand cmd = new SqlCommand("select * from Employees", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
            conn.Close();
        }

        private string getConnectionString()
        {
            return "server=lenovo\\sqlexpress; database=Sample; integrated security=SSPI";
        }
    }
}