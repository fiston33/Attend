using Domain.Entities;
using Application.Interfaces;

namespace Application.Services.AttendanceServices
{
   public class AttendanceService:IAttendanceService
    {
        private readonly IAttendance _attendance;

        public AttendanceService(IAttendance attendance)
        {
            _attendance = attendance;
        }

         public List<Attendance> GetAllAttendance()
        {
            return _attendance.GetAllAttendance();
        }
    } 
}
