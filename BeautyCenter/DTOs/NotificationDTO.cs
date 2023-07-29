using BeautyCenter.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.DTOs
{
    public class CreateNotification
    {

        public string Title { get; set; }
    
      //  public int? ServiceId { get; set; }
       // public Service? Service { get; set; }
        public class NotificationDTO
        {
            public int Id { set; get; }
        }
    }
}