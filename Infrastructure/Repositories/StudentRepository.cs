using Application.DTOs;
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



        public List<GetStudentDTO> GetAllStudent()
        {
            
             return _dbcontext.Students.Select(s => new GetStudentDTO
             {
                 Id = s.Id,
                 Name = s.Name,
                 Sex = s.Sex,
                 DateOfBirth = s.DateOfBirth,
                 Phone = s.Phone,
                 Email = s.Email,
                 RegNumber = s.RegNumber,
                 Address = s.Address,
                 MotherName = s.MotherName,
                 FatherName = s.FatherName,
                 MotherPhone = s.MotherPhone,
                 FatherPhone = s.FatherPhone,
                 UserAdded = s.UserAdded,
                 DateAdded = s.DateAdded,
                 Status = s.Status
             }).ToList();
        }

        public void AddStudent(AddStudentDTO student)
        {
              _dbcontext.Students.Add(new Student
              {
                  Name = student.Name,
                  Sex = student.Sex,
                  DateOfBirth = student.DateOfBirth,
                  Phone = student.Phone,
                  Email = student.Email,
                  RegNumber = student.RegNumber,
                  Address = student.Address,
                  MotherName =student.MotherName,
                  FatherName = student.FatherName,
                  MotherPhone = student.MotherName,
                  FatherPhone = student.FatherPhone,
                  UserAdded = "FistonAdmin",
                  DateAdded = DateTime.UtcNow,
                  Status = "Active"

              });
            _dbcontext.SaveChanges();
        }

        public GetStudentDTO? GetStudentById(int id)
        {
            return _dbcontext.Students.Where(s => s.Id == id).Select(s => new GetStudentDTO
            {
                 Id = s.Id,
                 Name = s.Name,
                 Sex = s.Sex,
                 DateOfBirth = s.DateOfBirth,
                 Phone = s.Phone,
                 Email = s.Email,
                 RegNumber = s.RegNumber,
                 Address = s.Address,
                 MotherName = s.MotherName,
                 FatherName = s.FatherName,
                 MotherPhone = s.MotherPhone,
                 FatherPhone = s.FatherPhone,
                 UserAdded = s.UserAdded,
                 DateAdded = s.DateAdded,
                 Status = s.Status
            }).FirstOrDefault();
        }

            public void UpdateStudent(UpdateStudentDTO student)
        {
            // _dbcontext.Students.Update(student);
            // _dbcontext.SaveChanges();

             var ExistingStudent =  _dbcontext.Students.FirstOrDefault(s => s.Id == student.Id);
             if(ExistingStudent != null)
            {
                ExistingStudent.Name = student.Name;
                ExistingStudent.Sex = student.Sex;
                ExistingStudent.DateOfBirth = student.DateOfBirth;
                ExistingStudent.RegNumber = student.RegNumber;
                ExistingStudent.MotherName = student.MotherName;
                ExistingStudent.FatherName = student.FatherName;
                ExistingStudent.MotherPhone = student.MotherPhone;
                ExistingStudent.FatherPhone = student.FatherPhone;
                ExistingStudent.Email = student.Email;
                ExistingStudent.Address = student.Address;
                ExistingStudent.Phone = student.Phone;

                _dbcontext.SaveChanges();
            }


        }



          public void DeleteStudent(DeleteStudentDTO student)
        {
            // _dbcontext.Students.Update(student);
            // _dbcontext.SaveChanges();

             var ExistingStudent =  _dbcontext.Students.FirstOrDefault(s => s.Id == student.Id);
             if(ExistingStudent != null)
            {
                ExistingStudent.Status = student.Status = "Deleted";
                _dbcontext.SaveChanges();
            }


        }
    }
}

