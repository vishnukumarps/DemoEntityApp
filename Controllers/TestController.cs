using DemoEntityApp.DbContext2;
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
        public ActionResult AddStudent(Student studnet) 
        {
            _studentService.AddStudent(studnet);

            return null;
        }

      
    }
}
