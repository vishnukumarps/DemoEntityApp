using DemoEntityApp.DbContext2;
using DemoEntityApp.DTO;
using DemoEntityApp.Helper;
using DemoEntityApp.Model;
using DemoEntityApp.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoEntityApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
      
        private readonly IStudentService _studentService;

        public TestController(IStudentService studentService)
        {
           
          _studentService= studentService;
        }

        [HttpPost("AddStudent")]
        public ActionResult AddStudent(StudentDto studnetDto) 
        {
          _studentService.AddStudent(studnetDto);

            return null;
        }

        [HttpGet("GetStudnet")]
        public ActionResult GetStudnet(int id)
        {
           StudentDto studentDto= _studentService.GetStudnet(id);

            return Ok(studentDto);
        }

        [HttpGet("GetStudnets")]
        public ActionResult GetStudnets()
        {
            List<StudentDto> studentDtos = _studentService.GetAllStudents();

            return Ok(studentDtos);
        }


    }
}
