using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.Models
{
    public class Favorite
    {
        public int Id { get; set; }
        [ForeignKey(nameof(User))]
        public int? UserID { get; set; }
        public User? User { get; set; }
        [ForeignKey(nameof(Employee))]
        public int? EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        [ForeignKey(nameof(Service))]
        public int? ServiceId { get; set; }
        public Service? Service { get; set; } 

    }
}
