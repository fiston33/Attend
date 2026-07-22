using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class ClassRepository:IClass
    {
         private readonly ApplicationDbContext _dbcontext;

        public ClassRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

          public List<Class> GetAllClasses()
        {
            //  return new List<Class>{
            // new Class{id=1, classname="P1A", department="Lower Primary",FacultyId=1, teacher="UFITUMUGISHA Simeon Garou"}
            // };
            return _dbcontext.Classes.ToList();
        }

        public void AddClass(Class classs)
        {
             _dbcontext.Classes.Add(classs);
            _dbcontext.SaveChanges();
        }

        
        
          

       
    }
}