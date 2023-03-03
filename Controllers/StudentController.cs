using DemoEntityApp.DbContext2;
using DemoEntityApp.Helper;
using DemoEntityApp.Model;
using DemoEntityApp.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoEntityApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
      private readonly  IStudentService _studentService;
        public StudentController(IStudentService studentService )
        {
           _studentService= studentService;
        }
        [HttpPost]
        public string SayHai()
        {
           return  "Hai";
        }

        [HttpPost("AddStudent")]
        public void AddStudent(Student studentObj)
        {
            _studentService.Add(studentObj);




            DemoDbContext demoDbContext = new DemoDbContext();


           
           
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
