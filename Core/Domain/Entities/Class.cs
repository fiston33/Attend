namespace Domain.Entities
{
  public class Class
  {
    public int id { get; set; }

    public string classname { get; set; }

    public string department { get; set; }

    public string teacher { get; set; }

    //Prefic should match the Navigation property name
    
    // public int FacultyId { get; set; }
    // public int EducationLevelId { get; set; }

    //Nagivation properties

    // public Faculity Faculty { get; set; }
    // public EducationLevel EducationLevel { get; set; }
  }
}

