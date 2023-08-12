using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.Models
{
    public class Service
    {
        public int Id { get; set; }
      
        public int Price { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public byte[] ImageArray { get; set; }
        public string details { get; set; }
        [ForeignKey(nameof(CostomerDet))]
        public int ? CostomerDetId { get; set; }
        public CostomerDet? CostomerDet { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<Employee>? Employees { get; set; }
        public ICollection<User>? Users { get; set; }
    }
}
