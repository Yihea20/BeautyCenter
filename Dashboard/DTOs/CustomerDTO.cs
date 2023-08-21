using BeautyCenter.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.DTOs
{
    public class CreateCustomer
    {

        public string CostomerDetails { get; set; }
        
       
        public string? IdSepacificEmployee { get; set; }
        

    }
    public class CustomerImage
    {
        public IFormFile File { get; set; }
        public CreateCustomer CreateCustomer { get; set; } 
    }
    public class CustomerDTO : CreateCustomer
        {
            public int Id { get; set; }
    public string ImageUrl { get; set; }   
    }
}