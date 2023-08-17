using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.Models
{
    public class Service
    {
        public int Id { get; set; }
      
        public int Price { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public string ImageURL { get; set; }
        public string details { get; set; }
        [ForeignKey(nameof(CustomerDet))]
        public int ? CustomerDetId { get; set; }
        public CustomerDet? CustomerDet { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<Employee>? EmployeesCanDo { get; set; }
        public ICollection<Employee>? EmployeesHasService { get; set; }
        public ICollection<User>? Users { get; set; }
    }
}
