using Application.DTOs;
namespace Application.Interfaces
{
    
    public interface IStudent
    {
        public List<GetStudentDTO> GetAllStudent();
        public void AddStudent(AddStudentDTO student);
        public GetStudentDTO? GetStudentById(int id);
        public void UpdateStudent(UpdateStudentDTO student);

        public void DeleteStudent(DeleteStudentDTO student);
    }
}


