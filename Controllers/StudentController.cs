using DemoEntityApp.DbContext2;
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
            return "Hai";
        }

        [HttpPost("AddStudent")]
        public void AddStudent(Student studentObj)
        {
            _studentService.Add(studentObj);






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
