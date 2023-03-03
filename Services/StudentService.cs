using DemoEntityApp.DbContext2;
using DemoEntityApp.Model;
using DemoEntityApp.Services.Interface;

namespace DemoEntityApp.Services
{
    public class StudentService : IStudentService
    {
        private readonly DemoDbContext _dbContext;
        public StudentService(DemoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddStudent(Student newStudent)
        {
          _dbContext.Students.Add(newStudent);
        }

        public List<Student> GetAllStudents()
        {
            return _dbContext.Students.ToList();
        }
    }
}
