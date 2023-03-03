using DemoEntityApp.DbContext2;
using DemoEntityApp.Model;
using DemoEntityApp.Service.Interface;

namespace DemoEntityApp.Service
{
    public class StudentService : IStudentService
    {
        private readonly DemoDbContext _dbContext;
        public StudentService(DemoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Student student)
        {
            _dbContext.Students.Add(student);
        }

       
        public List<Student> GetAllStudents()
        {
            return _dbContext.Students.ToList();
        }
    }
}
