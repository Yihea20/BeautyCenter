using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.Models
{
    public class CostomerDet
    {
        public int Id { get; set; }
       
        public string? CostomerDetails { get; set; }
        [ForeignKey(nameof(Employee))]
        public string? IdSepacificEmployee { get; set; }
        public Employee? Employee { get; set; }
    }
}
