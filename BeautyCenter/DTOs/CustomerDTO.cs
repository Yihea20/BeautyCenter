using BeautyCenter.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.DTOs
{
    public class CreateCustomer
    {

        public string? CostomerDetails { get; set; }
        //[ForeignKey(nameof(Employee))]
        //public string? IdSepacificEmployee { get; set; }
        //public Employee? Employee { get; set; }
        public class CustomerDTO : CreateCustomer
        {
            public int Id { get; set; }
        }
    }
}