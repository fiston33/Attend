namespace Domain.Entities
{

   public class Student{
        public int Id {get; set;}

        public string Name {get; set;}

        public string Sex {get; set;}

        public DateTime DateOfBirth {get; set;}

        public string Phone {get; set;}

        public string Email {get; set;}

        public string RegNumber {get; set;}

        public string Address {get; set;}

        public string MotherName {get; set;}

        public string FatherName {get; set;}

        public string MotherPhone {get; set;}

        public string FatherPhone {get; set;}

        public string UserAdded {get; set;}

        public DateTime DateAdded {get; set;}

        public string Status { get; set; }

          //Navigation Property: One Education Level can have many Classes
      




        
    }

    }