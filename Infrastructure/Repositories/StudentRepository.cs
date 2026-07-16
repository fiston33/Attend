using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
namespace Infrastructure.Repositories
{
      public class StudentRepository:IStudent
    {

        private readonly ApplicationDbContext _dbcontext;

        public StudentRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }



        public List<Student> GetAllStudent()
        {
            
             return _dbcontext.Students.ToList();

        //      new List<Student>{
        //   new Student{Id=1,Address="Nyamagabe District Gasaka Sector",DateOfBirth= new DateTime(2005,04,14),Email="byiringirofiston33@gmail.com",FatherName="RWABUHIHI KIBABA",MotherName="Jacqeuline MUKANDUTIYE",Name="Fiston BYIRINGIRO", Phone="0791886292",Sex="Male"}, 
        //   new Student{Id=2, Address="Kigali City Gasabo District ",DateOfBirth=new DateTime(2019,05,30),Email="kennedymukunzi@gmail.com",FatherName="Eric MURWANASHYAKA",MotherName="NYIRAKABONEYE Godsgiving",Name="Kennedy MUKUNZI",Phone="0790279865",Sex="Male"}
        //     };
        }
    }
}

