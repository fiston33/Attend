using Application.DTOs;
namespace Application.Interfaces
{
    
    public interface IStudent
    {
        Task <List<GetStudentDTO>> GetAllStudentAsync();
        Task AddStudentAsync(AddStudentDTO student);
        Task< GetStudentDTO?> GetStudentByIdAsync(int id);
        Task UpdateStudentAsync(UpdateStudentDTO student);

        Task DeleteStudentAsync(DeleteStudentDTO student);
    }
}


