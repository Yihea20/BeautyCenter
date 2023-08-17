using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.Models
{
    public class CustomerDet
    {
        public int Id { get; set; }
       
        public string? CustomerDetails { get; set; }
        public string? ImageUrl { get; set; }
        [ForeignKey(nameof(Employee))]
        public int? IdSepacificEmployee { get; set; }
        public Employee? Employee { get; set; }
    }
}
