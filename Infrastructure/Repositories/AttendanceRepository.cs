using Application.Interfaces;
using Domain.Entities;

namespace Infrastructure.Repositories
{
    public class AttendanceRepository:IAttendance

    // I have Question Here
    {
        public List<Attendance> GetAllAttendance()
        {
            return new List<Attendance>
            {
                new Attendance {Id=1, studentId=1, classsId=1, AttendanceDateTime = new DateTime(2026,12,12)}
            };
        }
    }
}
