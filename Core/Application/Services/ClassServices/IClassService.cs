using Domain.Entities;
namespace Application.Services.ClassServices
{
    
    public interface IClassService
    {
        public List<Class>  GetAllClasses();

        public void AddClass(Class classe);

        // public Class GetClassById(Class classe);
    }
}


