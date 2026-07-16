namespace Domain.Entities
{
    public class Attendance
    {
        public int Id {get; set;}

        public DateTime AttendanceDateTime {get; set;}

        // public string Status {get; set;} Enum


        //Prefic should match the Navigation property name
        public int studentId {get; set;}
        public int classsId {get; set;}

        //Nagivation properties
        public Student student {get; set;}
        public Class classs {get; set;}

        



    }
}