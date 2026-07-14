namespace Application.Services.ClassServices
{
    public class ClassServices : IClassServices
    {
      public List<Class> GetAllClasses()
        {
             return new List<Class>{
            new Class{id=1, classname="P1A", department="Lower Primary",faculity="N/A", teacher="UFITUMUGISHA Simeon Garou"}
            };
        }
    }

    public class Class{
        public int id {get; set;}

        public string classname {get; set;}

        public string department {get; set;}

        public string faculity {get; set;}

        public string teacher {get; set;}
    }
}