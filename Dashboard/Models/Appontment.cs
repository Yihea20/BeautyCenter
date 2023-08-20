using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        [ForeignKey(nameof(Service))]
        public DateTime DateTime { get; set; }
        public string Status { set; get; }
        public int? ServiceId { set; get; }
        public Service Service { set; get; }
        [ForeignKey(nameof(User))]
        public int? UserID { set; get; }
        public User? User { get; set; }
        [ForeignKey(nameof(Employee))]
        public int? EmployeeId { set; get; }
        public Employee? Employee { get; set; }
    }
}
