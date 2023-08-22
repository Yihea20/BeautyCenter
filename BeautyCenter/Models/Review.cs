using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Reviews { get; set; }
        public int Like { get; set; }
        [ForeignKey(nameof(Service))]
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        [ForeignKey(nameof(Employee))]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
