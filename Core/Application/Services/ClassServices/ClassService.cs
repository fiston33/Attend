using Application.Interfaces;
using Domain.Entities;

namespace Application.Services.ClassServices
{
    public class ClassService:IClassService
    {
        private readonly IClass _classs;

        public ClassService(IClass classs)
        {
            _classs = classs;
            
        }

        public List<Class> GetAllClasses()
        {
            return _classs.GetAllClasses();
        }

        public void AddClass(Class classe)
        {
            _classs.AddClass(classe);
        }

    }
}




