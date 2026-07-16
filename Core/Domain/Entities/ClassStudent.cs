namespace Domain.Entities
{
    public class ClassStudent
    {
        public int Id {get; set;}

        public int studentId {get; set;}
        public int classsId {get; set;}

        public Student student {get; set;}
        public Class classs {get; set;}
        
    }
}