using BeautyCenter.Models;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard.DTOs
{
   
    public class CreateService
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public string details { get; set; }
        public string Type { get; set; }
        public int TopServic { get; set; }

        // [ForeignKey(nameof(CostomerDet))]
        //public int CostomerDetId { get; set; }
        //public CostomerDet CostomerDet { get; set; }
        public DateTime CreatedDate { get; set; }
        //public ICollection<Employee> Employees { get; set; }
        //public ICollection<User> Users { get; set; }
    }
    public class ServiceDTO: CreateService
        {
            public int Id { get; set; }
      public string ImageURL { get; set; }
        }
    public class UpdateService
    {
       public int ImageId { get; set; }
    }
    public class ServiceFile { 
    public CreateService Create { get; set; }
        public MultipartFormDataContent content { set; get; }
    }
}
