using DemoEntityApp.Model;

namespace DemoEntityApp.Service.Interface
{
    public interface IteacherService
    {
        public void AddTeacher(Teacher teacher);
        public  List<Teacher>GetTeachers();
        public void RemoveTeacher(string id);
    }
}
