using BeautyCenter.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.DTOs
{   public class CreateFavorite
    {
        public int? UserID { get; set; }
        //public User? User { get; set; }
        //[ForeignKey(nameof(Employee))]
        public int? EmployeeId { get; set; }
        //public Employee? Employee { get; set; }
        //[ForeignKey(nameof(Service))]
        public int? ServiceId { get; set; }
        //public Service? Service { get; set; }

        
    }
    public class EmployeeCreateFavorite
    {
        public int? UserID { get; set; }
      
        public int? EmployeeId { get; set; }
        

    }
    public class ServiceCreateFavorite
    {
        public int? UserID { get; set; }
        
        public int? ServiceId { get; set; }
        


    }
    public class FavoriteDTO: CreateFavorite
        {
            public int Id { get; set; }
        }
}
