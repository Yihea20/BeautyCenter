
using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard.DTOs
{

    public class CreateAppointment
    {

        public int ServiceId { set; get; }
        //public Service Service { set; get; }
        //[ForeignKey(nameof(User))]
        //public string? UserID { set; get; }
        //public User? User { get; set; }
        //[ForeignKey(nameof(Employee))]
        //public string? EmployeeId { set; get; }
        //public Employee? Employee { get; set; }
        public string Status { set; get; }
       // public Service Service { set; get; }
        public int  EmployeeId { set; get; }
        public int UserID { set; get; }
        public DateTime DateTime { get; set; }
     }
    public class AppointmentDTO : CreateAppointment
    {
        public int Id { get; set; }
    }

    public class EmployeeAppointment {

        public int ServiceId { set; get; }
        public string Status { set; get; }
        public int EmployeeID { set; get; }
        public DateTime DateTime { get; set; }


    }
    public class UserAppointment {

        public int ServiceId { set; get; }
        public string Status { set; get; }
        public int UserID { set; get; }
        public DateTime DateTime { get; set; }

    }
}