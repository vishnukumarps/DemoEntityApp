using DemoEntityApp.DTO;
using DemoEntityApp.Model;

namespace DemoEntityApp.Services.Interface
{
    public interface IStudentService
    {

        public void AddStudent(StudentDto newStudent);
        public List<StudentDto> GetAllStudents();

        public StudentDto GetStudnet(int id);

    }
}
