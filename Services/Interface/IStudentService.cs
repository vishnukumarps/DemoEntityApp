using DemoEntityApp.Model;

namespace DemoEntityApp.Services.Interface
{
    public interface IStudentService
    {

        public void AddStudent(Student newStudent);
        public List<Student> GetAllStudents();

    }
}
