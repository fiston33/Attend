using Domain.Entities;
namespace Application.Interfaces
{
    
    public interface IClass
    {
        public List<Class> GetAllClasses();

        public void AddClass(Class classe);

        // public Class GetClassById(int id);


    }
}






