using AutoMapper;
using StudentsAppSQL9Pro.DAO;
using StudentsAppSQL9Pro.DTO;

namespace StudentsAppSQL9Pro.Services
{
    public class StudentServiceImpl : IStudentService
    {
        private readonly IStudentDAO _studentDAO;
        private readonly IMapper _mapper;
        private readonly ILogger<StudentServiceImpl> _logger; 

        public StudentServiceImpl(IStudentDAO studentDAO, IMapper mapper, ILogger<StudentServiceImpl> logger)
        {
            _studentDAO = studentDAO;
            _mapper = mapper;
            _logger = logger;
        }

        public void DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public List<StudentReadOnlyDTO> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public StudentReadOnlyDTO GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public StudentReadOnlyDTO? InsertStudent(StudentReadOnlyDTO studentInsertDTO)
        {
            throw new NotImplementedException();
        }

        public void UpdateStudents(StudentUpdateDTO studentUpdateDTO)
        {
            throw new NotImplementedException();
        }
    }
}
