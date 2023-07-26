using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.Models
{
    public class Appontment
    {
        public int Id { get; set; }
        [ForeignKey(nameof(Service))]
        public int ServiceId { set; get; }
        public Service Service { set; get; }
        [ForeignKey(nameof(User))]
        public string ? UserID { set; get; }
        public User? User { get; set; }
        [ForeignKey(nameof(Employee))]
        public string ? EmployeeId { set; get; }
        public Employee? Employee { get; set; }
        public DateTime DateTime { get; set; }
    }
}
