using DemoEntityApp.Model;
using DemoEntityApp.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DemoEntityApp.Controllers
{
    public class TeacherController : Controller
    {

        private readonly IteacherService _teacherService;
        public IActionResult Index()
        {
            return View();
        }
        public TeacherController(IteacherService teacherService)
        {
            _teacherService= teacherService;

        }
        [HttpPost("Addteacher")]
        public ActionResult AddTeacher(Teacher teacher)
        {
            _teacherService.AddTeacher(teacher);
            return null;
        }


    }

}
