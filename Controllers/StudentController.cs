using DemoEntityApp.DbContext2;
using DemoEntityApp.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoEntityApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpPost]
        public string SayHai()
        {
           return  "Hai";
        }

        [HttpPost("AddStudent")]
        public void AddStudent(Student studentObj)
        {

            DemoDbContext demoDbContext = new DemoDbContext();

            demoDbContext.Students.Add(studentObj);
            demoDbContext.SaveChanges();

        }

        [HttpGet("GetAllStudents")]
        public List<Student> GetAllStudents()
        {

            DemoDbContext demoDbContext = new DemoDbContext();
            List<Student> studentList= demoDbContext.Students.ToList();


            return studentList;

        }
    }
}
