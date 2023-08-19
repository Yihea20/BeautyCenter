using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.Models
{
    public class Center
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}
