using StudentsAppSQL9Pro.DTO;

namespace StudentsAppSQL9Pro.Services
{
    public interface IStudentService
    {
        StudentReadOnlyDTO? InsertStudent(StudentInsertDTO studentInsertDTO);
        void UpdateStudents(StudentUpdateDTO studentUpdateDTO);
        void DeleteStudent(int id);
        StudentReadOnlyDTO GetStudent(int id);
        List<StudentReadOnlyDTO> GetAllStudents();
    }
}
