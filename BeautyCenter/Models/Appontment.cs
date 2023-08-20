using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Status { set; get; }
        [ForeignKey(nameof(Service))]
        public int ServiceId { set; get; }
        public Service Service { set; get; }
        [ForeignKey(nameof(User))]
        public int? UserID { set; get; }
        public virtual User? User { get; set; }
        [ForeignKey(nameof(Employee))]
        public int? EmployeeId { set; get; }
        public virtual Employee? Employee { get; set; }
    }
}
