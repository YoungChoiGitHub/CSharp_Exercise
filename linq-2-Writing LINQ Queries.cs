using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication21
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Lambda
            //IEnumerable<Student> queryResult = Student.GetAllStudents().Where(student => student.Gender == "Female");

            // Sql like
            IEnumerable<Student> queryResult = from student in Student.GetAllStudents()
                                               where student.Gender == "Male"
                                               select student;
            GridView1.DataSource = queryResult;
            GridView1.DataBind();
        }
    }

    public class Student 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public static List<Student> GetAllStudents()
        {
            List<Student> listStudent = new List<Student>();
            listStudent.Add(new Student() { Id = 101, Name = "Mark", Gender="Male" });
            listStudent.Add(new Student() { Id = 102, Name = "Mary", Gender="Female" });
            listStudent.Add(new Student() { Id = 103, Name = "Tim", Gender ="Male" });

            return listStudent;
        }
    }
}