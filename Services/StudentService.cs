using DemoEntityApp.DbContext2;
using DemoEntityApp.DTO;
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

        public void AddStudent(StudentDto newStudentDto)
        {

            Student studentEntity = new Student();

            studentEntity.Name = newStudentDto.Name + newStudentDto.DisplayName;
            studentEntity.PhoneNumber = newStudentDto.PhoneNumber;


            //Autmapper

            //  Student studentEntity= mapper.map<Student,StudentDto>(newStudentDto)


            _dbContext.Students.Add(studentEntity);
        }

        public List<StudentDto> GetAllStudents()
        {
            List<Student> studentList = _dbContext.Students.ToList();
            List<StudentDto> studentDtos = new List<StudentDto>();

            foreach (var item in studentList)
            {
                studentDtos.Add(new StudentDto()
                {
                    Name = item.Name,
                    PhoneNumber = item.PhoneNumber,
                });

            }

            // Or
            List<StudentDto> studentDtoList = studentList.Select(item =>
              {
                  return new StudentDto()
                  {
                      Name = item.Name,
                      PhoneNumber = item.PhoneNumber,
                  };
              }).ToList();

           // return studentDtos;
            return studentDtoList;
        }

        public StudentDto GetStudnet(int id)
        {
            Student? student = _dbContext.Students.Where(x => x.Id == id).FirstOrDefault();
            StudentDto studentDto = new StudentDto();
            if (student != null)
            {

                studentDto.Name = student.Name;
                studentDto.PhoneNumber = student.PhoneNumber;

            }

            return studentDto;
        }
    }
}
