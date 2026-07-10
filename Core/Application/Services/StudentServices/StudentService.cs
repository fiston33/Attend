namespace Core.Application.Services.StudentServices
{
    public class StudentService:IStudentService
    {
        public List<Student> GetAllStudent()
        {
             return new List<Student>{
          new Student{Id=1,Address="Nyamagabe District Gasaka Sector",DateOfBirth= new DateTime(2005,04,14),Email="byiringirofiston33@gmail.com",FatherName="RWABUHIHI KIBABA",MotherName="Jacqeuline MUKANDUTIYE",Name="Fiston BYIRINGIRO", Phone="0791886292",Sex="Male"}, 
          new Student{Id=2, Address="Kigali City Gasabo District ",DateOfBirth=new DateTime(2019,05,30),Email="kennedymukunzi@gmail.com",FatherName="Eric MURWANASHYAKA",MotherName="NYIRAKABONEYE Godsgiving",Name="Kennedy MUKUNZI",Phone="0790279865",Sex="Male"}
            };
        }
    }

        public class Student{
        public int Id {get; set;}

        public string Name {get; set;}

        public string Sex {get; set;}

        public DateTime DateOfBirth {get; set;}

        public string Phone {get; set;}

        public string Email {get; set;}

        public string Address {get; set;}

        public string MotherName {get; set;}

        public string FatherName {get; set;}
    }

}
