using Application.DTOs;
using Domain.Entities;
namespace Application.Services.StudentServices
{
    public interface IStudentService
    {
        public Task<List<GetStudentDTO>> GetAllStudentAsync();
        Task AddStudentAsync(AddStudentDTO student);
        Task<GetStudentDTO?> GetStudentByIdAsync(int id);
        Task UpdateStudentAsync(UpdateStudentDTO student);

        Task DeleteStudentAsync(DeleteStudentDTO student);

    }
}
