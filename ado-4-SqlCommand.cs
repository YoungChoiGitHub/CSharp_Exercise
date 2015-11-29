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
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select Id, FisrtName, LastName, Gender from Employees";
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                GridView1.DataSource = reader;
                GridView1.DataBind();
            }
            using (SqlConnection conn = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("select count(Id) from Employees", conn);
                conn.Open();
                int totalRows = (int)cmd.ExecuteScalar();
                Response.Write("Total Rows = " + totalRows.ToString() + "<br>"); 
            }

            string CS1 = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS1))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "insert into Employees (FisrtName, LastName, Gender, Salary, Department_id) values ('Michelle', 'Edwards', 'Female', 65000, 2)";
                cmd.Connection = con;
                con.Open();
                int totalRowsAffected = cmd.ExecuteNonQuery();
                Response.Write("Total Rows Affected = " + totalRowsAffected.ToString() + "<br>");
            }

            string CS2 = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS2))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "update Employees set LastName = 'Taylor' where Id = 6";
                cmd.Connection = con;
                con.Open();
                int totalRowsAffected = cmd.ExecuteNonQuery();
                Response.Write("Total Rows Affected = " + totalRowsAffected.ToString() + "<br>");

                cmd.CommandText = "delete from Employees where Id = 7";
                totalRowsAffected = cmd.ExecuteNonQuery();
                Response.Write("Total Rows Affected = " + totalRowsAffected.ToString() + "<br>");
            }
        }

    }

    /* Web.config
        <configuration>
          <connectionStrings>
            <add name="DBCS" 
                 connectionString="server=lenovo\sqlexpress; database=Sample; integrated security=SSPI" 
                 providerName="System.Data.SqlClient"/>
          </connectionStrings>
          <system.web>
            <compilation debug="true" targetFramework="4.5.2"/>
            <httpRuntime targetFramework="4.5.2"/>
          </system.web>
          <system.codedom>
            <compilers>
              <compiler language="c#;cs;csharp" extension=".cs"
                type="Microsoft.CodeDom.Providers.DotNetCompilerPlatform.CSharpCodeProvider, Microsoft.CodeDom.Providers.DotNetCompilerPlatform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
                warningLevel="4" compilerOptions="/langversion:6 /nowarn:1659;1699;1701"/>
              <compiler language="vb;vbs;visualbasic;vbscript" extension=".vb"
                type="Microsoft.CodeDom.Providers.DotNetCompilerPlatform.VBCodeProvider, Microsoft.CodeDom.Providers.DotNetCompilerPlatform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
                warningLevel="4" compilerOptions="/langversion:14 /nowarn:41008 /define:_MYTYPE=\&quot;Web\&quot; /optionInfer+"/>
            </compilers>
          </system.codedom>
        </configuration>
    */
}