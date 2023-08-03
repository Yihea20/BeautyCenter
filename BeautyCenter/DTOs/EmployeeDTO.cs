using BeautyCenter.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.DTOs
{
    public class CreateEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CenterId { get; set; }
  
        public int Points { get; set; }
        public int Rate { get; set; }
        
        public int TotlaRate { get; set; }
        //public ICollection<Service>? ServicesCanDo { get; set; }
        public DateTime DateTime { get; set; }
        public string Exp { get; set; }

        public class EmployeeDTO :CreateEmployee
        {
            public int Id { get; set; }
        }
    }
}