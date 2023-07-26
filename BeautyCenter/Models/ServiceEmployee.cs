using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.Models
{
    public class ServiceEmployee
    {
        public int Id { get; set; }
        [ForeignKey(nameof(Service))]
        public int ServiceId { set; get; }
        public Service Service { get; set; }
        [ForeignKey(nameof(Employee))]
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }

 }
}
