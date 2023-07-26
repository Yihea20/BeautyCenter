using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.Models
{
    public class Favorate
    {
        public int Id { get; set; }
        [ForeignKey(nameof(User))]
        public string UserID { get; set; }
        public User User { get; set; }
        [ForeignKey(nameof(Employee))]
        public string? EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        [ForeignKey(nameof(Service))]
        public int? ServiceId { get; set; }
        public Service? Service { get; set; } 

    }
}
