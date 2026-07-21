using Application.DTOs;
using Domain.Entities;
namespace Application.Services.StudentServices
{
    public interface IStudentService
    {
        public List<GetStudentDTO> GetAllStudent();
        public void AddStudent(AddStudentDTO student);
        public GetStudentDTO? GetStudentById(int id);
        public void UpdateStudent(UpdateStudentDTO student);

        public void DeleteStudent(DeleteStudentDTO student);

    }
}
