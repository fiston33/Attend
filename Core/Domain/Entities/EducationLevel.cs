namespace Domain.Entities
{
    public class EducationLevel
    {
        public int Id {get; set;}

        public string name {get; set;}

        //Navigation Property: One Education Level can have many Classes
        public ICollection<Class> classy{get;set;}

    }
}

