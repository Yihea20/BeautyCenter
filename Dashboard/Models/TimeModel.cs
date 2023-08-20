using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.Models
{
    public class TimeModel
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        [ForeignKey(nameof(Employee))]
        public int EmployyId { get; set; }
        public Employee Employee { get; set; }
    }
}
