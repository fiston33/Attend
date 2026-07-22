using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
      public class StudentRepository:IStudent
    {

        private readonly ApplicationDbContext _dbcontext;

        public StudentRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }



        public async Task<List<GetStudentDTO>> GetAllStudentAsync()
        {
            
             return await _dbcontext.Students.Select(s => new GetStudentDTO
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
             }).ToListAsync();
        }

        public async Task AddStudentAsync(AddStudentDTO student)
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
                await _dbcontext.SaveChangesAsync();
        }

        public async Task<GetStudentDTO?> GetStudentByIdAsync(int id)
        {
            return await _dbcontext.Students.Where(s => s.Id == id).Select(s => new GetStudentDTO
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
            }).FirstOrDefaultAsync();
        }

            public async Task UpdateStudentAsync(UpdateStudentDTO student)
        {
            // _dbcontext.Students.Update(student);
            // _dbcontext.SaveChanges();

             var ExistingStudent = await _dbcontext.Students.FirstOrDefaultAsync(s => s.Id == student.Id);
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

              await  _dbcontext.SaveChangesAsync();
            }


        }



          public async Task DeleteStudentAsync(DeleteStudentDTO student)
        {
            // _dbcontext.Students.Update(student);
            // _dbcontext.SaveChanges();

             var ExistingStudent = await _dbcontext.Students.FirstOrDefaultAsync(s => s.Id == student.Id);
             if(ExistingStudent != null)
            {
                ExistingStudent.Status = student.Status = "Deleted";
               await _dbcontext.SaveChangesAsync();
            }


        }
    }
}

