using Application.Interfaces;
using Domain.Entities;

namespace Infrastructure.Repositories
{
    public class ClassRepository:IClass
    {
          public List<Class> GetAllClasses()
        {
             return new List<Class>{
            new Class{id=1, classname="P1A", department="Lower Primary",FacultyId=1, teacher="UFITUMUGISHA Simeon Garou"}
            };
        }
    }
}