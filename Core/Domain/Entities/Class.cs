  namespace Domain.Entities{
  public class Class{
        public int id {get; set;}

        public string classname {get; set;}

        public string department {get; set;}

        public string teacher {get; set;}

        //Prefic should match the Navigation property name
        public int FacultyId{get;set;} = 1;
        public int EducationLevelId{get;set;} =1;

        //Nagivation properties
        public Faculity Faculty{get;set;}
        public EducationLevel EducationLevel{get;set;}
    }
    }

    