using DemoEntityApp.DbContext2;
using DemoEntityApp.Helper;
using DemoEntityApp.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoEntityApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
      
        HelperClass _helper;
        DemoDbContext demoDbContext;
        public StudentController(HelperClass helper
           // , DemoDbContext demoDbContext
            )
        {
           
         
           demoDbContext= new DemoDbContext();
            _helper = helper;
        }


        [HttpPost("Sayhello")]
        public string SayHai()
        {
           
           return  _helper.getOtp().ToString();
        }

        [HttpPost("AddStudent")]
        public void AddStudent(Student studentObj)
        {

    

            demoDbContext.Students.Add(studentObj);
            demoDbContext.SaveChanges();

           
           
        }

        [HttpGet("GetAllStudents")]
        public List<Student> GetAllStudents()
        {

        
            List<Student> studentList= demoDbContext.Students.ToList();
            
            return studentList;

        }


        [HttpGet("GetAllStudents2")]
        public List<Student> GetAllStudents2()
        {

            List<Student> studentList = demoDbContext.Students.ToList();

            return studentList;

        }
    }
}
