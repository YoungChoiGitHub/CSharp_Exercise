using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication20
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* Linq to SQL
            SampleDataContext dataContext = new SampleDataContext();
            GridView1.DataSource = from Employee in dataContext.Employees
                                   where Employee.Gender == "Male"
                                   select Employee;
            GridView1.DataBind();
            */

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            GridView1.DataSource = from number in numbers
                                   where (number % 2) == 0
                                   select number;
            GridView1.DataBind();

        } 
    }
}